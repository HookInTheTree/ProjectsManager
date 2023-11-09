using Microsoft.EntityFrameworkCore;
using ProjectsManager.Domain.Aggregates.Employee;

namespace ProjectsManager.Infrastructure.Database.Repositories;

public class EmployeeRepository:IEmployeeRepository
{
    private readonly AppDbContext context;
    public EmployeeRepository(AppDbContext _context)
    {
        context = _context;
    }
    
    public async Task<List<Employee>> GetAll()
    {
        return await context.Employees.ToListAsync();
    }

    public async Task<List<Employee>> GetByCondition(Func<Employee, bool> predicate)
    {
        return await context.Employees.Where(x => predicate(x)).ToListAsync();
    }

    public Task<Employee> Update(Employee model)
    {
        context.Employees.Update(model);
        return Task.FromResult(model);
    }

    public async Task Insert(Employee model)
    {
        await context.Employees.AddAsync(model);
    }

    public async Task<Employee> Remove(Employee model)
    {
        var modelInDb = await context.Employees.FirstOrDefaultAsync(x => x.Id == model.Id);

        if (modelInDb is not null)
        {
            context.Employees.Remove(modelInDb);
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