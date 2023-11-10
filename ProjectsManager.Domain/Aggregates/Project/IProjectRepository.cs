using ProjectsManager.Domain.Aggregates.Project.ValueObjects;
using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;
using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.Project;

public interface IProjectRepository : IRepository<Project, ProjectId>
{
    //add some another logic that is specified for Project
}