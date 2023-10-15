using ProjectsManager.Domain.EmployeeAggregate;
using ProjectsManager.Domain.Models.ProjectAggregate.ProjectValueObjects;

namespace ProjectsManager.Domain.Models.ProjectAggregate;

public class Project:Entity
{
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Duration Duration { get; private set; }
    public Employee Owner { get; private set; }

    public Project(Name name, Description description, Duration duration, Employee owner)
    {
        Name = name;
        Description = description;
        Duration = duration;
        Owner = owner;
    }

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

    public void ChangeOwner(Employee owner)
    {
        Owner = owner;
    }
}