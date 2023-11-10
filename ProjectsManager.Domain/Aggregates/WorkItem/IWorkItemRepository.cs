using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;
using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.WorkItem;

public interface IWorkItemRepository : IRepository<WorkItem, WorkItemId>
{
    //add some another logic that is specified for WorkItem
}