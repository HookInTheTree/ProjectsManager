using ProjectsManager.Domain.EmployeeAggregate.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class EmployeeEntity:BaseEntity
{
    internal FullName FullName { get; set; }
    internal PassportDetails PassportInfo { get; set; }
    internal Guid OrganizationId { get; set; }
    internal OrganizationEntity Organization { get; set; }
    internal ICollection<ProjectEntity> Projects { get; set; }
}