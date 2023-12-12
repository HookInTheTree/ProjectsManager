using ProjectsManager.Infrastructure.Database.Common;
using ProjectsManager.Domain.Aggregates.WorkItem;
using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.WorkItems;

public interface IWorkItemRepository : IRepository<WorkItem, WorkItemId>
{
    //add some another logic that is specified for WorkItem
}