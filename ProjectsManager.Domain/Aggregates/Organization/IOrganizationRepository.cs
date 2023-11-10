using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Domain.Common;

namespace ProjectsManager.Domain.Aggregates.Organization;

public interface IOrganizationRepository : IRepository<Organization, OrganizationId>
{
    //add some another logic that is specified for Organization
}