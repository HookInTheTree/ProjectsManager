namespace ProjectsManager.Domain.AggregateModels.OrganizationAggregate.OrganizationValueObjects;

public class Name:ValueObject
{
    public string Value { get; }

    public Name(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException($"Organization name can't be null or empty!");
        Value = name;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}