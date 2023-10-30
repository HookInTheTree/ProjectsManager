using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.EmployeeAggregate.ValueObjects;
using ProjectsManager.Domain.OrganizationAggregate.ValueObjects;
using ProjectsManager.Domain.ProjectAggregate.ValueObjects;
using Name = ProjectsManager.Domain.OrganizationAggregate.ValueObjects.Name;

namespace ProjectsManager.Domain.OrganizationAggregate;
public sealed class Organization : AggregateRoot<OrganizationId, Guid>
{
    public Name Name { get; private set; }
    public JuridicalAddress JuridicalAddress { get; private set; }
    public ContactInfo ContactInfo { get; private set; }
    
    //#TODO Rework logic of Owner.
    // Organization employee can't be the owner because when we want to create organization the employees doesn't exists.
    // So maybe organization Owner must to be just a user?
    // public EmployeeId OwnerId { get; private set; }

    private readonly List<EmployeeId> _employees;
    public IReadOnlyCollection<EmployeeId> Employees => _employees;

    private readonly List<ProjectId> _projects;
    public IReadOnlyCollection<ProjectId> Projects => _projects;
    public Organization(
        OrganizationId id,
        Name name,
        JuridicalAddress juridicalAddress,
        ContactInfo contactInfo
        ):base(id)
    {
        Name = name;
        JuridicalAddress = juridicalAddress;
        ContactInfo = contactInfo;
        // OwnerId = ownerId;
        _employees = new List<EmployeeId>();
        _projects = new List<ProjectId>();
    }

    public void RemoveProject(ProjectId projectId)
    {
        var prjToRemove = _projects.FirstOrDefault(x => x == projectId);
        _projects.Remove(prjToRemove);
    }
    
    public void AddProject(ProjectId projectId)
    {
        _projects.Add(projectId);
    }
    
    public void RemoveEmployee(EmployeeId employeeId)
    {
        var empToRemove = _employees.FirstOrDefault(x => x == employeeId);
        _employees.Remove(empToRemove);
    }
    
    public void AddEmployee(EmployeeId employeeId)
    {
        _employees.Add(employeeId);
    }
    
    // public void SetOwner(EmployeeId owner)
    // {
    //     OwnerId = owner;
    // }
}