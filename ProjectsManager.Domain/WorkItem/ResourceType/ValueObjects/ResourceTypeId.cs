using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.WorkItemAggregate.ResourceType.ValueObjects;

public class ResourceTypeId:ValueObject
{
    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}