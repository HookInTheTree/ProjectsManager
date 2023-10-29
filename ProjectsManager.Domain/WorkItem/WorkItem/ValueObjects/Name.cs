using ProjectsManager.Domain.Common;
namespace ProjectsManager.Domain.WorkItemAggregate.ValueObjects;

public class Name:ValueObject
{
    public string Value { get; }

    public Name(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException($"Task name can't be null or whitespace!");

        if (name.Length < 50)
            throw new ArgumentException($"The length of the task name must not be less than 50 characters!");
        
        Value = name;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}