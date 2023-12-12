using Microsoft.EntityFrameworkCore;
using ProjectsManager.Domain.Aggregates.Project;
using ProjectsManager.Domain.Aggregates.Project.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Projects;

public class ProjectRepository : IProjectRepository
{
    private readonly AppDbContext context;

    public ProjectRepository(AppDbContext _context)
    {
        context = _context;
    }

    public async Task<List<Project>> GetAll()
    {
        return await context.Projects.ToListAsync();
    }

    public async Task<List<Project>> GetByCondition(Func<Project, bool> predicate)
    {
        return await context.Projects.Where(x => predicate(x)).ToListAsync();
    }

    public Task<Project> Update(Project model)
    {
        context.Projects.Update(model);
        return Task.FromResult(model);
    }

    public async Task Insert(Project model)
    {
        await context.Projects.AddAsync(model);
    }

    public async Task<Project> Remove(ProjectId id)
    {
        var modelInDb = await context.Projects.FirstOrDefaultAsync(x => x.Id == id);

        if (modelInDb is not null)
        {
            context.Projects.Remove(modelInDb);
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

    public async Task<Project> Create(Project model)
    {
        await context.Projects.AddAsync(model);
        return model;
    }

    public async Task<Project> GetById(ProjectId id)
    {
        return await context.Projects.FirstAsync(x => x.Id == id);
    }
}