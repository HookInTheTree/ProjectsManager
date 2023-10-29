using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.OrganizationAggregate.ValueObjects;

public class OrganizationId:AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private OrganizationId(Guid value)
    {
        Value = value;
    }
    public static OrganizationId CreateUnique()
    {
        return new OrganizationId(Guid.NewGuid());
    }

    public static OrganizationId Create(Guid value)
    {
        return new OrganizationId(value);
    }
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        // ReSharper disable once HeapView.BoxingAllocation
        yield return Value;
    }

}