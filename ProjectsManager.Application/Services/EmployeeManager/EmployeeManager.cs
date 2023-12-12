using ProjectsManager.Application.Services.EmployeeManager.Models;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Domain.Aggregates.WorkItem.ValueObjects;
using ProjectsManager.Infrastructure.Database.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Application.Services.EmployeeManager
{
    public class EmployeeManager : IEmployeeManager
    {
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeManager(IEmployeeRepository _employeeRepository)
        {
            employeeRepository = _employeeRepository;
        }

        public EmployeeId AddEmployeeToOrganization(EmployeeId employeeId, OrganizationId organizationId)
        {
            throw new NotImplementedException();
        }

        public EmployeeId AddEmployeeToProject(EmployeeId employeeId, OrganizationId organizationId)
        {
            throw new NotImplementedException();
        }

        public EmployeeId AddWorkItemToEmployee(EmployeeId employeeId, WorkItemId workItemId)
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO CreateEmployee(EmployeeCreationRequest request)
        {
            throw new NotImplementedException();
        }

        public EmployeeId DestroyEmployee(EmployeeId id)
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO GetEmployee(EmployeeId id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<EmployeeDTO>> GetEmployees(OrganizationId organizationId)
        {
            var employees = await employeeRepository.GetAll();
            return employees.Where(x => x.OrganizationId == organizationId)
                .Select(x => EmployeeDTO.FromDomainModel(x)).
                ToList();
        }

        public EmployeeId RemoveEmployeeFromOrganization(EmployeeId employeeId, OrganizationId organizationId)
        {
            throw new NotImplementedException();
        }

        public EmployeeId RemoveEmployeeFromProject(EmployeeId employeeId, OrganizationId organizationId)
        {
            throw new NotImplementedException();
        }

        public EmployeeId RemoveWorkItemFromEmployee(EmployeeId employeeId, WorkItemId workItemId)
        {
            throw new NotImplementedException();
        }

        public EmployeeDTO UpdateEmployee(EmployeeUpdateRequest organization)
        {
            throw new NotImplementedException();
        }
    }
}
