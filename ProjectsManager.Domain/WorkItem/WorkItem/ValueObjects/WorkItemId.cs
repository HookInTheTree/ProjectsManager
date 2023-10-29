using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.WorkItemAggregate.ValueObjects;

public class WorkItemId:ValueObject
{
    protected override IEnumerable<object> GetEqualityComponents()
    {
        throw new NotImplementedException();
    }
}