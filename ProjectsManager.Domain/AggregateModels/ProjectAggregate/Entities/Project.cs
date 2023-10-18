using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Project;
using ProjectsManager.Domain.AggregateModels.OrganizationAggregate;

namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;

public class Project:Entity
{
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Duration Duration { get; private set; }
    public Organization Owner { get; private set; }
    private readonly List<Employee> _members;
    public IReadOnlyCollection<Employee> Members => _members;
    private readonly List<ProjectTask> _tasks;
    public IReadOnlyCollection<ProjectTask> Tasks => _tasks;

    public Project(Name name, Description description, Duration duration, Organization owner)
    {
        Name = name;
        Description = description;
        Duration = duration;
        Owner = owner;
        _members = new List<Employee>();
        _tasks = new List<ProjectTask>();
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

    public void AddMember(Employee employee)
    {
        if (!Owner.Employees.Any(x => x.Id == employee.Id))
            throw new ArgumentException(
                $"Employee with Id - {employee.Id} isn't a employee of the organization (Id = {Owner.Id} )");
        
        _members.Add(employee);
    }

    public void RemoveMember(Employee employee)
    {
        var membToRemove = Members.FirstOrDefault(x => x.Id == employee.Id);
        _members.Remove(membToRemove);
    }

    public void AddTask(ProjectTask task)
    {
        _tasks.Add(task);
    }

    public void RemoveTask(ProjectTask task)
    {
        _tasks.Remove(task);
    }
   
}