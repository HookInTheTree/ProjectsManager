using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;
using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.Employee;

public interface IEmployeeRepository : IRepository<Employee, EmployeeId>
{
    // add some new methods that are specific for Employee
}