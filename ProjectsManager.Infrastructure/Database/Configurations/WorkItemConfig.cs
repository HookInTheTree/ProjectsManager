using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.WorkItem;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class WorkItemConfig : IEntityTypeConfiguration<WorkItem>
    {
        public void Configure(EntityTypeBuilder<WorkItem> builder)
        {
            ConfigureWorkItemsTable(builder);
            ConfigureResourcesTable(builder);
            ConfigureResourcesTypesTable(builder);
            
        }

        private void ConfigureWorkItemsTable(EntityTypeBuilder<WorkItem> builder)
        {
            builder.OwnsOne(task => task.Name);
            builder.OwnsOne(task => task.Description);
            builder.OwnsOne(task => task.Duration);
        }

        private void ConfigureResourcesTypesTable(EntityTypeBuilder<WorkItem> builder)
        {
            throw new NotImplementedException();
        }

        private void ConfigureResourcesTable(EntityTypeBuilder<WorkItem> builder)
        {
            throw new NotImplementedException();
        }
    }
}

