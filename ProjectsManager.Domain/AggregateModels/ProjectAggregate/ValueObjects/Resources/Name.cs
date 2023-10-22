namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Resources;

public class Name:Domain.ValueObject
{
    public string Value { get; }

    public Name(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException($"Resource name can't be null or whitespace!");
        Value = name;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}