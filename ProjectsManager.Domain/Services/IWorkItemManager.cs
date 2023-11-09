using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Domain.Services
{
    internal interface IWorkItemManager
    {
        ValueTask Create();
        ValueTask Update();
        ValueTask Destroy();
        ValueTask GetWorkItem();
        ValueTask GetWorkItems();
        ValueTask SetWorkItemOwner();
        ValueTask ExtendWorkItemDuration();
        ValueTask ChangeWorkItemStatus();
    }
}
