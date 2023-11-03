using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.Common.ValueObjects;
using ProjectsManager.Domain.ResourceType.ValueObjects;

namespace ProjectsManager.Domain.ResourceType
{
    public class ResourceType : Entity<ResourceTypeId>
    {
        public Name Name { get; private set; }
        public Description Description { get; private set; }
        public ResourceType(ResourceTypeId id, Name name, Description description)
        : base(id)
        {
            Name = name;
            Description = description;
        }

        public void ChangeName(Name name)
        {
            Name = name;
        }

        public void ChangeDescription(Description description)
        {
            Description = description;
        }
    }
}
