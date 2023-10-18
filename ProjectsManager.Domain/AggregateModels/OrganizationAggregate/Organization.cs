using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Domain.AggregateModels.OrganizationAggregate.ValueObjects;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;

namespace ProjectsManager.Domain.AggregateModels.OrganizationAggregate;
public class Organization : Entity
{
    public Name Name { get; private set; }
    public JuridicalAddress JuridicalAddress { get; private set; }
    public ContactInfo ContactInfo { get; private set; }
    public Employee Owner { get; private set; }
    private readonly List<Employee> _employees;
    public IReadOnlyCollection<Employee> Employees => _employees;

    private readonly List<Project> _projects;
    public IReadOnlyCollection<Project> Projects => _projects;
    public Organization(
        Name name,
        JuridicalAddress juridicalAddress,
        ContactInfo contactInfo,
        Employee owner
        )
    {
        Name = name;
        JuridicalAddress = juridicalAddress;
        ContactInfo = contactInfo;
        Owner = owner;
        _employees = new List<Employee>();
        _projects = new List<Project>();
    }

    public void RemoveProject(Project project)
    {
        var prjToRemove = _projects.FirstOrDefault(x => x.Id == project.Id);
        _projects.Remove(prjToRemove);
    }
    
    public void AddProject(Project project)
    {
        _projects.Add(project);
    }
    
    public void RemoveEmployee(Employee employee)
    {
        var empToRemove = _employees.FirstOrDefault(x => x.Id == employee.Id);
        _employees.Remove(empToRemove);
    }
    
    public void AddEmployee(Employee employee)
    {
        _employees.Add(employee);
    }
    
    public void SetOwner(Employee owner)
    {
        Owner = owner;
    }
}