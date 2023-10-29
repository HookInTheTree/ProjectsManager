using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.WorkItemAggregate.Resources.ValueObjects;

public class ResourceId:ValueObject
{
    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}