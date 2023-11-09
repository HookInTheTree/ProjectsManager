using System.Text.RegularExpressions;
using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.Organization.ValueObjects;

public class PhoneNumber : ValueObject
{
    public string Value { get; private set; }

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