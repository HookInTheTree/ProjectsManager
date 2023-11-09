using System.Text.RegularExpressions;
using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.Organization.ValueObjects;

public class Email : ValueObject
{
    public string Value { get; private set; }
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