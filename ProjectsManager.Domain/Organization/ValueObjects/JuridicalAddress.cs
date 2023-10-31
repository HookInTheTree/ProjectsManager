
using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.OrganizationAggregate.ValueObjects;

public class JuridicalAddress : ValueObject
{
    public PostalCode PostalСode { get; private set; }
    public PhysicalAddress PhysicalAddress { get; private set; }

    public JuridicalAddress(string postalCode, string state, string city, string street, string building)
    {
        PostalСode = new PostalCode(postalCode);
        PhysicalAddress = new PhysicalAddress(state, city, street, building);
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return PostalСode;
        yield return PhysicalAddress;
    }

    private JuridicalAddress()
    {

    }
}