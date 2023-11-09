using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.Employee.ValueObjects;

public class EmployeeId : AggregateRootId<Guid>
{
    public override Guid Value { get; protected set; }

    private EmployeeId(Guid value)
    {
        Value = value;
    }
    public static EmployeeId CreateUnique()
    {
        return new EmployeeId(Guid.NewGuid());
    }

    public static EmployeeId Create(Guid value)
    {
        return new EmployeeId(value);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}