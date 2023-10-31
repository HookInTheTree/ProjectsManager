using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.OrganizationAggregate.ValueObjects;

public class PhysicalAddress:ValueObject
{
    public string State { get; private set; }
    public string City { get; private set;}
    public string Street { get; private set;}
    public string Building { get; private set;}

    public PhysicalAddress(string state, string city, string street, string building)
    {
        State = state;
        City = city;
        Street = street;
        Building = building;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return State;
        yield return City;
        yield return Street;
        yield return Building;
    }

    private PhysicalAddress() { }
}