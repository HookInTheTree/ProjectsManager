using ProjectsManager.Domain.WorkItemAggregate.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class WorkItemEntity : BaseEntity
{
    internal Name Name { get; }
    internal Description Description { get; set; }
    internal Duration Duration { get; set; }
    internal ProjectTaskStatus Status { get; set; }
    internal Guid ProjectId { get; set; }
    internal ProjectEntity Project { get; set; }
    internal Guid OwnerId { get; set; }
    internal EmployeeEntity Owner { get; set; }
    internal ICollection<ResourceEntity> Resources { get; set; }
}