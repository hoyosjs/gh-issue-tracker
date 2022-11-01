using Octokit;

namespace gh_issue_diagnostics.Config;

internal static class Config {
    public static readonly string ReportName = $"dn-diag-issue-tracker-{DateTime.UtcNow:yyyy-MM-dd-hh-mm}";
    public static readonly string ReportPath = @"E:\mocks\gh-issue-diagnostics\reports";
    public static readonly IReadOnlyList<RepoQueries> Repos = new List<RepoQueries>() {
        new RepoQueries (
            name: "dotnet/diagnostics",
            exclusions:  new SearchIssuesRequestExclusions {
                Labels = new List<string> {
                    "enhancement",
                    "feature-request",
                    "User Story",
                    "dotnet-monitor",
                },
                Milestone = "future"
            },
            labels: new List<string[]?> {
                null
            },
            version: 1
        ),
        new RepoQueries (
            name: "dotnet/runtime",
            exclusions:  new SearchIssuesRequestExclusions {
                Labels = new List<string> {
                    "enhancement",
                    "feature-request",
                    "linkable-framework",
                    "os-android",
                    "os-ios",
                    "os-tvos",
                    "arch-wasm"
                },
                Milestone = "future"
            },
            labels: new List<string[]?>{
                new[] { "area-Tracing-coreclr" },
                new[] { "area-System.Diagnostics" },
                new[] { "area-System.Diagnostics.Metric" },
                new[] { "area-System.Diagnostics.Tracing" },
                new[] { "area-Diagnostics-coreclr" }
            },
            version: 1
        )
    };
}