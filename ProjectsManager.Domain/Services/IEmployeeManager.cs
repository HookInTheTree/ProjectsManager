using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;

namespace ProjectsManager.Domain.Services
{
    internal interface IEmployeeManager
    {
        ValueTask<Employee> CreateEmployee();
        ValueTask<Employee> UpdateEmployee(Employee organization);
        ValueTask<Employee> DestroyEmployee(EmployeeId id);
        ValueTask<Employee> GetEmployee(EmployeeId id);
        ValueTask<Employee> GetEmployees();
        ValueTask<Employee> AddEmployeeToOrganization();
        ValueTask RemoveEmployeeFromOrganization();
        ValueTask AddEmployeeToProject();
        ValueTask RemoveEmployeeFromProject();
        ValueTask AddWorkItemToEmployee();
        ValueTask RemoveWorkItemFromEmployee();
    }
}
