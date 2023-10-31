
using ProjectsManager.Domain.WorkItemAggregate.ResourceType.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Models
{
    internal class ResourceTypeEntity : BaseEntity
    {
        internal Name Name { get; private set; }
        internal Description Description { get; private set; }
    }
}
