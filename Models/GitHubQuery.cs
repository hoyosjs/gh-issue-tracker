using System.Text;

namespace gh_issue_tracker.Models;

internal class GitHubQuery
{
    internal GitHubQuery(
            string repoName,
            string[]? labels,
            string[]? excludedLabels,
            string? excludedMilestone,
            int version)
    {
        RepoName = repoName;
        Labels = labels;
        ExcludedLabels = excludedLabels;
        ExcludedMilestone = excludedMilestone;
        _version = version;

        if (Labels is not null)
        {
            Array.Sort(Labels);
        }
    }

    public string RepoName { get; init; }
    public string[]? Labels { get; init; }
    public string[]? ExcludedLabels { get; init; }
    public string? ExcludedMilestone { get; init; }

    // TODO: define migration and versioning of ID.
    private readonly int _version;
    const int _serializerVerison = 1;

    // TODO: this could get a bit long if many 
    //       it also doesn't consider exclusions
    internal string GetQueryId()
    {
        StringBuilder sb = new (50);
        sb.Append($"v{_version},{_serializerVerison}-{RepoName}");
        if (Labels is not null)
        {
            sb.Append('|');
            sb.AppendJoin("+", Labels);
        }
        return sb.ToString();
    }
}