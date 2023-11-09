using ProjectsManager.Application.Services.ProjectManager.Models;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Project.ValueObjects;
using ProjectsManager.Domain.Aggregates.WorkItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Application.Services.ProjectManager
{
    internal class ProjectManager : IProjectManager
    {
        public ProjectId AddEmployeeToProject(ProjectId projectId, Employee employee)
        {
            throw new NotImplementedException();
        }

        public ProjectId AddWorkItemToProject(ProjectId projectId, WorkItem workItem)
        {
            throw new NotImplementedException();
        }

        public ProjectDTO CreateProject(ProjectCreationRequest request)
        {
            throw new NotImplementedException();
        }

        public ProjectDTO DestroyProject(ProjectId id)
        {
            throw new NotImplementedException();
        }

        public ProjectDTO GetProject(ProjectId id)
        {
            throw new NotImplementedException();
        }

        public List<ProjectDTO> GetProjects()
        {
            throw new NotImplementedException();
        }

        public ProjectId RemoveEmployeeFromProject(ProjectId projectId, Employee employee)
        {
            throw new NotImplementedException();
        }

        public ProjectId RemoveWorkItemFromProject(ProjectId projectId, WorkItem workItem)
        {
            throw new NotImplementedException();
        }

        public ProjectDTO UpdateProject(ProjectUpdateRequest project)
        {
            throw new NotImplementedException();
        }
    }
}
