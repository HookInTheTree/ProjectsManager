using ProjectsManager.Domain.EmployeeAggregate.ValueObjects;
using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.OrganizationAggregate.ValueObjects;
using ProjectsManager.Domain.ProjectAggregate.ValueObjects;
using ProjectsManager.Domain.WorkItemAggregate.ValueObjects;

namespace ProjectsManager.Domain.EmployeeAggregate;

public sealed class Employee:AggregateRoot<EmployeeId>
{
    public FullName FullName { get; }
    public PassportDetails PassportInfo { get; }
    public OrganizationId OrganizationId { get; }
    private readonly List<ProjectId> _projectIds;
    public IReadOnlyCollection<ProjectId> ProjectIds => _projectIds;
    private readonly List<WorkItemId> _workItemIds;
    public IReadOnlyCollection<WorkItemId> WorkItemIds => _workItemIds;

    public Employee(EmployeeId id, FullName fullName, PassportDetails passportInfo, OrganizationId organization)
    :base(id)
    {
        FullName = fullName;
        PassportInfo = passportInfo;
        OrganizationId = organization;
        _projectIds = new List<ProjectId>();
        _workItemIds = new List<WorkItemId>();
    }
}