using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.Resource.ValueObjects;
using ProjectsManager.Domain.WorkItem.ValueObjects;

namespace ProjectsManager.Domain.WorkItem
{
    public sealed class WorkItemResource:Entity<WorkItemResourceId>
    {
        public ResourceId ResourceId { get; private set; }
        public WorkItemId WorkItemId { get;private set; }
        public Quantity Quantity { get; private set; }
        public Cost Cost { get; private set; }

        public WorkItemResource(ResourceId resourceId, WorkItemId workItemId, Quantity quantity, Cost cost)
        {
            ResourceId = resourceId;
            WorkItemId = workItemId;
            Quantity = quantity;
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
    }
}
