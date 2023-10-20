﻿using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Infrastructure.Database.Models;
using ProjectsManager.Infrastructure.Identity;

namespace ProjectsManager.Infrastructure.Database
{
    internal class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        internal AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        
        internal DbSet<OrganizationEntity> Organizations { get; set; }
        internal DbSet<ProjectEntity> Projects { get; set; }
        internal DbSet<EmployeeEntity> Employees { get; set; }
        internal DbSet<TaskEntity> Tasks { get; set; }
        internal DbSet<ResourceEntity> Resources { get; set; }
    }
}