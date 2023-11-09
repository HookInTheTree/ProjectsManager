﻿using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.WorkItem;

public interface IWorkItemRepository : IRepository<WorkItem>
{
    //add some another logic that is specified for WorkItem
}