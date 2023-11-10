
using ProjectsManager.Domain.Aggregates.Organization;

namespace ProjectsManager.Application.Services.OrganizationManager.Models
{
    public class OrganizationDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }

        private OrganizationDTO()
        {

        }

        public static OrganizationDTO FromOrganization(Organization domainModel)
        {
            return new OrganizationDTO()
            {
                Id = domainModel.Id.Value,
                Name = domainModel.Name.Value,
                PostalCode = domainModel.JuridicalAddress.PostalСode.Value,
                Address = domainModel.JuridicalAddress.PhysicalAddress.ToString()
            };
        }
    }
}