using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.OrganizationAggregate.ValueObjects;

public class Name:ValueObject
{
    public string Value { get; private set;}

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

    private Name()
    {

    }
}