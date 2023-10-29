using ProjectsManager.Domain.Organization;

namespace ProjectsManager.Infrastructure.Database.Repositories;

public class OrganizationRepository:IOrganizationRepository
{
    public Task<List<Organization>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Organization>> GetByCondition(Func<Organization, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<Organization> Update(Organization model)
    {
        throw new NotImplementedException();
    }

    public Task<Organization> Create(Organization model)
    {
        throw new NotImplementedException();
    }

    public Task<Organization> Remove(Organization model)
    {
        throw new NotImplementedException();
    }
}