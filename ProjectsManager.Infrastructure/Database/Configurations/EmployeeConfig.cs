using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.AggregateModels.EmployeeAggregate;

namespace ProjectsManager.Infrastructure.Database.Configurations;

public class EmployeeConfig:IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        throw new NotImplementedException();
    }
}