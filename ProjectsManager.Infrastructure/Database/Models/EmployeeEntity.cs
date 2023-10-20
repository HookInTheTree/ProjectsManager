using ProjectsManager.Domain.AggregateModels.EmployeeAggregate.ValueObjects;
using ProjectsManager.Domain.AggregateModels.OrganizationAggregate;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class EmployeeEntity
{
    internal FullName FullName { get; set; }
    internal PassportDetails PassportInfo { get; set; }
    internal Guid OrganizationId { get; set; }
    internal OrganizationEntity Organization { get; set; }
    internal ICollection<ProjectEntity> Projects { get; set; }
}