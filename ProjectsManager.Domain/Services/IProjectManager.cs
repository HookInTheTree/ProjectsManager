using ProjectsManager.Domain.Aggregates.Project.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Domain.Services
{
    internal interface IProjectManager
    {
        ValueTask<Project> CreateProject();
        ValueTask<Project> UpdateProject(Project project);
        ValueTask<Project> DestroyProject(ProjectId id);
        ValueTask<Project> GetProject(ProjectId id);
        ValueTask<Project> GetProjects();
        ValueTask AddWorkItemToProject();
        ValueTask RemoveWorkItemFromProject();
        ValueTask AddEmployeeToProject();
        ValueTask RemoveEmployeeFromProject();

    }
}
