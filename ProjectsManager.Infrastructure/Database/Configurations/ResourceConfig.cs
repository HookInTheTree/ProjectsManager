using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Infrastructure.Database.Models;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class ResourceConfig:IEntityTypeConfiguration<ResourceEntity>
    {
        public void Configure(EntityTypeBuilder<ResourceEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
}

