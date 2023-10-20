using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Primitives;
using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;
using ProjectsManager.Infrastructure.Database.Models;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class EmployeeConfig:IEntityTypeConfiguration<EmployeeEntity>
    {
        public void Configure(EntityTypeBuilder<EmployeeEntity> builder)
        {
            builder.OwnsOne(employee => employee.FullName, subbuilder =>
            {
                subbuilder.Property(name => name.Name)
                    .HasColumnName("Name");

                subbuilder.Property(name => name.MiddleName)
                    .HasColumnName("MiddleName");

                subbuilder.Property(name => name.LastName)
                    .HasColumnName("LastName");
            });
            
            builder.OwnsOne(employee => employee.PassportInfo, subbuilder =>
            {
                subbuilder.Property(passportDetails => passportDetails.Serial)
                    .HasColumnName("Serial");

                subbuilder.Property(passportDetails => passportDetails.Number)
                    .HasColumnName("Number");
            });
        }
    }

}

