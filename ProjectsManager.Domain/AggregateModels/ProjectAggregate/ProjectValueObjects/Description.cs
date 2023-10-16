namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.ProjectValueObjects;

public class Description:ValueObject
{
    public string Value { get; }

    public Description(string description)
    {
        if (string.IsNullOrEmpty(description))
            throw new ArgumentException($"Description value can't be null or whitespace!");
        else if (description.Length < 10)
            throw new ArgumentException("Description length can't be less than 10 charasters");
        
        Value = description;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}