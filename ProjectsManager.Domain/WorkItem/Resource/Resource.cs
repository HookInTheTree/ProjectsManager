using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.WorkItemAggregate.Resources.ValueObjects;
using ProjectsManager.Domain.WorkItemAggregate;

namespace ProjectsManager.Domain.WorkItemAggregate;

public class Resource:Entity<ResourceId>
{
    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Quantity Quantity { get; private set; }
    public Entities.ResourceType Type { get; private set; }
    public Cost Cost { get; private set; }
    public WorkItem Owner { get; set; }
    public Resource(ResourceId id,Name name, Description description, Quantity quantity, Entities.ResourceType type, Cost cost)
    :base(id)
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
    public void ChangeType(Entities.ResourceType type)
    {
        Type = type;
    }
}