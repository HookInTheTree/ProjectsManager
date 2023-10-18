using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Task;

namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;

public class ProjectTask:Entity
{
    public Name Name { get; }
    public Description Description { get; private set; }
    public Duration Duration { get; private set; }
    public ProjectTaskStatus Status { get; private set; }
    
    public Project Project { get; private set; }
    public Employee Owner { get; private set; }
    private readonly List<Resource> _resources;
    public IReadOnlyCollection<Resource> Resources => _resources;

    public ProjectTask(Name name, Description description, Duration duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
        _resources = new List<Resource>();
    }

    public void ReturnToDraft()
    {
        if (Status == ProjectTaskStatus.Activated || Status == ProjectTaskStatus.Rejected)
        {
            Status = ProjectTaskStatus.Draft;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be returned to draft. The current status is invalid for this operation!");
        }
    }
    public void Activate()
    {
        if (Status == ProjectTaskStatus.Draft || Status == ProjectTaskStatus.Completed)
        {
            Status = ProjectTaskStatus.Activated;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be activated. The current status is invalid for this operation!");
        }
    }
    public void Complete()
    {
        if (Status == ProjectTaskStatus.Activated)
        {
            Status = ProjectTaskStatus.Completed;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be marked as completed. The current status is invalid for this operation!");
        }
    }
    public void Reject()
    {
        if (Status == ProjectTaskStatus.Completed)
        {
            Status = ProjectTaskStatus.Rejected;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be rejected. The current status is invalid for this operation!");
        }
    }
    public void Verify()
    {
        if (Status == ProjectTaskStatus.Completed)
        {
            Status = ProjectTaskStatus.Verified;
        }
        else
        {
            throw new InvalidOperationException(
                "The task can't be verified. The current status is invalid for this operation!");
        }
    }
    
    public void AddResource(Resource resource) => _resources.Add(resource);
    public void RemoveResource(Resource resource) => _resources.Remove(resource);
    public void IncreaseDuration(TimeSpan timeToAdd)
    {
        Duration = new Duration(Duration.Start, Duration.End.Add(timeToAdd));
    }

    public void ChangeDescription(Description description)
    {
        Description = description;
    }
    public void SetOwner(Employee employee)
    {
        if (!Project.Members.Any(x => x.Equals(employee)))
        {
            throw new ArgumentException(
                $"The employee with Id - {employee.Id} is not working on the project (Id: {Project.Id}! He cannot process the task (Id:{Id}!");
        }
    }

}