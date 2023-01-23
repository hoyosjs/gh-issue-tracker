namespace gh_issue_tracker.Models;

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

internal class IssueReportResult
{
    internal string Repository { get; }
    internal int IssueId { get; }
    internal string IssueName { get; }
    internal string IssueUrl  { get; }
    internal IssueType Type { get; set; }
    internal string OriginatorQuery  { get; }
    internal DateTimeOffset CreationTime  { get; }

    public IssueReportResult(string repository,
                             int issueId,
                             string issueName,
                             string issueUrl,
                             IssueType type,
                             string originatorQuery,
                             DateTimeOffset creationTime)
    {
        Repository = repository;
        IssueId = issueId;
        IssueName = issueName;
        IssueUrl = issueUrl;
        Type = type;
        OriginatorQuery = originatorQuery;
        CreationTime = creationTime;
    }
}

enum IssueType
{
    New,
    Closed,
    MovedIn,
    MovedOut,
    Old,
}