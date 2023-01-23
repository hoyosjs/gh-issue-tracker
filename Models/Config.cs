#nullable disable warnings
namespace gh_issue_tracker.Models;

public struct ReportConfig
{
    public string? ReportFriendlyName { get; set; }
    public string? ReportFilePrefix { get; set; }
    public string? ReportOutputPath { get; set; }
    public string? SecretFilePath { get; set; }
    public int? SlaHighlightsTimeInMonths { get; set; }
}

public class QueryConfig
{
    public string RepoName { get; set; }
    public string[]? GloballyExcludedLabels { get; set; }
    public string? ExcludedMilestone { get; set; }
    public string? Milestone { get; set; }
    public List<string[]?> LabelGroups { get; set; }
    public int Version { get; set; }
}