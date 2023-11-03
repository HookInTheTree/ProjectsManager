using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.Common.ValueObjects;
using ProjectsManager.Domain.Resource.ValueObjects;
using ProjectsManager.Domain.ResourceType.ValueObjects;
using ProjectsManager.Domain.WorkItem.ValueObjects;
using System.Collections.Generic;

namespace ProjectsManager.Domain.Resource;

public class Resource : Entity<ResourceId>
{
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public ResourceTypeId Type { get; private set; }

    private List<WorkItemId> _workItemIds;
    public IReadOnlyCollection<WorkItemId> Owner => _workItemIds.AsReadOnly();

    private List<ResourceId> _resourceIds;
    public IReadOnlyCollection<ResourceId> Resources => _resourceIds.AsReadOnly();
    
    public Resource(ResourceId id, Name name, Description description, ResourceTypeId type)
    : base(id)
    {
        Name = name;
        Description = description;
        Type = type;
    }

    public void ChangeName(Name name)
    {
        Name = name;
    }
    public void ChangeDescription(Description description)
    {
        Description = description;
    }
    public void ChangeType(ResourceTypeId type)
    {
        Type = type;
    }
}