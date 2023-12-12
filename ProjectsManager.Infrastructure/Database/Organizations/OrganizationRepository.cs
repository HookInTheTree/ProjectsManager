
using Microsoft.EntityFrameworkCore;
using ProjectsManager.Domain.Aggregates.Organization;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Organizations;

public class OrganizationRepository : IOrganizationRepository
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
        return Task.FromResult(model);
    }

    public async Task Insert(Organization model)
    {
        await context.Organizations.AddAsync(model);
    }

    public async Task<Organization> Remove(OrganizationId id)
    {
        var modelInDb = await context.Organizations.FirstOrDefaultAsync(x => x.Id == id);

        if (modelInDb is not null)
        {
            context.Organizations.Remove(modelInDb);
        }

        return modelInDb;
    }

    public async Task Save()
    {
        await context.SaveChangesAsync();
    }

    public async ValueTask DisposeAsync()
    {
        await context.DisposeAsync();
    }

    public async Task<Organization> Create(Organization model)
    {
        await context.Organizations.AddAsync(model);
        return model;
    }

    public async Task<Organization> GetById(OrganizationId id)
    {
        return await context.Organizations.FirstAsync(x => x.Id == id);
    }
}