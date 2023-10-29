using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.EmployeeAggregate;

public interface IEmployeeRepository:IRepository<Employee>
{
    // add some new methods that are specific for Employee
}