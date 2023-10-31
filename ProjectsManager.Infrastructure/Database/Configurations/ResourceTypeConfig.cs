using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Infrastructure.Database.Models;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class ResourceTypeConfig:IEntityTypeConfiguration<ResourceTypeEntity>
    {
        public void Configure(EntityTypeBuilder<ResourceTypeEntity> builder)
        {
            builder.OwnsOne(type => type.Name, subbuilder =>
            {
                subbuilder.Property(name => name.Value)
                .HasColumnName("Name");
            });

            builder.OwnsOne(type => type.Description, subbuilder =>
            {
                subbuilder.Property(description => description.Value)
                    .HasColumnName("Description");
            });

        }
    }
}

