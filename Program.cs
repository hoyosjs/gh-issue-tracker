using System.Text.Json;
using gh_issue_tracker.Models;
using gh_issue_tracker.Report;

if (args.Length > 2
    || (args[0] == "-h" || args[0] == "--help")
    || (args[1] == "-h" || args[1] == "--help"))
{
    Console.WriteLine("Usage: <path to config> <path to prior query json>");
    return 1;
}

using var configFs = File.OpenRead(args[0]);
using JsonDocument jdoc = await JsonDocument.ParseAsync(configFs);

ReportConfig rc = jdoc.RootElement.GetProperty(nameof(ReportConfig)).Deserialize<ReportConfig>();
List<QueryConfig> qc = jdoc.RootElement.GetProperty("QueryConfigs").Deserialize<List<QueryConfig>>()!;

string? ghPat = null;

if (rc.SecretFilePath is not null)
{
    // TODO: consider requiring user requirements
    using StreamReader cacheFs = File.OpenText(rc.SecretFilePath);
    ghPat = cacheFs.ReadLine();
}

if (ghPat is null)
{
    Environment.GetEnvironmentVariable("GITHUB_TOKEN");
}

ReportCreator report = new(
    friendlyName: rc.ReportFriendlyName!,
    clientName: rc.ReportFilePrefix!,
    pat: ghPat);

if (args.Length == 2)
    await report.InitializePriorResultsFromJson(args[1]);

List<GitHubQuery> queries = qc.SelectMany(
    queryConfig => queryConfig.LabelGroups,
    (queryConfig, labels) => new GitHubQuery(
        queryConfig.RepoName,
        labels,
        queryConfig.Milestone,
        queryConfig.GloballyExcludedLabels,
        queryConfig.ExcludedMilestone, 
        queryConfig.Version)).ToList();

await report.QueryIssuesAsync(queries);

await report.WriteAsync(rc.ReportOutputPath!, rc.ReportFilePrefix!);

return 0;