using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.AggregateModels.OrganizationAggregate;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    public class OrganizationConfig:IEntityTypeConfiguration<Organization>
    {
        public void Configure(EntityTypeBuilder<Organization> builder)
        {
            throw new NotImplementedException();
        }
    }

}

