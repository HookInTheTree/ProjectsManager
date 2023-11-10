using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Organization;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectsManager.Application.Services.OrganizationManager.Models;

namespace ProjectsManager.Application.Services.OrganizationManager
{
    public interface IOrganizationManager
    {
        Task<OrganizationDTO> CreateOrganization(OrganizationCreationRequest request);
        Task<OrganizationDTO> UpdateOrganization(OrganizationUpdateRequest request);
        Task<OrganizationId> DestroyOrganization(OrganizationId organizationId);
        Task <OrganizationDTO> GetOrganization(OrganizationId organizationId);
        Task<List<OrganizationDTO>> GetOrganizations();
        OrganizationId AddEmployeeToOrganization(OrganizationId organizationId, Employee employee);
        OrganizationId RemoveEmployeeFromOrganization(OrganizationId organizationId, Employee employee);
        OrganizationId SetOrganizationOwner(OrganizationId organizationId, Employee employee);
        OrganizationId CreateOrganizationProject(OrganizationId organizationId, Project project);
        OrganizationId RemoveOrganizationProject(OrganizationId organizationId, Project project);
    }
}
