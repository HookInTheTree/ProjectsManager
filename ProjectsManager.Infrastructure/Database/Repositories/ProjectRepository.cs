using ProjectsManager.Domain;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;
using ProjectsManager.Domain.ProjectAggregate.Repositories;

namespace ProjectsManager.Infrastructure.Database.Repositories;

public class ProjectRepository:IProjectRepository
{
    public Task<List<Project>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Project>> GetByCondition(Func<Project, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<Project> Update(Project model)
    {
        throw new NotImplementedException();
    }

    public Task<Project> Create(Project model)
    {
        throw new NotImplementedException();
    }

    public Task<Project> Remove(Project model)
    {
        throw new NotImplementedException();
    }
}