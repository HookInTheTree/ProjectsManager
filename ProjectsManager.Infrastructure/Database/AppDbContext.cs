using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectsManager.Domain.EmployeeAggregate;
using ProjectsManager.Domain.OrganizationAggregate;
using ProjectsManager.Domain.ProjectAggregate.Entities;
using ProjectsManager.Infrastructure.Database.Configurations;
using ProjectsManager.Infrastructure.Identity;

namespace ProjectsManager.Infrastructure.Database
{
    internal class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new EmployeeConfig());
            builder.ApplyConfiguration(new OrganizationConfig());
            builder.ApplyConfiguration(new ProjectConfig());
            // builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        //
        internal DbSet<Project> Projects { get; set; }
        internal DbSet<Organization> Organizations { get; set; }
        internal DbSet<Employee> Employees { get; set; }
        // internal DbSet<WorkItemEntity> Tasks { get; set; }
    }
}
