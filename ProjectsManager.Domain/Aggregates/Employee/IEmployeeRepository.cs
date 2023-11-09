using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.Employee;

public interface IEmployeeRepository : IRepository<Employee>
{
    // add some new methods that are specific for Employee
}