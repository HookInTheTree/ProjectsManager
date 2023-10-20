using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;

namespace ProjectsManager.Domain.ProjectAggregate.Repositories;

public interface IProjectRepository:IRepository<Project>
{
    //add some another logic that is specified for Project
}