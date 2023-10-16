using System.Text.RegularExpressions;

namespace ProjectsManager.Domain.AggregateModels.OrganizationAggregate.OrganizationValueObjects;

public class Email:ValueObject
{
    public string Value { get; }
    public Email(string email)
    {
        var regex = @"^[\w\.-]+@[\w\.-]+\.\w+$";
        if (!Regex.IsMatch(email, regex))
            throw new ArgumentException("The email is invalid!");
        
        Value = email;
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}