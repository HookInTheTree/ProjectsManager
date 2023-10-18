namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Project;

public class Name:Domain.ValueObject
{
    public string Value { get; }

    public Name(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException($"Project name can't be null or whitespace!");
        Value = name;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}