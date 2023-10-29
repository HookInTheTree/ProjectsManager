using ProjectsManager.Domain.Common;
using ProjectsManager.Domain.ProjectAggregate.Entities;

namespace ProjectsManager.Domain.ProjectAggregate.Repositories;

public interface IProjectRepository:IRepository<Project>
{
    //add some another logic that is specified for Project
}