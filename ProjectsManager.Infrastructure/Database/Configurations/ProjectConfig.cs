using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.AggregateModels.ProjectAggregate.Entities;

namespace ProjectsManager.Infrastructure.Database.Configurations;

public class ProjectConfig:IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        throw new NotImplementedException();
    }
}