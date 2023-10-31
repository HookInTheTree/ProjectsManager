using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Infrastructure.Database.Models;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class WorkItemConfig : IEntityTypeConfiguration<WorkItemEntity>
    {
        public void Configure(EntityTypeBuilder<WorkItemEntity> builder)
        {
            builder.OwnsOne(task => task.Name, subbuilder =>
            {
                subbuilder.Property(name => name.Value)
                    .HasColumnName("Name");
            });

            builder.OwnsOne(task => task.Description, subbuilder =>
            {
                subbuilder.Property(description => description.Value)
                    .HasColumnName("Description");
            });

            builder.OwnsOne(task => task.Duration, subbuilder =>
            {
                subbuilder.Property(duration => duration.Start)
                    .HasColumnName("Start");

                subbuilder.Property(duration => duration.End)
                    .HasColumnName("End");
            });
        }
    }
}

