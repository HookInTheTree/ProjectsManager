namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Task;

public class ProjectTaskStatus:Enumeration
{
    public static ProjectTaskStatus Draft = new(1, nameof(Draft));
    public static ProjectTaskStatus Activated = new(1, nameof(Activated));
    public static ProjectTaskStatus Completed = new(1, nameof(Completed));
    public static ProjectTaskStatus Verified = new(1, nameof(Verified));
    public static ProjectTaskStatus Rejected = new(1, nameof(Rejected));
    public ProjectTaskStatus(int id, string name) : base(id, name)
    {
    }
}