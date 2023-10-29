using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.WorkItemAggregate.Resources.ValueObjects;

public class Name:ValueObject
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