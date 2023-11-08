using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Common.ValueObjects;

public sealed class Description:ValueObject
{
    public string Value { get; private set; }

    public Description(string description)
    {
        if (string.IsNullOrEmpty(description))
            throw new ArgumentException($"Description value can't be null or whitespace!");
        else if (description.Length < 10)
            throw new ArgumentException("Description length can't be less than 10 charasters");
        
        Value = description;
    }

    private Description() { }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}