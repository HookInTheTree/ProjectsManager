namespace ProjectsManager.Domain.Models.ProjectAggregate.ProjectValueObjects;

public class Name:ValueObject
{
    public string Value { get; }

    public Name(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException($"Name value can't be null or whitespace!");
        Value = name;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}