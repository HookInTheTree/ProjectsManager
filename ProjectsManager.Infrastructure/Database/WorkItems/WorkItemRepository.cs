using Microsoft.EntityFrameworkCore;
using ProjectsManager.Domain.Aggregates.WorkItem;
using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.WorkItems
{
    public class WorkItemRepository : IWorkItemRepository
    {
        private readonly AppDbContext context;

        public WorkItemRepository(AppDbContext _context)
        {
            context = _context;
        }

        public async Task<List<WorkItem>> GetAll()
        {
            return await context.WorkItems.ToListAsync();
        }

        public async Task<List<WorkItem>> GetByCondition(Func<WorkItem, bool> predicate)
        {
            return await context.WorkItems.Where(x => predicate(x)).ToListAsync();
        }

        public Task<WorkItem> Update(WorkItem model)
        {
            context.WorkItems.Update(model);
            return Task.FromResult(model);
        }

        public async Task Insert(WorkItem model)
        {
            await context.WorkItems.AddAsync(model);
        }

        public async Task<WorkItem> Remove(WorkItemId id)
        {
            var modelInDb = await context.WorkItems.FirstOrDefaultAsync(x => x.Id == id);

            if (modelInDb is not null)
            {
                context.WorkItems.Remove(modelInDb);
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

        public async Task<WorkItem> Create(WorkItem model)
        {
            await context.WorkItems.AddAsync(model);
            return model;
        }

        public async Task<WorkItem> GetById(WorkItemId id)
        {
            return await context.WorkItems.FirstAsync(x => x.Id == id);
        }
    }
}
