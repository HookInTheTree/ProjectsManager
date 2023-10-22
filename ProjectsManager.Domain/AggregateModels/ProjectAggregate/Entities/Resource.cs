using ProjectsManager.Domain;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Resources;

namespace ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;

public class Resource:Entity
{
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Quantity Quantity { get; private set; }
    public ResourceType Type { get; private set; }
    public Cost Cost { get; private set; }

    public Resource(Name name, Description description, Quantity quantity, ResourceType type, Cost cost)
    {
        Name = name;
        Description = description;
        Quantity = quantity;
        Type = type;
        Cost = cost;
    }
    
    public void IncreaseCost(Cost cost)
    {
        Cost = new Cost(Cost.Value + cost.Value);
    }

    public void DecreaseCost(Cost cost)
    {
        Cost = new Cost(Cost.Value - cost.Value);
    }

    public void IncreaseQuantity(Quantity quantity)
    {
        Quantity = new Quantity(Quantity.Value + quantity.Value);
    }

    public void DecreaseQuantity(Quantity quantity)
    {
        Quantity = new Quantity(Quantity.Value - quantity.Value);
    }

    public void ChangeName(Name name)
    {
        Name = name;
    }
    public void ChangeDescription(Description description)
    {
        Description = description;
    }
    public void ChangeType(ResourceType type)
    {
        Type = type;
    }
}
