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

record struct IssueReportResult(string Repository, int IssueId, string IssueName, string IssueUrl, IssueType Type, string OriginatorQuery);

enum IssueType
{
    New,
    Closed,
    MovedIn,
    MovedOut,
    Old,
}