namespace ProjectsManager.Domain.AggregateModels.OrganizationAggregate.OrganizationValueObjects;

public class PhysicalAddress:ValueObject
{
    public string State { get; }
    public string City { get; }
    public string Street { get; }
    public string Building { get; }

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
}