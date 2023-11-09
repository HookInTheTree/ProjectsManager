using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;
using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project.ValueObjects;

namespace ProjectsManager.Domain.Aggregates.Employee;

public sealed class Employee : AggregateRoot<EmployeeId, Guid>
{
    public FullName FullName { get; private set; }
    public PassportDetails PassportInfo { get; private set; }
    public OrganizationId OrganizationId { get; private set; }
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

    public void ChangeName(FullName name)
    {
        FullName = name;
    }

    public void ChangePassportInfo(PassportDetails passportInfo)
    {
        PassportInfo = passportInfo;
    }

    public void AddToProject(ProjectId projectId)
    {
        if (_projectIds.Contains(projectId))
        {
            throw new ArgumentException($"The employee - {Id.Value} is already working on the project - {projectId.Value}");
        }

        _projectIds.Add(projectId);
    }

    public void RemoveFromProject(ProjectId projectId)
    {
        if (_projectIds.Contains(projectId))
        {
            _projectIds.Remove(projectId);
        }
    }

}