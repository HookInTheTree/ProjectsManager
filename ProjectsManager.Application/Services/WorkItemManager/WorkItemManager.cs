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
    public class WorkItemManager : IWorkItemManager
    {
        public WorkItemDTO ChangeWorkItemStatus(WorkItemId id, WorkItemStatus status)
        {
            throw new NotImplementedException();
        }

        public WorkItemDTO Create(WorkItemCreationRequest request)
        {
            throw new NotImplementedException();
        }

        public WorkItemDTO Destroy(WorkItemId id)
        {
            throw new NotImplementedException();
        }

        public WorkItemDTO GetWorkItem(WorkItemId id)
        {
            throw new NotImplementedException();
        }

        public List<WorkItemDTO> GetWorkItems()
        {
            throw new NotImplementedException();
        }

        public WorkItemId SetWorkItemOwner(WorkItemId id, Employee employee)
        {
            throw new NotImplementedException();
        }

        public WorkItemDTO Update(WorkItemUpdateRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
