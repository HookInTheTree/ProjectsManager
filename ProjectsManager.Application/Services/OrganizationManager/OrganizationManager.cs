using ProjectsManager.Application.Services.OrganizationManager.Models;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Application.Services.OrganizationManager
{
    public class OrganizationManager : IOrganizationManager
    {
        public OrganizationId AddEmployeeToOrganization(OrganizationId organizationId, Employee employee)
        {
            throw new NotImplementedException();
        }

        public OrganizationDTO CreateOrganization(OrganizationCreationRequest request)
        {
            throw new NotImplementedException();
        }

        public OrganizationId CreateOrganizationProject(OrganizationId organizationId, Project project)
        {
            throw new NotImplementedException();
        }

        public OrganizationId DestroyOrganization(OrganizationId organization)
        {
            throw new NotImplementedException();
        }

        public OrganizationDTO GetOrganization(OrganizationId organizationId)
        {
            throw new NotImplementedException();
        }

        public List<OrganizationDTO> GetOrganizations()
        {
            throw new NotImplementedException();
        }

        public OrganizationId RemoveEmployeeFromOrganization(OrganizationId organizationId, Employee employee)
        {
            throw new NotImplementedException();
        }

        public OrganizationId RemoveOrganizationProject(OrganizationId organizationId, Project project)
        {
            throw new NotImplementedException();
        }

        public OrganizationId SetOrganizationOwner(OrganizationId organizationId, Employee employee)
        {
            throw new NotImplementedException();
        }

        public OrganizationDTO UpdateOrganization(OrganizationUpdateRequest organization)
        {
            throw new NotImplementedException();
        }
    }
}
