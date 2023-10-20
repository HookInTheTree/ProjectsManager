using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectsManager.Domain.AggregateModels.OrganizationAggregate;
using ProjectsManager.Infrastructure.Database.Models;

namespace ProjectsManager.Infrastructure.Database.Configurations
{
    internal class OrganizationConfig:IEntityTypeConfiguration<OrganizationEntity>
    {
        public void Configure(EntityTypeBuilder<OrganizationEntity> builder)
        {
            builder.OwnsOne(organization => organization.Name, subbuilder =>
            {
                subbuilder.Property(name => name.Value)
                    .HasColumnName("Name");
            });
            
            builder.OwnsOne(organization => organization.ContactInfo, subbuilder =>
            {
                subbuilder.Property(info => info.Email)
                    .HasColumnName("Email");

                subbuilder.Property(info => info.PhoneNumber)
                    .HasColumnName("Phonenumber");

                subbuilder.Property(info => info.WebSite)
                    .HasColumnName("WebSite");
            });
            
            builder.OwnsOne(organization => organization.JuridicalAddress, subbuilder =>
            {
                subbuilder.Property(address => address.PhysicalAddress)
                    .HasColumnName("PhysicalAddress");

                subbuilder.Property(address => address.PostalСode)
                    .HasColumnName("PostalСode");
            });
        }
    }

}

