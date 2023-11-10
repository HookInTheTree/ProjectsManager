namespace ProjectsManager.Application.Services.OrganizationManager.Models
{
    public class OrganizationCreationRequest
    {
        public string Name { get; internal set; }
        public string PostalCode { get; internal set; }
        public string State { get; internal set; }
        public string City { get; internal set; }
        public string Street { get; internal set; }
        public string Building { get; internal set; }
        public string PhoneNumber { get; internal set; }
        public string Email { get; internal set; }
        public string Website { get; internal set; }
    }
}