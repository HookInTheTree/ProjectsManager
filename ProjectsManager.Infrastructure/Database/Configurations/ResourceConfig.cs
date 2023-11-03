using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.Resource;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class ResourceConfig : IEntityTypeConfiguration<Resource>
    {
        public void Configure(EntityTypeBuilder<Resource> builder)
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

        }
    }
}

