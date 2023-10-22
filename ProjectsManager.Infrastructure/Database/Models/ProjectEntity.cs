﻿using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Domain.AggregateModels.OrganizationAggregate;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.ValueObjects.Project;

namespace ProjectsManager.Infrastructure.Database.Models;

internal class ProjectEntity: BaseEntity
{
    internal Name Name { get; set; }
    internal Description Description { get; set; }
    internal Duration Duration { get; set; }
    internal Guid OwnerId { get; set; }
    internal OrganizationEntity Owner { get; set; }
    internal ICollection<EmployeeEntity> Members { get; set; }
    internal ICollection<ProjectTaskEntity> Tasks { get; set; }
}