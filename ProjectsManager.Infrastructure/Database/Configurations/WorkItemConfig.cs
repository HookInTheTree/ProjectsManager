﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.EmployeeAggregate.ValueObjects;
using ProjectsManager.Domain.ProjectAggregate.ValueObjects;
using ProjectsManager.Domain.WorkItem;
using ProjectsManager.Domain.WorkItem.ValueObjects;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class WorkItemConfig : IEntityTypeConfiguration<WorkItem>
    {
        public void Configure(EntityTypeBuilder<WorkItem> builder)
        {
            builder.ToTable("WorkItems");
            
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasConversion(x => x.Value, value => WorkItemId.Create(value))
                .ValueGeneratedNever();

            builder.Property(x => x.ProjectId)
                .HasConversion(x => x.Value, value => ProjectId.Create(value))
                .ValueGeneratedNever();

            builder.Property(x => x.OwnerId)
                .HasConversion(x => x.Value, value => EmployeeId.Create(value))
                .ValueGeneratedNever();

            builder.OwnsOne(x => x.Name);
            builder.OwnsOne(x => x.Description);
            builder.OwnsOne(x => x.Duration);
            builder.OwnsOne(x => x.Status);
        }

    }
}

