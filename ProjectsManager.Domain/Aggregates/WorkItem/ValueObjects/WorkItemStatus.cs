using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;

public class WorkItemStatus : Enumeration
{
    public static WorkItemStatus Draft = new(1, nameof(Draft));
    public static WorkItemStatus Activated = new(1, nameof(Activated));
    public static WorkItemStatus Completed = new(1, nameof(Completed));
    public static WorkItemStatus Verified = new(1, nameof(Verified));
    public static WorkItemStatus Rejected = new(1, nameof(Rejected));
    public WorkItemStatus(int id, string name) : base(id, name)
    {
    }
}