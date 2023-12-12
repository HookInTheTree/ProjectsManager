using ProjectsManager.Application.Services.OrganizationManager.Models;

namespace ProjectsManager.Controllers
{
    public class OrganizationModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        internal static OrganizationModel FromDTO(OrganizationDTO x)
        {
            return new OrganizationModel()
            {
                Id = x.Id,
                Name = x.Name,
                PostalCode = x.PostalCode,
                Address = x.Address
            };
        }
    }
}