using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.WorkItem.ValueObjects;

public class WorkItemId:AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private WorkItemId(Guid value)
    {
        Value = value;
    }
    public static WorkItemId CreateUnique()
    {
        return new WorkItemId(Guid.NewGuid());
    }

    public static WorkItemId Create(Guid value)
    {
        return new WorkItemId(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        // ReSharper disable once HeapView.BoxingAllocation
        yield return Value;
    }
}