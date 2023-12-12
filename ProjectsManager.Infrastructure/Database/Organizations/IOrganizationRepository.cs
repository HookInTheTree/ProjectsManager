using ProjectsManager.Infrastructure.Database.Common;
using ProjectsManager.Domain.Aggregates.Organization;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Organizations;

public interface IOrganizationRepository : IRepository<Organization, OrganizationId>
{
    //add some another logic that is specified for Organization
}