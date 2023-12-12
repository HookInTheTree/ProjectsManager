using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;
using ProjectsManager.Infrastructure.Database.Common;

namespace ProjectsManager.Infrastructure.Database.Employees;

public interface IEmployeeRepository : IRepository<Employee, EmployeeId>
{
    // add some new methods that are specific for Employee
}