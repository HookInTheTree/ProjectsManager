using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.EmployeeAggregate.ValueObjects;
using ProjectsManager.Domain.ProjectAggregate.ValueObjects;
using ProjectsManager.Domain.OrganizationAggregate.ValueObjects;
using ProjectsManager.Domain.Common.ValueObjects;
using ProjectsManager.Domain.WorkItem.ValueObjects;

namespace ProjectsManager.Domain.ProjectAggregate.Entities;

public sealed class Project:AggregateRoot<ProjectId,Guid>
{
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Duration Duration { get; private set; }
    public OrganizationId OwnerId { get; private set; }
    private readonly List<EmployeeId> _memberIds;
    public IReadOnlyCollection<EmployeeId> MemberIds => _memberIds;
    private readonly List<WorkItemId> _workItemIds;
    public IReadOnlyCollection<WorkItemId> WorkItemIds => _workItemIds;

    public Project(ProjectId id, Name name, Description description, Duration duration, OrganizationId ownerId):base(id)
    {
        Name = name;
        Description = description;
        Duration = duration;
        OwnerId = ownerId;
        _memberIds = new List<EmployeeId>();
        _workItemIds = new List<WorkItemId>();
    }

    #region Project Mutations
    public void ChangeName(Name name)
    {
        Name = name;
    }

    public void ChangeDescription(Description description)
    {
        Description = description;
    }

    public void IncreaseDuration(TimeSpan timeToExtend)
    {
        Duration = new Duration(Duration.Start, Duration.End.Add(timeToExtend));
    }
    #endregion

    public void AddMember(EmployeeId employeeId)
    {
        if (!_memberIds.Any(x => x == employeeId))
            throw new ArgumentException(
                $"Employee with Id - {employeeId} isn't a employee of the organization (Id = {OwnerId} )");

        _memberIds.Add(employeeId);
    }

    public void RemoveMember(EmployeeId employeeId)
    {
        var membToRemove = MemberIds.FirstOrDefault(x => x == employeeId);
        _memberIds.Remove(membToRemove);
    }

    public void AddTask(WorkItemId itemId)
    {
        _workItemIds.Add(itemId);
    }

    public void RemoveTask(WorkItemId itemId)
    {
        _workItemIds.Remove(itemId);
    }

    private Project()
    {

    }
   
}