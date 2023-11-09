using ProjectsManager.Application.Services.WorkItemManager.Models;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Application.Services.WorkItemManager
{
    internal interface IWorkItemManager
    {
        WorkItemDTO Create(WorkItemCreationRequest request);
        WorkItemDTO Update(WorkItemUpdateRequest request);
        WorkItemDTO Destroy(WorkItemId id);
        WorkItemDTO GetWorkItem(WorkItemId id);
        List<WorkItemDTO> GetWorkItems();
        WorkItemId SetWorkItemOwner(WorkItemId id, Employee employee);
        WorkItemDTO ChangeWorkItemStatus(WorkItemId id, WorkItemStatus status);
    }
}
