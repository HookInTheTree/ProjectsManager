using ProjectsManager.Domain.Common;
namespace ProjectsManager.Domain.OrganizationAggregate.ValueObjects;

public class ContactInfo:ValueObject
{
    public string WebSite { get; }
    public Email Email { get; }
    public PhoneNumber PhoneNumber { get; }

    public ContactInfo(string webSite, Email email, PhoneNumber phoneNumber)
    {
        WebSite = webSite;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return WebSite;
        yield return Email;
        yield return PhoneNumber;
    }
}