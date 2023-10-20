using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Domain.AggregateModels.OrganizationAggregate;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Project;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class ProjectEntity
{
    internal Name Name { get; set; }
    internal Description Description { get; set; }
    internal Duration Duration { get; set; }
    internal Guid OrganizationId { get; set; }
    internal Organization Owner { get; set; }
    internal ICollection<Employee> Members { get; set; }
    internal ICollection<ProjectTask> Tasks { get; set; }
}