using System.Text.Json;
using System.Text.Json.Nodes;
using Octokit;
using gh_issue_tracker.Models;
using Polly.Retry;
using Polly;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace gh_issue_tracker.Report;

internal class ReportCreator
{
    private static class SerializationConstants
    {
        public const string Stats = "totalStats";
        public const string Results = "queryResults";
        public const string Date = "dateUtc";

        public const string LatestIssueDate = "lastIssueDate";
        public const string IssueQueryCount = "issuesInQuery";
        public const string IssueIdList = "issueIdList";
    }

    public enum ReportGenerationType
    {
        Comparative,
        Full,
        All,
        Invalid
    }

    const long SecLimitPerReq = 61;
    const long TotalMaxRetryWaitInSec = 60 * 50;

    private QueryStats _totalStats;
    private readonly AsyncRetryPolicy _ghRetryPolicy;
    private long _totalSecsLeftForRetry;
    private readonly string _friendlyReportName;
    private readonly GitHubClient _ghClient;
    private readonly Dictionary<string, (DateTimeOffset, IList<IssueReportResult>)> _reportResults;
    private readonly Dictionary<string, (DateTimeOffset, IEnumerable<int>)> _priorResults;
    public readonly ILogger _logger;

    public ReportCreator(string friendlyName, string clientName, string? pat = null, ILogger? logger = null)
    {
        _totalStats = new QueryStats();
        _reportResults = new Dictionary<string, (DateTimeOffset, IList<IssueReportResult>)>();
        _priorResults = new Dictionary<string, (DateTimeOffset, IEnumerable<int>)>();
        _ghClient = new GitHubClient(new ProductHeaderValue(clientName));

        _logger = logger ?? NullLogger.Instance;
        _friendlyReportName = friendlyName;

        if (pat is not null)
        {
            _logger.LogInformation("Using authenticated client.");
            _ghClient.Credentials = new Credentials(pat);
        }
        else
        {
            _logger.LogInformation("Using anonymous client.");
        }

        _ghRetryPolicy = Policy
                            .Handle<RateLimitExceededException>()
                            .Or<SecondaryRateLimitExceededException>()
                            .WaitAndRetryAsync(retryCount: 1,
                                sleepDurationProvider: GetBackoffForPolicy,
                                onRetryAsync: LogRetry);

        _totalSecsLeftForRetry = TotalMaxRetryWaitInSec;
    }

    public async Task InitializePriorResultsFromJson(string priorReportCachePath)
    {
        using var _ = _logger.BeginScope("Loading cached results.");
        if (!File.Exists(priorReportCachePath))
        {
            _logger.LogWarning("Unable to find cache file {cachefile}", priorReportCachePath);
            return;
        }

        using FileStream cacheFs = File.OpenRead(priorReportCachePath);
        JsonDocument jd = await JsonDocument.ParseAsync(cacheFs);
        JsonElement results = jd.RootElement.GetProperty(SerializationConstants.Results);


        foreach (var item in results.EnumerateObject())
        {
            string queryId = item.Name;

            DateTimeOffset date = DateTimeOffset.Parse(
                item.Value.GetProperty(SerializationConstants.LatestIssueDate).GetString()!);

            IReadOnlyList<int> idList = item.Value
                .GetProperty(SerializationConstants.IssueIdList)
                .EnumerateArray().Select(x => x.GetInt32()).ToList();

            _priorResults[queryId] = (date, idList);
        }

        _logger.LogInformation("Initialized from cache file {cachefile}", priorReportCachePath);
    }

    public async Task QueryIssuesAsync(IReadOnlyList<GitHubQuery> queries)
    {
        using var _ = _logger.BeginScope("Querying.");

        SearchIssuesRequest queryArgs = new()
        {
            Exclusions = new SearchIssuesRequestExclusions(),
            Labels = null,
            Repos = null,
            Order = SortDirection.Descending,
            SortField = IssueSearchSort.Created,
            State = ItemState.Open,
            Type = IssueTypeQualifier.Issue,
        };

        foreach (GitHubQuery query in queries)
        {
            queryArgs.Repos = new RepositoryCollection { query.RepoName };
            queryArgs.Exclusions.Labels = query.ExcludedLabels;
            queryArgs.Exclusions.Milestone = query.ExcludedMilestone;
            queryArgs.Labels = query.Labels;
            queryArgs.Milestone = query.Milestone;
            queryArgs.Page = 1;

            QueryStats singleQueryResults = await ProcessIssuesForQueryAsync(query.RepoName, query.GetQueryId(), queryArgs);
            _totalStats += singleQueryResults;
        }

        // Deduplicate issues that might be moving between queries.

        // This is kinda nasty - it depends on mutability of the class IssueReportResult.
        List<IssueReportResult> fullResults = _reportResults.SelectMany(x => x.Value.Item2).ToList();
        fullResults.Sort((lhs, rhs) => lhs.IssueId.CompareTo(rhs.IssueId));

        for (int i = 0; i + 1 < fullResults.Count; i++)
        {
            if (fullResults[i].IssueId == fullResults[i + 1].IssueId)
            {
                fullResults[i].Type = IssueType.Old;
                fullResults[i + 1].Type = IssueType.Old;
            }
        }

        async Task<QueryStats> ProcessIssuesForQueryAsync(string repo, string queryId, SearchIssuesRequest queryArgs)
        {
            using var _ = _logger.BeginScope("Query {queryId}.", queryId);
            _logger.LogInformation("Processing Query {queryId}.", queryId);

            // TODO: Store them split in the model...
            string[] repoSplit = repo.Split('/');
            string repoOrg = repoSplit[0];
            string repoName = repoSplit[1];

            SearchIssuesResult results = await _ghRetryPolicy.ExecuteAsync(async () => await _ghClient.Search.SearchIssues(queryArgs));

            QueryStats singleQueryStats = new()
            {
                CurrentIssues = results.TotalCount
            };

            DateTimeOffset newestIssueTime = results.TotalCount > 0 ? results.Items[0].CreatedAt : DateTimeOffset.MinValue;

            (DateTimeOffset priorNewestIssueTime, IEnumerable<int> priorIssueIdList) = GetPriorResultFromQueryIdOrDefault(queryId);

            HashSet<int> seenIssues = new();

            int expectedTotal = results.TotalCount;
            List<IssueReportResult> classifiedIssues = new(expectedTotal);

            _logger.LogInformation("Found {issueCount} active issues for query.", expectedTotal);

            // Handle pagination
            while (classifiedIssues.Count < expectedTotal)
            {
                _logger.LogDebug("Processing page {page}.", queryArgs.Page);

                foreach (var issue in results.Items)
                {
                    IssueType type;

                    if (issue.CreatedAt > priorNewestIssueTime)
                    {
                        type = IssueType.New;
                        singleQueryStats.NewIssues++;
                    }
                    else if (priorIssueIdList.Contains(issue.Number))
                    {
                        type = IssueType.Old;
                    }
                    else
                    {
                        type = IssueType.MovedIn;
                        singleQueryStats.MovedInIssues++;
                    }

                    seenIssues.Add(issue.Number);
                    classifiedIssues.Add(new(repo, issue.Number, issue.Title, issue.HtmlUrl, type, queryId, issue.CreatedAt));
                    _logger.LogTrace("Issue {repo}#{number} classified {type}.", repo, issue.Number, type);

                }

                if (classifiedIssues.Count >= expectedTotal)
                {
                    break;
                }

                queryArgs.Page++;
                results = await _ghRetryPolicy.ExecuteAsync(async () => await _ghClient.Search.SearchIssues(queryArgs));
            }

            foreach (int issueId in priorIssueIdList)
            {
                if (seenIssues.Contains(issueId))
                {
                    continue;
                }

                Issue issue = await _ghRetryPolicy.ExecuteAsync(async () => await _ghClient.Issue.Get(repoOrg, repoName, issueId));

                IssueType type;
                if (issue.State.Value == ItemState.Closed)
                {
                    type = IssueType.Closed;
                    singleQueryStats.ClosedIssues++;
                }
                else
                {
                    type = IssueType.MovedOut;
                    singleQueryStats.MovedOutIssues++;
                }

                classifiedIssues.Add(new(repo, issue.Number, issue.Title, issue.HtmlUrl, type, queryId, issue.CreatedAt));
                _logger.LogTrace("Old issue {repo}#{number} classified {type}.", repo, issue.Number, type);
            }

            _reportResults.Add(queryId, (newestIssueTime, classifiedIssues));

            _logger.LogInformation("Query stats: {number}", singleQueryStats);
            return singleQueryStats;
        }

        (DateTimeOffset newestIssue, IEnumerable<int> issueList) GetPriorResultFromQueryIdOrDefault(string queryId)
        {
            bool results = _priorResults.TryGetValue(queryId, out (DateTimeOffset newestIssue, IEnumerable<int> issueList) result);

            if (!results)
            {
                result.newestIssue = DateTimeOffset.MinValue;
                result.issueList = Enumerable.Empty<int>();
            }

            return result;
        }
    }

    // TODO: this could easily be better
    public async Task WriteAsync(string reportPath, string reportFilePrefix, int? slaHighlightsTimeInMonths, ReportGenerationType reportType)
    {
        using var writeScope = _logger.BeginScope("Reports");
        _logger.LogInformation("Writing Reports to {reportPath}.", reportPath);

        DateTime reportTime = DateTime.UtcNow;
        string fileTimeString = reportTime.ToString("yyyy-MM-dd-hh-mm");
        bool shouldIncludeSla = slaHighlightsTimeInMonths.HasValue;
        DateTimeOffset slaCapDate = shouldIncludeSla ? reportTime.AddMonths(-1 * slaHighlightsTimeInMonths!.Value) : default;

        string subReportPath = Path.Join(reportPath, fileTimeString);
        Directory.CreateDirectory(subReportPath);

        if (reportType is ReportGenerationType.Comparative or ReportGenerationType.All)
        {
            await UpdateGlobalCSV(reportPath, reportFilePrefix, reportTime);
            await GenerateJsonCacheAsync(subReportPath, reportFilePrefix, reportTime);
            await GenerateCompReportAsync(subReportPath,
                                    reportFilePrefix,
                                    reportTime);
        }

        if (reportType is ReportGenerationType.Full or ReportGenerationType.All)
        {
            await WriteFullReport(subReportPath);
        }

        async Task GenerateCompReportAsync(string reportPath,
                                       string reportFilePrefix,
                                       DateTime reportTime)
        {
            using var scope = _logger.BeginScope("Comparative Report");
            _logger.BeginScope("Writing comparative Report");
            using StreamWriter txtWriter = File.CreateText(Path.Combine(reportPath, $"{reportFilePrefix}-comp.md"));

            await txtWriter.WriteLineAsync($"# {_friendlyReportName} Comparative Report - {reportTime}");
            await txtWriter.WriteLineAsync();
            await txtWriter.WriteLineAsync("## Overall Stats");
            await txtWriter.WriteLineAsync();
            await txtWriter.WriteLineAsync(_totalStats.ToString());
            await txtWriter.WriteLineAsync();

            await WriteCompReportSection(txtWriter, "New Issues", x => x.Type == IssueType.New);
            await WriteCompReportSection(txtWriter, "Closed Issues", x => x.Type == IssueType.Closed);
            await WriteCompReportSection(txtWriter, "Moved In Issues", x => x.Type == IssueType.MovedIn);
            await WriteCompReportSection(txtWriter, "Removed Issues", x => x.Type == IssueType.MovedOut);
            if (shouldIncludeSla)
            {
                await WriteCompReportSection(txtWriter,
                                            $"Issues Out of Time SLA ({slaHighlightsTimeInMonths} months)",
                                            x => x.CreationTime < slaCapDate && x.Type is not IssueType.Closed and not IssueType.MovedOut);
            }
        }

        async Task WriteCompReportSection(StreamWriter txtWriter, string sectionName, Func<IssueReportResult, bool> filterResultLambda)
        {
            await txtWriter.WriteLineAsync($"## {sectionName}");
            await txtWriter.WriteLineAsync();

            await txtWriter.WriteLineAsync("| **Issue Number** | **Title** |");
            await txtWriter.WriteLineAsync("| :--------------: | --------- |");

            foreach ((_, IList<IssueReportResult> issueResults) in _reportResults.Values)
            {
                foreach (IssueReportResult issue in issueResults.Where(filterResultLambda))
                {
                    await txtWriter.WriteLineAsync($"| [{issue.Repository}#{issue.IssueId}]({issue.IssueUrl}) | {issue.IssueName} |");
                }
            }

            await txtWriter.WriteLineAsync();
        }

        async Task WriteFullReport(string reportPath)
        {
            using var scope = _logger.BeginScope("Full Report");
            _logger.BeginScope("Writing Full Report");

            using StreamWriter txtWriter = File.CreateText(Path.Combine(reportPath, $"{reportFilePrefix}-full.md"));

            await txtWriter.WriteLineAsync($"# {_friendlyReportName} Full Report - {reportTime}");
            await txtWriter.WriteLineAsync();
            await txtWriter.WriteLineAsync($"Total issues: {_totalStats.CurrentIssues}");
            await txtWriter.WriteLineAsync();

            foreach ((string query, (_, IList<IssueReportResult> issueResults)) in _reportResults)
            {
                await txtWriter.WriteLineAsync($"## {query}");
                await txtWriter.WriteLineAsync();

                var curIssues = issueResults
                                    .Where(x => x.Type is not IssueType.Closed and not IssueType.MovedOut)
                                    .ToList();

                await txtWriter.WriteLineAsync($"Issues in query: {curIssues.Count}");
                await txtWriter.WriteLineAsync();

                if (curIssues.Count == 0)
                {
                    continue;
                }

                await txtWriter.WriteLineAsync("| **Issue Number** | **Title** |");
                await txtWriter.WriteLineAsync("| :--------------: | --------- |");

                foreach (IssueReportResult issue in curIssues)
                {
                    string name = shouldIncludeSla && slaCapDate > issue.CreationTime ?
                        @$"**\<OUT OF SLA\>** {issue.IssueName}" :
                        $"{issue.IssueName}";
                    await txtWriter.WriteLineAsync($"| [{issue.Repository}#{issue.IssueId}]({issue.IssueUrl}) | {name} |");
                }

                await txtWriter.WriteLineAsync();
            }
        }

        async Task GenerateJsonCacheAsync(string reportPath, string reportFilePrefix, DateTime reportTime)
        {
            using var scope = _logger.BeginScope("Json cache");
            _logger.BeginScope("Writing json cache");
            JsonObject results = new();

            JsonObject doc = new()
            {
                {
                    SerializationConstants.Stats,
                    JsonSerializer.SerializeToNode(_totalStats)
                },
                {
                    SerializationConstants.Date,
                    reportTime.ToString("yyyy-MM-dd-hh-mm")
                },
                {
                    SerializationConstants.Results,
                    results
                }
            };

            foreach ((string key, (DateTimeOffset newestIssueDate, IList<IssueReportResult> issueResults)) in _reportResults)
            {
                JsonArray issueIdList = new();
                int activeCount = 0;

                foreach (IssueReportResult issue in issueResults)
                {
                    if (issue.Type is IssueType.New or IssueType.MovedIn or IssueType.Old)
                    {
                        issueIdList.Add(issue.IssueId);
                        activeCount++;
                    }
                }

                results.Add(key,
                    new JsonObject
                    {
                        [SerializationConstants.LatestIssueDate] = newestIssueDate,
                        [SerializationConstants.IssueQueryCount] = activeCount,
                        [SerializationConstants.IssueIdList] = issueIdList
                    });
            }

            using FileStream cacheFs = File.Create(Path.Combine(reportPath, $"{reportFilePrefix}-cache.json"));
            await JsonSerializer.SerializeAsync(cacheFs, doc);
        }

        async Task UpdateGlobalCSV(string reportPath, string reportFilePrefix, DateTime reportTime)
        {
            using var scope = _logger.BeginScope("CSV Table");
            _logger.BeginScope("Updating CSV");

            string csvPath = Path.Combine(reportPath, $"{reportFilePrefix}-totals.csv");
            bool needsHeader = !File.Exists(csvPath);
            using StreamWriter sw = new(csvPath, append: true);

            if (needsHeader)
                await sw.WriteLineAsync("date_utc,current_count,new_issues,closed_issues,moved_in,moved_out");

            sw.WriteLine($"{reportTime:MM-dd-yy},{_totalStats.CurrentIssues},{_totalStats.NewIssues},{_totalStats.ClosedIssues},{_totalStats.MovedInIssues},{_totalStats.MovedOutIssues}");
        }
    }

    private TimeSpan GetBackoffForPolicy(int retry, Exception ex, Context ctx)
    {
        var apiEx =  (ApiException)ex;

        var header = apiEx.HttpResponse
                        .Headers
                        .FirstOrDefault(h => string.Equals(h.Key, "Retry-After", StringComparison.OrdinalIgnoreCase));

        long retryTimeInSec = 0;
        if (header.Equals(default(KeyValuePair<string, string>)))
        {
            header = apiEx.HttpResponse
                        .Headers
                        .FirstOrDefault(h => string.Equals(h.Key, "x-ratelimit-reset", StringComparison.OrdinalIgnoreCase));

            if (header.Equals(default(KeyValuePair<string, string>)) 
                || !long.TryParse(header.Value, out retryTimeInSec))
            {
                throw new ApplicationException("Unable to determine rate limit cool off.");
            }

            retryTimeInSec -= DateTimeOffset.Now.ToUnixTimeSeconds();
        }
        else
        {
            if (header.Equals(default(KeyValuePair<string, string>)) 
                || !long.TryParse(header.Value, out retryTimeInSec))
            {
                throw new ApplicationException("Unable to determine rate limit cool off.");
            }
        }

        if (retryTimeInSec > SecLimitPerReq)
        {
            throw new ApplicationException($"Requested {retryTimeInSec} secs exceeds maximum of {SecLimitPerReq}.", apiEx);
        }
        if (retryTimeInSec > _totalSecsLeftForRetry)
        {
            throw new ApplicationException($"Maximum retry allocation for report exceeded", apiEx);
        }

        _totalSecsLeftForRetry -= retryTimeInSec;

        return TimeSpan.FromSeconds(retryTimeInSec);
    }

    private Task LogRetry(Exception ex, TimeSpan wait, int retry, Context ctx)
    {
        _logger.LogWarning("[{retry}] Received rate limitting exception, waiting {wait} secs.", retry, wait.Seconds);
        return Task.CompletedTask;
    }
}
