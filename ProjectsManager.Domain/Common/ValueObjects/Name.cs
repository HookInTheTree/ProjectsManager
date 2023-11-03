using ProjectsManager.Domain.Common;
namespace ProjectsManager.Domain.Common.ValueObjects;

public sealed class Name:ValueObject
{
    public string Value { get; }

    public Name(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException($"Name can't be null or whitespace!");

        if (name.Length < 50)
            throw new ArgumentException($"The length of the name can't be less than 50 characters!");
        
        Value = name;
    }

    private Name()
    {
        
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}