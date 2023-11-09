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
    public ProjectTaskStatus Status { get; private set; }

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
        Status = ProjectTaskStatus.Draft;
    }

    public void ReturnToDraft()
    {
        if (Status == ProjectTaskStatus.Activated || Status == ProjectTaskStatus.Rejected)
        {
            Status = ProjectTaskStatus.Draft;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be returned to draft. The current status is invalid for this operation!");
        }
    }
    public void Activate()
    {
        if (Status == ProjectTaskStatus.Draft || Status == ProjectTaskStatus.Completed)
        {
            Status = ProjectTaskStatus.Activated;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be activated. The current status is invalid for this operation!");
        }
    }
    public void Complete()
    {
        if (Status == ProjectTaskStatus.Activated)
        {
            Status = ProjectTaskStatus.Completed;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be marked as completed. The current status is invalid for this operation!");
        }
    }
    public void Reject()
    {
        if (Status == ProjectTaskStatus.Completed)
        {
            Status = ProjectTaskStatus.Rejected;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be rejected. The current status is invalid for this operation!");
        }
    }
    public void Verify()
    {
        if (Status == ProjectTaskStatus.Completed)
        {
            Status = ProjectTaskStatus.Verified;
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

    public void ChangeDescription(Description description)
    {
        Description = description;
    }

    //#TODO Think about DDD thrilemma
    //public void SetOwner(EmployeeAggregate.ValueObjects.EmployeeId employee)
    //{
    //    if (!ProjectId.MemberIds.Any(x => x.Equals(employee)))
    //    {
    //        throw new ArgumentException(
    //            $"The employee with Id - {employee.Id} is not working on the project (Id: {ProjectId}! He cannot process the task (Id:{Id}!");
    //    }
    //}

    private WorkItem() { }
}