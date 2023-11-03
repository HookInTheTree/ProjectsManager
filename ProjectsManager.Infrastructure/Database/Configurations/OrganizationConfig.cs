using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.EmployeeAggregate;
using ProjectsManager.Domain.OrganizationAggregate;
using ProjectsManager.Domain.OrganizationAggregate.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class OrganizationConfig : IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            ConfigureOrganizationTable(builder);
            ConfigureProjectIdsTable(builder);
            ConfigureEmployeeIdsTable(builder);
        }

        private void ConfigureOrganizationTable(EntityTypeBuilder<Organization> builder)
        {
            builder.ToTable("Organizations");

            builder.HasKey("Id");

            builder.Property(organization => organization.Id)
                .HasConversion(id => id.Value, value => OrganizationId.Create(value))
                .ValueGeneratedNever();

            builder.OwnsOne(organization => organization.Name);

            builder.OwnsOne(organization => organization.ContactInfo);

            builder.OwnsOne(organization => organization.JuridicalAddress, jab =>
            {
                jab.OwnsOne(ja => ja.PostalСode);
                jab.OwnsOne(ja => ja.PhysicalAddress);
            });
        }

        private void ConfigureEmployeeIdsTable(EntityTypeBuilder<Organization> builder)
        {
            builder.OwnsMany(x => x.EmployeeIds, pb =>
            {
                pb.ToTable("OrganizationEmployeesIds");

                pb.WithOwner().HasForeignKey("OrganizationId");

                pb.HasKey("Id");

                pb.Property(p => p.Value)
                    .HasColumnName("EmployeeId")
                    .ValueGeneratedNever();
            });

            builder.Metadata.FindNavigation(nameof(Organization.EmployeeIds))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }

        private void ConfigureProjectIdsTable(EntityTypeBuilder<Organization> builder)
        {
            builder.OwnsMany(x => x.ProjectIds, pb =>
            {
                pb.ToTable("OrganizationProjectsIds");

                pb.WithOwner().HasForeignKey("OrganizationId");

                pb.HasKey("Id");

                pb.Property(p => p.Value)
                    .HasColumnName("ProjectId")
                    .ValueGeneratedNever();
            });

            builder.Metadata.FindNavigation(nameof(Organization.ProjectIds))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }

       
    }

}

