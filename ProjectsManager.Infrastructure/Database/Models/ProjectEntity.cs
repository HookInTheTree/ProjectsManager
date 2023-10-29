using ProjectsManager.Domain.EmployeeAggregate;
using ProjectsManager.Domain.Organization;
using ProjectsManager.Domain.ProjectAggregate.Entities;
using ProjectsManager.Domain.ProjectAggregate.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class ProjectEntity: BaseEntity
{
    internal Name Name { get; set; }
    internal Description Description { get; set; }
    internal Duration Duration { get; set; }
    internal Guid OwnerId { get; set; }
    internal OrganizationEntity Owner { get; set; }
    internal ICollection<EmployeeEntity> Members { get; set; }
    internal ICollection<WorkItemEntity> Tasks { get; set; }
}