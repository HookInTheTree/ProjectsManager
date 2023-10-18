namespace ProjectsManager.Domain.AggregateModels.EmployeeAggregate.ValueObjects;

public class FullName:ValueObject
{
    public string Name { get; }
    public string MiddleName { get; }
    public string LastName { get; }

    public FullName(string name, string middleName, string lastName)
    {
        Name = name;
        MiddleName = middleName;
        LastName = lastName;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Name;
        yield return MiddleName;
        yield return LastName;
    }
}