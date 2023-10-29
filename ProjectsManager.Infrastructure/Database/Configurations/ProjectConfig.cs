using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.ProjectAggregate.Entities;
using ProjectsManager.Infrastructure.Database.Models;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class ProjectConfig:IEntityTypeConfiguration<ProjectEntity>
    {
        public void Configure(EntityTypeBuilder<ProjectEntity> builder)
        {
            builder.OwnsOne(project => project.Name, subbuilder =>
            {
                subbuilder.Property(name => name.Value)
                    .HasColumnName("Name");
            });
            
            builder.OwnsOne(project => project.Description, subbuilder =>
            {
                subbuilder.Property(description => description.Value)
                    .HasColumnName("Description");
            });
            
            builder.OwnsOne(project => project.Duration, subbuilder =>
            {
                subbuilder.Property(duration => duration.Start)
                    .HasColumnName("Start");

                subbuilder.Property(duration => duration.End)
                    .HasColumnName("End");
            });
        }
    }
}

