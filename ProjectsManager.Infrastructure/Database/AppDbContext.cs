using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Organization;
using ProjectsManager.Domain.Aggregates.Project;
using ProjectsManager.Domain.Aggregates.WorkItem;
using ProjectsManager.Infrastructure.Identity;

namespace ProjectsManager.Infrastructure.Database
{
    public class AppDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        internal DbSet<Project> Projects { get; set; }
        internal DbSet<Organization> Organizations { get; set; }
        internal DbSet<Employee> Employees { get; set; }
        internal DbSet<WorkItem> WorkItems { get; set; }
    }
}
