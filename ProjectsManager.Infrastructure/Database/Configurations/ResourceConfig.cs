using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.ProjectAggregate.Entities;
using ProjectsManager.Domain.ProjectAggregate.ValueObjects.Resources;
using ProjectsManager.Infrastructure.Database.Models;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class ResourceConfig : IEntityTypeConfiguration<ResourceEntity>
    {
        public void Configure(EntityTypeBuilder<ResourceEntity> builder)
        {
            builder.OwnsOne(resource => resource.Name, subbuilder =>
            {
                subbuilder.Property(name => name.Value)
                .HasColumnName("Name");
            });

            builder.OwnsOne(resource => resource.Description, subbuilder =>
            {
                subbuilder.Property(description => description.Value)
                    .HasColumnName("Description");
            });

            builder.OwnsOne(resource => resource.Cost, subbuilder =>
            {
                subbuilder.Property(cost => cost.Value)
                    .HasColumnName("Cost");
            });

            builder.OwnsOne(resource => resource.Quantity, subbuilder =>
            {
                subbuilder.Property(quantity => quantity.Value)
                    .HasColumnName("Quantity");
            });

        }
    }
}

