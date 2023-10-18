
namespace ProjectsManager.Domain.AggregateModels.OrganizationAggregate.ValueObjects;

public class JuridicalAddress:ValueObject
{
    public PostalCode PostalСode { get; }
    public PhysicalAddress PhysicalAddress{ get; }

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