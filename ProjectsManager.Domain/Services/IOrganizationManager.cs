using ProjectsManager.Domain.Aggregates.Organization;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectsManager.Domain.Services
{
    internal interface IOrganizationManager
    {
        ValueTask<Organization> CreateOrganization();
        ValueTask<Organization> UpdateOrganization(Organization organization);
        ValueTask<Organization> DestroyOrganization(OrganizationId organization);
        ValueTask<Organization> GetOrganization(OrganizationId organizationId);
        ValueTask<Organization> GetOrganizations();
        ValueTask<Organization> AddEmployeeToOrganization();
        ValueTask RemoveEmployeeFromOrganization();
        ValueTask SetOrganizationOwner();
        ValueTask CreateOrganizationProject();
        ValueTask RemoveOrganizationProject();
    }
}
