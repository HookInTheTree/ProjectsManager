using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.Resource.ValueObjects;

namespace ProjectsManager.Domain.ResourceType.ValueObjects;

public sealed class ResourceTypeId : AggregateRootId<Guid>
{
    private ResourceTypeId(Guid guid)
    {
        Value = Value;
    }

    public override Guid Value { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

    public static ResourceTypeId Create(Guid guid)
    {
        return new ResourceTypeId(guid);
    }

    public static ResourceTypeId CreateUnique()
    {
        return new ResourceTypeId(Guid.NewGuid());
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}