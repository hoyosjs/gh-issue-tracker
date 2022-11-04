using System.Text.Json;
using System.Text.Json.Nodes;
using Octokit;
using gh_issue_tracker.Models;

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

    private QueryStats _totalStats;
    private readonly string _friendlyReportName;
    private readonly GitHubClient _ghClient;
    private readonly Dictionary<string, (DateTimeOffset, IReadOnlyList<IssueReportResult>)> _reportResults;
    private readonly Dictionary<string, (DateTimeOffset, IReadOnlyList<int>)> _priorResults;

    public ReportCreator(string friendlyName, string clientName, string? secretPath = null)
    {
        _ghClient = new GitHubClient(new ProductHeaderValue(clientName));

        if (secretPath is not null)
        {
            // TODO: consider requiring user requirements
            using StreamReader cacheFs = File.OpenText(secretPath);
            _ghClient.Credentials = new Credentials(cacheFs.ReadLine());
        }

        _totalStats = new QueryStats();
        _friendlyReportName = friendlyName;
        _reportResults = new Dictionary<string, (DateTimeOffset, IReadOnlyList<IssueReportResult>)>();
        _priorResults = new Dictionary<string, (DateTimeOffset, IReadOnlyList<int>)>();
    }

    public async Task InitializePriorResultsFromJson(string priorReportCachePath)
    {
        // TODO: Log
        if (!File.Exists(priorReportCachePath))
            return;

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
    }

    public async Task QueryIssuesAsync(IReadOnlyList<GitHubQuery> queries)
    {
        SearchIssuesRequest queryArgs = new()
        {
            Exclusions = new SearchIssuesRequestExclusions(),
            Labels = null,
            Repos = null,
            Order = SortDirection.Descending,
            SortField = IssueSearchSort.Created,
            State = ItemState.Open,
            Type = IssueTypeQualifier.Issue
        };

        foreach (GitHubQuery query in queries)
        {
            queryArgs.Repos = new RepositoryCollection { query.RepoName };
            queryArgs.Exclusions.Labels = query.ExcludedLabels;
            queryArgs.Exclusions.Milestone = query.ExcludedMilestone;
            queryArgs.Labels = query.Labels;

            SearchIssuesResult results = await _ghClient.Search.SearchIssues(queryArgs);
            QueryStats singleQueryResults = await ProcessIssuesForQueryAsync(query.RepoName, query.GetQueryId(), results);
            _totalStats += singleQueryResults;
        }

        async Task<QueryStats> ProcessIssuesForQueryAsync(string repo, string queryId, SearchIssuesResult results)
        {
            // TODO: Store them split in the model...
            string[] repoSplit = repo.Split('/');
            string repoOrg = repoSplit[0];
            string repoName = repoSplit[1];

            QueryStats singleQueryStats = new()
            {
                CurrentIssues = results.TotalCount
            };

            DateTimeOffset newestIssueTime = results.TotalCount > 0 ? results.Items[0].CreatedAt : DateTimeOffset.MinValue;

            (DateTimeOffset priorNewestIssueTime, IReadOnlyList<int> priorIssueIdList) = GetPriorResultFromQueryIdOrDefault(queryId);

            HashSet<int> seenIssues = new();

            List<IssueReportResult> classifiedIssues = new(results.Items.Count);

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
                classifiedIssues.Add(new(repo, issue.Number, issue.Title, issue.HtmlUrl, type, queryId));
            }

            foreach (int issueId in priorIssueIdList)
            {
                if (seenIssues.Contains(issueId))
                {
                    continue;
                }

                Issue issue = await _ghClient.Issue.Get(repoOrg, repoName, issueId);

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

                classifiedIssues.Add(new(repo, issue.Number, issue.Title, issue.HtmlUrl, type, queryId));
            }

            _reportResults.Add(queryId, (newestIssueTime, classifiedIssues));
            return singleQueryStats;
        }

        (DateTimeOffset newestIssue, IReadOnlyList<int> issueList) GetPriorResultFromQueryIdOrDefault(string queryId)
        {
            bool results = _priorResults.TryGetValue(queryId, out (DateTimeOffset newestIssue, IReadOnlyList<int> issueList) result);

            if (!results)
            {
                result.newestIssue = DateTimeOffset.MinValue;
                result.issueList = new List<int>();
            }

            return result;
        }
    }

    // TODO: this could easily be better
    public async Task WriteAsync(string reportPath, string reportFilePrefix)
    {
        Directory.CreateDirectory(reportPath);
        DateTime reportTime = DateTime.UtcNow;

        await GenerateJsonCacheAsync(reportPath, reportFilePrefix, reportTime);
        await GenerateReportAsync(reportPath, reportFilePrefix, reportTime);

        async Task GenerateReportAsync(string reportPath, string reportFilePrefix, DateTime reportTime)
        {
            using StreamWriter txtWriter = File.CreateText(Path.Combine(reportPath, $"{reportFilePrefix}-{reportTime:yyyy-MM-dd-hh-mm}.md"));

            await txtWriter.WriteLineAsync($"# {_friendlyReportName} - {reportTime}");
            await txtWriter.WriteLineAsync();
            await txtWriter.WriteLineAsync("## Overall Stats");
            await txtWriter.WriteLineAsync();
            await txtWriter.WriteLineAsync(_totalStats.ToString());
            await txtWriter.WriteLineAsync();

            await WriteReportSection(txtWriter, "New Issues", IssueType.New);
            await WriteReportSection(txtWriter, "Closed Issues", IssueType.Closed);
            await WriteReportSection(txtWriter, "Moved Issues", IssueType.MovedIn);
            await WriteReportSection(txtWriter, "Removed Issues", IssueType.MovedOut);
        }

        async Task WriteReportSection(StreamWriter txtWriter, string sectionName, IssueType issueTypeToPrint)
        {
            await txtWriter.WriteLineAsync($"## {sectionName}");
            await txtWriter.WriteLineAsync();

            await txtWriter.WriteLineAsync("| **Issue Number** | **Title** |");
            await txtWriter.WriteLineAsync("| :--------------: | --------- |");

            foreach ((_, IReadOnlyList<IssueReportResult> issueResults) in _reportResults.Values)
            {
                foreach (IssueReportResult issue in issueResults.Where(x => x.Type == issueTypeToPrint))
                {
                    await txtWriter.WriteLineAsync($"| [{issue.Repository}#{issue.IssueId}]({issue.IssueUrl}) | {issue.IssueName} |");
                }
            }

            await txtWriter.WriteLineAsync();
        }

        async Task GenerateJsonCacheAsync(string reportPath, string reportFilePrefix, DateTime reportTime)
        {
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

            foreach ((string key, (DateTimeOffset newestIssueDate, IReadOnlyList<IssueReportResult> issueResults)) in _reportResults)
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
                        [SerializationConstants.IssueIdList]     = issueIdList
                    });
            }

            using FileStream cacheFs = File.Create(Path.Combine(reportPath, $"{reportFilePrefix}-{reportTime:yyyy-MM-dd-hh-mm}.json"));
            await JsonSerializer.SerializeAsync(cacheFs, doc);
        }

    }
}