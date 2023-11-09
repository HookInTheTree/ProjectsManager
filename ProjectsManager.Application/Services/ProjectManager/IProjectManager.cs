using ProjectsManager.Domain.Aggregates.Project.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectsManager.Domain.Aggregates.WorkItem;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Application.Services.ProjectManager.Models;

namespace ProjectsManager.Application.Services.ProjectManager
{
    public interface IProjectManager
    {
        ProjectDTO CreateProject(ProjectCreationRequest request);
        ProjectDTO UpdateProject(ProjectUpdateRequest project);
        ProjectDTO DestroyProject(ProjectId id);
        ProjectDTO GetProject(ProjectId id);
        List<ProjectDTO> GetProjects();
        ProjectId AddWorkItemToProject(ProjectId projectId, WorkItem workItem);
        ProjectId RemoveWorkItemFromProject(ProjectId projectId, WorkItem workItem);
        ProjectId AddEmployeeToProject(ProjectId projectId, Employee employee);
        ProjectId RemoveEmployeeFromProject(ProjectId projectId, Employee employee);

    }
}
