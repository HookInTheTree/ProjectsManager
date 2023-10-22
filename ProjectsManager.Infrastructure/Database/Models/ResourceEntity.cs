using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Resources;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class ResourceEntity : BaseEntity
{
    public Name Name { get;  set; }
    public Description Description { get;  set; }
    public Quantity Quantity { get;  set; }
    public Guid TypeId { get; set; }
    public ResourceTypeEntity Type { get;  set; }
    public Cost Cost { get;  set; }
}