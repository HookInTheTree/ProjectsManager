
using Microsoft.EntityFrameworkCore;
using ProjectsManager.Domain.OrganizationAggregate;

namespace ProjectsManager.Infrastructure.Database.Repositories;

public class OrganizationRepository:IOrganizationRepository
{
    private readonly AppDbContext context;

    public OrganizationRepository(AppDbContext _context)
    {
        context = _context;
    }

    public async Task<List<Organization>> GetAll()
    {
        return await context.Organizations.ToListAsync();
    }

    public async Task<List<Organization>> GetByCondition(Func<Organization, bool> predicate)
    {
        return await context.Organizations.Where(x => predicate(x)).ToListAsync();
    }

    public Task<Organization> Update(Organization model)
    {
        context.Organizations.Update(model);
        return Task.FromResult<Organization>(model);
    }

    public async Task Insert(Organization model)
    {
        await context.Organizations.AddAsync(model);
    }

    public async Task<Organization> Remove(Organization model)
    {
        var modelInDb = await context.Organizations.FirstOrDefaultAsync(x => x.Id == model.Id);

        if (modelInDb is not null)
        {
            context.Organizations.Remove(modelInDb);
        }

        return model;
    }

    public async Task Save()
    {
        await context.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await context.DisposeAsync();
    }
}