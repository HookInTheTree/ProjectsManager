using ProjectsManager.Domain.Common;
namespace ProjectsManager.Domain.OrganizationAggregate.ValueObjects;

public class ContactInfo:ValueObject
{
    public string WebSite { get; private set; }
    public string Email { get; private set; }
    public string PhoneNumber { get; private set; }

    public ContactInfo(string webSite, string email, string phoneNumber)
    {
        WebSite = webSite;
        Email = new Email(email).Value;
        PhoneNumber = new PhoneNumber(phoneNumber).Value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return WebSite;
        yield return Email;
        yield return PhoneNumber;
    }

    private ContactInfo()
    {

    }
}