using Microsoft.EntityFrameworkCore;
using ProjectsManager.Domain.EmployeeAggregate;

namespace ProjectsManager.Infrastructure.Database.Repositories;

public class EmployeeRepository:IEmployeeRepository
{
    private readonly AppDbContext context;
    internal EmployeeRepository(AppDbContext _context)
    {
        context = _context;
    }
    
    public Task<List<Employee>> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task<List<Employee>> GetByCondition(Func<Employee, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> Update(Employee model)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> Create(Employee model)
    {
        throw new NotImplementedException();
    }

    public Task<Employee> Remove(Employee model)
    {
        throw new NotImplementedException();
    }
}