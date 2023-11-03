using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.Common.ValueObjects;
using ProjectsManager.Domain.EmployeeAggregate;
using ProjectsManager.Domain.Resource.ValueObjects;
using ProjectsManager.Domain.WorkItem.ValueObjects;

namespace ProjectsManager.Domain.WorkItem;

public sealed class WorkItem:AggregateRoot<WorkItemId, Guid>
{
    public Name Name { get; }
    public Description Description { get; private set; }
    public Duration Duration { get; private set; }
    public ProjectTaskStatus Status { get; private set; }
    
    public ProjectAggregate.ValueObjects.ProjectId ProjectId { get; private set; }
    public EmployeeAggregate.ValueObjects.EmployeeId OwnerId { get; private set; }
    private readonly List<WorkItemResource> _resourcesIds;
    public IReadOnlyCollection<WorkItemResource> ResourcesIds => _resourcesIds;

    public WorkItem(WorkItemId id, Name name, Description description, Duration duration)
    :base(id)
    {
        Name = name;
        Description = description;
        Duration = duration;
        _resourcesIds = new List<WorkItemResource>();
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
    
    public void AddResource(WorkItemResource resource) => _resourcesIds.Add(resource);
    public void RemoveResource(WorkItemResource resource) => _resourcesIds.Remove(resource);
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