using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project.ValueObjects;
using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;
using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.Common.ValueObjects;

namespace ProjectsManager.Domain.Aggregates.WorkItem;

public sealed class WorkItem : AggregateRoot<WorkItemId, Guid>
{
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Duration Duration { get; private set; }
    public WorkItemStatus Status { get; private set; }

    public ProjectId ProjectId { get; private set; }
    public EmployeeId OwnerId { get; private set; }

    public WorkItem(
        WorkItemId id,
        Name name,
        Description description,
        Duration duration,
        ProjectId projectId,
        EmployeeId employeeId)
    : base(id)
    {
        Name = name;
        Description = description;
        Duration = duration;
        ProjectId = projectId;
        OwnerId = employeeId;
        Status = WorkItemStatus.Draft;
    }

    public void ReturnToDraft()
    {
        if (Status == WorkItemStatus.Activated || Status == WorkItemStatus.Rejected)
        {
            Status = WorkItemStatus.Draft;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be returned to draft. The current status is invalid for this operation!");
        }
    }
    public void Activate()
    {
        if (Status == WorkItemStatus.Draft || Status == WorkItemStatus.Completed)
        {
            Status = WorkItemStatus.Activated;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be activated. The current status is invalid for this operation!");
        }
    }
    public void Complete()
    {
        if (Status == WorkItemStatus.Activated)
        {
            Status = WorkItemStatus.Completed;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be marked as completed. The current status is invalid for this operation!");
        }
    }
    public void Reject()
    {
        if (Status == WorkItemStatus.Completed)
        {
            Status = WorkItemStatus.Rejected;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be rejected. The current status is invalid for this operation!");
        }
    }
    public void Verify()
    {
        if (Status == WorkItemStatus.Completed)
        {
            Status = WorkItemStatus.Verified;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be verified. The current status is invalid for this operation!");
        }
    }

    public void IncreaseDuration(TimeSpan timeToAdd)
    {
        Duration = new Duration(Duration.Start, Duration.End.Add(timeToAdd));
    }
    public void DecreaseDuration(TimeSpan timeToDecrease)
    {
        Duration = new Duration(Duration.Start, Duration.End.Add(-1 * timeToDecrease));
    }

    public void ChangeName(Name name)
    {
        Name = name;
    }

    public void ChangeDescription(Description description)
    {
        Description = description;
    }

    public void SetOwner(EmployeeId employeeId)
    {
        OwnerId = employeeId;
    }

    private WorkItem() { }
}