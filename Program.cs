using System.Text.Json;
using gh_issue_tracker.Models;
using gh_issue_tracker.Report;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

if (args.Length > 3 || args.Length < 2
    || (args[0] == "-h" || args[0] == "--help")
    || (args[1] == "-h" || args[1] == "--help"))
{
    Console.WriteLine("Usage: gh-issue-tracker <verb> <path to config> <path to prior query json>");
    return 1;
}

ReportCreator.ReportGenerationType mode =  args[0] switch 
{
    "generate-full-report" => ReportCreator.ReportGenerationType.Full,
    "generate-comparison-report" => ReportCreator.ReportGenerationType.Comparative,
    "generate-all-reports" => ReportCreator.ReportGenerationType.All,
    _ => ReportCreator.ReportGenerationType.Invalid
};

if (mode == ReportCreator.ReportGenerationType.Invalid)
{
    Console.WriteLine("verb must be 'generate-full-report', 'generate-all-reports',  or 'generate-comparison-report'");
    return 1;
}

using FileStream configFs = File.OpenRead(args[1]);
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

ghPat ??= Environment.GetEnvironmentVariable("GITHUB_TOKEN");

IConfigurationRoot loggingConfiguration = new ConfigurationBuilder()
                .AddJsonFile("logging.json", optional: false, reloadOnChange: false)
                .Build();

using ILoggerFactory factory = LoggerFactory.Create(
    (builder) =>
    {
        builder
            .AddConfiguration(loggingConfiguration.GetSection("Logging"))
            .AddConsole();
    }
);

ReportCreator report = new(
    friendlyName: rc.ReportFriendlyName!,
    clientName: rc.ReportFilePrefix!,
    pat: ghPat,
    logger: factory.CreateLogger<ReportCreator>());

if (args.Length == 3
    && (mode == ReportCreator.ReportGenerationType.All || mode == ReportCreator.ReportGenerationType.Comparative))
{
    await report.InitializePriorResultsFromJson(args[2]);
}

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

await report.WriteAsync(rc.ReportOutputPath!,
                        rc.ReportFilePrefix!,
                        rc.SlaHighlightsTimeInMonths,
                        mode);
return 0;