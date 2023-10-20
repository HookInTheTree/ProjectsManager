using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Task;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class TaskEntity
{
    internal Name Name { get; }
    internal Description Description { get; set; }
    internal Duration Duration { get; set; }
    internal ProjectTaskStatus Status { get; set; }
    internal Guid ProjectId { get; set; }
    internal Project Project { get; set; }
    internal Guid OwnerId { get; set; }
    internal Employee Owner { get; set; }
    internal ICollection<Resource> Resources { get; set; }
}