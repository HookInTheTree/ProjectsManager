using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.ProjectAggregate.ValueObjects;

public class Description:ValueObject
{
    public string Value { get; }

    public Description(string description)
    {
        if (string.IsNullOrEmpty(description))
            throw new ArgumentException($"Project description value can't be null or whitespace!");
        else if (description.Length < 10)
            throw new ArgumentException("Project description length can't be less than 10 charasters");
        
        Value = description;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}