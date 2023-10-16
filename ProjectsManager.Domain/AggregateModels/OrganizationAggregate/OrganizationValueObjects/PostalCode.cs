namespace ProjectsManager.Domain.AggregateModels.OrganizationAggregate.OrganizationValueObjects;

public class PostalCode:ValueObject
{
    public string Value { get; }

    public PostalCode(string code)
    {
        if (string.IsNullOrEmpty(code))
            throw new ArgumentException("The postal code can't be null or empty!");
        if (code.Length != 6)
            throw new ArgumentException("The postal code must include 6 characters!");
        if (!code.All(x => char.IsDigit(x)))
            throw new ArgumentException("The postal code can include only digits!");

        Value = code;
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}