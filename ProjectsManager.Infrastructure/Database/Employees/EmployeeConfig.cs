using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Employee.ValueObjects;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Employees
{
    public class EmployeeConfig : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            ConfigureEmployeesTable(builder);
            ConfigureEmployeesProjectsIdsTable(builder);
            ConfigureEmployeesWorkItemIdsTable(builder);
        }
        private void ConfigureEmployeesTable(EntityTypeBuilder<Employee> builder)
        {
            builder.ToTable("Employees");

            builder.HasKey(e => e.Id);

            builder.Property(m => m.Id)
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => EmployeeId.Create(value));

            builder.OwnsOne(x => x.FullName);
            builder.OwnsOne(x => x.PassportInfo);

            builder.Property(m => m.OrganizationId)
                .ValueGeneratedNever()
                .HasConversion(
                    id => id.Value,
                    value => OrganizationId.Create(value));
        }

        private void ConfigureEmployeesProjectsIdsTable(EntityTypeBuilder<Employee> builder)
        {
            builder.OwnsMany(x => x.ProjectIds, pb =>
            {
                pb.ToTable("EmployeesProjectsIds");

                pb.WithOwner().HasForeignKey("EmployeeId");

                pb.HasKey("Id");

                pb.Property(p => p.Value)
                    .HasColumnName("ProjectId")
                    .ValueGeneratedNever();
            });
            builder.Metadata.FindNavigation(nameof(Employee.ProjectIds))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }

        private void ConfigureEmployeesWorkItemIdsTable(EntityTypeBuilder<Employee> builder)
        {
            builder.OwnsMany(x => x.WorkItemIds, pb =>
            {
                pb.ToTable("EmployeesWorkItemIds");

                pb.WithOwner().HasForeignKey("EmployeeId");

                pb.HasKey("Id");

                pb.Property(p => p.Value)
                    .HasColumnName("WorkItemId")
                    .ValueGeneratedNever();
            });
            builder.Metadata.FindNavigation(nameof(Employee.WorkItemIds))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }
    }
}