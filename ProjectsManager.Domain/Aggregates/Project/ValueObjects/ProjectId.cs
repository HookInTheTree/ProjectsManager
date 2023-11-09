using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.Project.ValueObjects;

public class ProjectId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private ProjectId(Guid value)
    {
        Value = value;
    }
    public static ProjectId CreateUnique()
    {
        return new ProjectId(Guid.NewGuid());
    }

    public static ProjectId Create(Guid value)
    {
        return new ProjectId(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        // ReSharper disable once HeapView.BoxingAllocation
        yield return Value;
    }
}