using ProjectsManager.Domain.AggregateModels.ProjectAggregate;
using ProjectsManager.Domain.OrganizationAggregate;

namespace ProjectsManager.Domain.AggregateModels.EmployeeAggregate;

public class Employee:Entity
{
    public FullName FullName { get; }
    public PassportDetails PassportInfo { get; }
    public Organization Organization { get; }
    private readonly List<Project> _projects;
    public IReadOnlyCollection<Project> Projects => _projects;

    public Employee(FullName fullName, PassportDetails passportInfo, Organization organization)
    {
        FullName = fullName;
        PassportInfo = passportInfo;
        Organization = organization;
        _projects = new List<Project>();
    }
}