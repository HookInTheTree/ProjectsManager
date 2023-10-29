using ProjectsManager.Domain.ProjectAggregate.Entities;
using ProjectsManager.Domain.ProjectAggregate.Repositories;

namespace ProjectsManager.Infrastructure.Database.Repositories;

public class ResourceRepository:IResourceRepository
{
    public Task<List<Resource>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Resource>> GetByCondition(Func<Resource, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<Resource> Update(Resource model)
    {
        throw new NotImplementedException();
    }

    public Task<Resource> Create(Resource model)
    {
        throw new NotImplementedException();
    }

    public Task<Resource> Remove(Resource model)
    {
        throw new NotImplementedException();
    }
}