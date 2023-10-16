using System.Text.RegularExpressions;

namespace ProjectsManager.Domain.AggregateModels.OrganizationAggregate.OrganizationValueObjects;

public class PhoneNumber:ValueObject
{
    public string Value { get; }
    
    public PhoneNumber(string phone)
    {
        var regex = @"^(\+7|8)(\d{10})$";
        if (!Regex.IsMatch(phone, regex))
            throw new ArgumentException("The phone isn't a valid Russian phonenumber!");
        
        Value = phone;
    }
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}