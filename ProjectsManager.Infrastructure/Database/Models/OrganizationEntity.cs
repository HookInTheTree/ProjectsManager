using ProjectsManager.Domain.EmployeeAggregate;
using ProjectsManager.Domain.OrganizationAggregate.ValueObjects;
using ProjectsManager.Domain.ProjectAggregate.Entities;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class OrganizationEntity: BaseEntity
{
    internal Name Name { get; set; }
    internal JuridicalAddress JuridicalAddress { get; set; }
    internal ContactInfo ContactInfo { get; set; }
    internal Guid OwnerId { get; set; }
    internal EmployeeEntity Owner { get; set; }
    internal ICollection<EmployeeEntity> Employees { get; set; }
    internal ICollection<ProjectEntity> Projects { get; set; }
}