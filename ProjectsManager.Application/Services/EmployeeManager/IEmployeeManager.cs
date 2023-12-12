using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectsManager.Application.Services.EmployeeManager.Models;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project.ValueObjects;
using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;

namespace ProjectsManager.Application.Services.EmployeeManager
{
    public interface IEmployeeManager
    {
        EmployeeDTO CreateEmployee(EmployeeCreationRequest request);
        EmployeeDTO UpdateEmployee(EmployeeUpdateRequest organization);
        EmployeeId DestroyEmployee(EmployeeId id);
        EmployeeDTO GetEmployee(EmployeeId id);
        Task<List<EmployeeDTO>> GetEmployees(OrganizationId organizationId);
        EmployeeId AddEmployeeToOrganization(EmployeeId employeeId, OrganizationId organizationId);
        EmployeeId RemoveEmployeeFromOrganization(EmployeeId employeeId, OrganizationId organizationId);
        EmployeeId AddEmployeeToProject(EmployeeId employeeId, OrganizationId organizationId);
        EmployeeId RemoveEmployeeFromProject(EmployeeId employeeId, OrganizationId organizationId);
        EmployeeId AddWorkItemToEmployee(EmployeeId employeeId, WorkItemId workItemId);
        EmployeeId RemoveWorkItemFromEmployee(EmployeeId employeeId, WorkItemId workItemId);
    }
}
