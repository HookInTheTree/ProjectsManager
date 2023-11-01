using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.ProjectAggregate.ValueObjects;

public class Name:ValueObject
{
    public string Value { get; }

    private Name() { }

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