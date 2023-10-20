using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Domain.AggregateModels.OrganizationAggregate.ValueObjects;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class OrganizationEntity
{
    internal Name Name { get; set; }
    internal JuridicalAddress JuridicalAddress { get; set; }
    internal ContactInfo ContactInfo { get; set; }
    internal Guid OwnerId { get; set; }
    internal Employee Owner { get; set; }
    internal ICollection<Employee> Employees { get; set; }
    internal ICollection<Project> Projects { get; set; }
}