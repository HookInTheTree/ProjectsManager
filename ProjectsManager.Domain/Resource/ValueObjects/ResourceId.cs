using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Resource.ValueObjects;

public sealed class ResourceId : AggregateRootId<Guid>
{
    public override Guid Value { get ; protected set ; }

    private ResourceId(Guid guid)
    {
        Value = Value;
    }

    public static ResourceId Create(Guid guid)
    {
        return new ResourceId(guid);
    }

    public static ResourceId CreateUnique()
    {
        return new ResourceId(Guid.NewGuid());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}