using ProjectsManager.Domain.AggregateModels.ProjectAggregate.ProjectValueObjects;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.TaskAggregate.ResourceAggregate;

namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.TaskAggregate;

public class ProjectTask:Entity
{
    public TaskValueObjects.Name Name { get; }
    public Description Description { get; }
    public Duration Duration { get; private set; }
    private readonly List<Resource> _resources;
    public IReadOnlyCollection<Resource> Resources => _resources;

    public ProjectTask(TaskValueObjects.Name name, Description description, Duration duration)
    {
        Name = name;
        Description = description;
        Duration = duration;
        _resources = new List<Resource>();
    }

    public void AddResource(Resource resource) => _resources.Add(resource);
    public void RemoveResource(Resource resource) => _resources.Remove(resource);
    public void IncreaseDuration(TimeSpan timeToAdd)
    {
        Duration = new Duration(Duration.Start, Duration.End.Add(timeToAdd));
    }
}