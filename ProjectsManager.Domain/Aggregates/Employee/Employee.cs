using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;
using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project.ValueObjects;

namespace ProjectsManager.Domain.Aggregates.Employee;

public sealed class Employee : AggregateRoot<EmployeeId, Guid>
{
    public FullName FullName { get; }
    public PassportDetails PassportInfo { get; }
    public OrganizationId OrganizationId { get; }
    private readonly List<ProjectId> _projectIds;
    public IReadOnlyCollection<ProjectId> ProjectIds => _projectIds.AsReadOnly();
    private readonly List<WorkItemId> _workItemIds;
    public IReadOnlyCollection<WorkItemId> WorkItemIds => _workItemIds.AsReadOnly();

    public Employee(EmployeeId id, FullName fullName, PassportDetails passportInfo, OrganizationId organization)
    : base(id)
    {
        FullName = fullName;
        PassportInfo = passportInfo;
        OrganizationId = organization;
        _projectIds = new List<ProjectId>();
        _workItemIds = new List<WorkItemId>();
    }

    private Employee()
    {

    }
}