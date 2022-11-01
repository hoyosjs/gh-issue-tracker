using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using gh_issue_diagnostics.Config;
using Octokit;


ReportCreator report = new(Config.ReportName);

await report.InitializePriorResultsFromJson(args[0]);

await report.QueryIssuesAsync(Config.Repos);

await report.WriteAsync(Config.ReportPath);

internal class ReportCreator
{
    record struct QueryStats (int CurrentIssues, int NewIssues, int ClosedIssues, int MovedInIssues, int MovedOutIssues)
    {
        public override string ToString() =>
            @$"**Current total**: {CurrentIssues}
**New**: {NewIssues}
**Closed**: {ClosedIssues}
**Moved In**: {MovedInIssues}
**Moved Out** {MovedOutIssues}";

        public static QueryStats operator+(QueryStats lhs, QueryStats rhs) => new (
            CurrentIssues: lhs.CurrentIssues + rhs.CurrentIssues,
            NewIssues: lhs.NewIssues + rhs.NewIssues,
            ClosedIssues: lhs.ClosedIssues + rhs.ClosedIssues,
            MovedInIssues: lhs.MovedInIssues + rhs.MovedInIssues,
            MovedOutIssues: lhs.MovedOutIssues + rhs.MovedOutIssues);
    }

    record class IssueReportResult(string Repository, int IssueId, string IssueName, string IssueUrl, IssueType Type, string OriginatorQuery);

    enum IssueType
    {
        New,
        Closed,
        MovedIn,
        MovedOut,
        Old,
    }


    private QueryStats _totalStats;
    private readonly GitHubClient _ghClient;
    private readonly string _reportName;
    private readonly Dictionary<string, (DateTimeOffset, IReadOnlyList<IssueReportResult>)> _reportResults;
    private readonly Dictionary<string, (DateTimeOffset, IReadOnlyList<int>)> _priorResults;

    public ReportCreator(string reportName)
    {
        _ghClient = new GitHubClient(new ProductHeaderValue(reportName));
        _totalStats = new QueryStats();
        _reportName = reportName;
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

        foreach (var item in jd.RootElement.EnumerateObject())
        {
            string queryId = item.Name;
            DateTimeOffset date = DateTimeOffset.Parse(item.Value.GetProperty("lastIssueDate").GetString()!);
            IReadOnlyList<int> idList = item.Value.GetProperty("issueIdList").EnumerateArray().Select(x => x.GetInt32()).ToList();
            _priorResults[queryId] = (date,idList);
        }
    }

    public async Task QueryIssuesAsync(IReadOnlyList<RepoQueries> repos)
    {
        SearchIssuesRequest queryArgs = new()
        {
            Exclusions = null,
            Labels = null,
            Repos = null,
            Order = SortDirection.Descending,
            SortField = IssueSearchSort.Created, 
            State = ItemState.Open,
            Type = IssueTypeQualifier.Issue
        };

        foreach (RepoQueries repoQuerySet in repos)
        {
            queryArgs.Repos = new RepositoryCollection { repoQuerySet.RepoName };
            queryArgs.Exclusions = repoQuerySet.Exclusions;

            foreach ((string queryId, string[]? labels) in repoQuerySet.GetNextQueryIdAndLabels())
            {
                queryArgs.Labels = labels;
                SearchIssuesResult results = await _ghClient.Search.SearchIssues(queryArgs);

                QueryStats singleQueryResults = await ProcessIssuesForQueryAsync(repoQuerySet.RepoName, queryId, results);
                _totalStats += singleQueryResults;
            }
        }

        async Task<QueryStats> ProcessIssuesForQueryAsync(string repo, string queryId, SearchIssuesResult results)
        {
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
                    seenIssues.Add(issue.Number);
                }
                else
                {
                    type = IssueType.MovedIn;
                    singleQueryStats.MovedInIssues++;
                }

                classifiedIssues.Add(new(repo, issue.Number, issue.Title, issue.HtmlUrl, type, queryId));
            }

            foreach (int issueId in priorIssueIdList)
            {
                if (seenIssues.Contains(issueId))
                {
                    continue;
                }

                Issue issue = await _ghClient.Issue.Get(repoOrg, repoName, issueId);
                    singleQueryStats.MovedInIssues++;

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
    public async Task WriteAsync(string reportPath)
    {
        Directory.CreateDirectory(reportPath);

        JsonObject doc = new()
        {
            {
                "totalStats",
                JsonSerializer.SerializeToNode(_totalStats)
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

            doc.Add(key,
                new JsonObject {
                    ["lastIssueDate"] = newestIssueDate,
                    ["issuesInQuery"] = activeCount,
                    ["issueIdList"] = issueIdList
                });
        }

        using FileStream cacheFs = File.Create(Path.Combine(reportPath, $"{_reportName}.json"));
        await JsonSerializer.SerializeAsync(cacheFs, doc, new JsonSerializerOptions
        {
            WriteIndented = true 
        });

        using StreamWriter txtWriter = File.CreateText(Path.Combine(reportPath, $"{_reportName}.md"));

        await txtWriter.WriteLineAsync($"# {_reportName}");
        await txtWriter.WriteLineAsync("## Overall Stats");
        await txtWriter.WriteLineAsync();
        await txtWriter.WriteLineAsync(_totalStats.ToString());
        await txtWriter.WriteLineAsync();

        await WriteReportSection("New Issues", IssueType.New);
        await WriteReportSection("Closed Issues", IssueType.Closed);
        await WriteReportSection("Moved Issues", IssueType.MovedIn);
        await WriteReportSection("Removed Issues", IssueType.MovedOut);

        async Task WriteReportSection(string v, IssueType issueTypeToPrint)
        {
            await txtWriter.WriteLineAsync($"## {v}");
            await txtWriter.WriteLineAsync();

            await txtWriter.WriteLineAsync("| **Issue Number**      | **Title** |");
            await txtWriter.WriteLineAsync("| :-----------: | ----------- |");

            foreach ((_, IReadOnlyList<IssueReportResult> issueResults) in _reportResults.Values)
            {
                foreach(IssueReportResult issue in issueResults.Where(x => x.Type == issueTypeToPrint))
                {
                    await txtWriter.WriteLineAsync($"| [{issue.Repository}#{issue.IssueId}]({issue.IssueUrl}) | {issue.IssueName} |");
                }
            }

            await txtWriter.WriteLineAsync();
        }
    }
}

readonly struct RepoQueries
{
    internal RepoQueries(string name,
            List<string[]?> labels,
            SearchIssuesRequestExclusions exclusions,
            int version)
    {
        RepoName = name;
        Labels = labels;
        Exclusions = exclusions;
        _version = version;
    }

    public string RepoName { get; init; }
    public List<string[]?> Labels { get; init; }
    public SearchIssuesRequestExclusions Exclusions { get; init; }

    // TODO: define migration and versioning of ID.
    private readonly int _version;
    const int _serializerVerison = 1;
    internal IEnumerable<(string queryId, string[]? queryLabels)> GetNextQueryIdAndLabels()
    {
        foreach (string[]? labelSet in Labels)
        {
            StringBuilder sb = new (50);
            sb.Append($"v{_version},{_serializerVerison}-{RepoName}");
            if (labelSet is not null)
            {
                sb.Append('|');
                sb.AppendJoin("-", labelSet);
            }
            yield return (sb.ToString(), labelSet);
        }
    }
}