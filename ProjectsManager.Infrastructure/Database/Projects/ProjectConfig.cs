using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project;
using ProjectsManager.Domain.Aggregates.Project.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Projects
{
    internal class ProjectConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            ConfigureProjectTable(builder);
            ConfigureProjectMemberIds(builder);
            ConfigureProjectWorkItemsIds(builder);
        }

        private void ConfigureProjectTable(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");

            builder.HasKey(project => project.Id);

            builder.Property(project => project.Id)
                .HasConversion(id => id.Value, value => ProjectId.Create(value))
                .ValueGeneratedNever();

            builder.Property(project => project.OwnerId)
                .HasConversion(id => id.Value, value => OrganizationId.Create(value))
                .ValueGeneratedNever();

            builder.OwnsOne(project => project.Name);

            builder.OwnsOne(project => project.Description);

            builder.OwnsOne(project => project.Duration);
        }

        private void ConfigureProjectWorkItemsIds(EntityTypeBuilder<Project> builder)
        {
            builder.OwnsMany(x => x.WorkItemIds, pb =>
            {
                pb.ToTable("ProjectWorkItemsIds");

                pb.WithOwner().HasForeignKey("ProjectId");

                pb.HasKey("Id");

                pb.Property(p => p.Value)
                    .HasColumnName("WorkItemId")
                    .ValueGeneratedNever();
            });
            builder.Metadata.FindNavigation(nameof(Project.WorkItemIds))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }

        private void ConfigureProjectMemberIds(EntityTypeBuilder<Project> builder)
        {
            builder.OwnsMany(x => x.MemberIds, pb =>
            {
                pb.ToTable("ProjectMembersIds");

                pb.WithOwner().HasForeignKey("ProjectId");

                pb.HasKey("Id");

                pb.Property(p => p.Value)
                    .HasColumnName("EmployeeId")
                    .ValueGeneratedNever();
            });
            builder.Metadata.FindNavigation(nameof(Project.MemberIds))
                .SetPropertyAccessMode(PropertyAccessMode.Field);
        }


    }
}

