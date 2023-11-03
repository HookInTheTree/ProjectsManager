using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.Common.ValueObjects;
using ProjectsManager.Domain.EmployeeAggregate.ValueObjects;
using ProjectsManager.Domain.OrganizationAggregate.ValueObjects;
using ProjectsManager.Domain.ProjectAggregate.ValueObjects;

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

    private readonly List<EmployeeId> _employeeIds;
    public IReadOnlyCollection<EmployeeId> EmployeeIds => _employeeIds;

    private readonly List<ProjectId> _projectIds;
    public IReadOnlyCollection<ProjectId> ProjectIds => _projectIds;
    
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
        _employeeIds = new List<EmployeeId>();
        _projectIds = new List<ProjectId>();
    }

    private Organization()
    {
    
    }


    public void RemoveProject(ProjectId projectId)
    {
        var prjToRemove = _projectIds.FirstOrDefault(x => x == projectId);
        _projectIds.Remove(prjToRemove);
    }
    
    public void AddProject(ProjectId projectId)
    {
        _projectIds.Add(projectId);
    }
    
    public void RemoveEmployee(EmployeeId employeeId)
    {
        var empToRemove = _employeeIds.FirstOrDefault(x => x == employeeId);
        _employeeIds.Remove(empToRemove);
    }
    
    public void AddEmployee(EmployeeId employeeId)
    {
        _employeeIds.Add(employeeId);
    }
    
    // public void SetOwner(EmployeeId owner)
    // {
    //     OwnerId = owner;
    // }
}