using ProjectsManager.Infrastructure.Database.Common;
using ProjectsManager.Domain.Aggregates.Project;
using ProjectsManager.Domain.Aggregates.Project.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Projects;
public interface IProjectRepository : IRepository<Project, ProjectId>
{
    //add some another logic that is specified for Project
}