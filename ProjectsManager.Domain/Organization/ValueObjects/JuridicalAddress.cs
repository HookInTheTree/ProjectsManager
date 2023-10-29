
using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.OrganizationAggregate.ValueObjects;

public class JuridicalAddress:ValueObject
{
    public PostalCode PostalСode { get; private set;}
    public PhysicalAddress PhysicalAddress{ get;private set; }

    public JuridicalAddress(PostalCode postalCode, PhysicalAddress address)
    {
        PostalСode = postalCode;
        PhysicalAddress = address;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return PostalСode;
        yield return PhysicalAddress;
    }
}