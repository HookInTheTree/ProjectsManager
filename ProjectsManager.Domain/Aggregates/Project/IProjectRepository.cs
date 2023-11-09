using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.ProjectAggregate.Entities;

namespace ProjectsManager.Domain.Aggregates.Project;

public interface IProjectRepository : IRepository<Project>
{
    //add some another logic that is specified for Project
}