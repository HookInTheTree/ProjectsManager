using ProjectsManager.Application.Services.OrganizationManager.Models;
using ProjectsManager.Domain.Aggregates.Employee;
using ProjectsManager.Domain.Aggregates.Organization;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Domain.Aggregates.Project;
using ProjectsManager.Domain.Common.ValueObjects;

namespace ProjectsManager.Application.Services.OrganizationManager
{
    public class OrganizationManager : IOrganizationManager
    {
        private readonly IOrganizationRepository _repository;
        public OrganizationManager(IOrganizationRepository repo)
        {
            _repository = repo;
        }

        public async Task<OrganizationDTO> GetOrganization(OrganizationId organizationId)
        {
            try
            {
                var organization = await _repository.GetById(organizationId);
                return OrganizationDTO.FromOrganization(organization);
            }
            catch (ArgumentNullException ex)
            {
                throw;
            }
        }

        public async Task<List<OrganizationDTO>> GetOrganizations()
        {
            var organizations = await _repository.GetAll();
            return organizations.Select(x => OrganizationDTO.FromOrganization(x)).ToList();
        }

        public async Task<OrganizationDTO> CreateOrganization(OrganizationCreationRequest request)
        {
            var organization = new Organization(
                OrganizationId.CreateUnique(),
                new Name(request.Name),
                new JuridicalAddress(request.PostalCode, request.State, request.City, request.Street, request.Building),
                new ContactInfo(request.Website, request.Email, request.PhoneNumber)
            );

            await _repository.Insert(organization);
            await _repository.Save();
            
            return OrganizationDTO.FromOrganization(organization);
        }

        public async Task<OrganizationDTO> UpdateOrganization(OrganizationUpdateRequest request)
        {
            var organization = new Organization(
                OrganizationId.Create(request.Id),
                new Name(request.Name),
                new JuridicalAddress(request.PostalCode, request.State, request.City, request.Street, request.Building),
                new ContactInfo(request.Website, request.Email, request.PhoneNumber)
            );

            await _repository.Update(organization);
            await _repository.Save();

            return OrganizationDTO.FromOrganization(organization);
        }

        public async Task<OrganizationId> DestroyOrganization(OrganizationId organizationId)
        {
            var removedEntity = await _repository.Remove(organizationId);
            await _repository.Save();
            return OrganizationId.Create(removedEntity.Id.Value);
        }


        public OrganizationId CreateOrganizationProject(OrganizationId organizationId, Project project)
        {
            throw new NotImplementedException();
        }

        public OrganizationId AddEmployeeToOrganization(OrganizationId organizationId, Employee employee)
        {
            throw new NotImplementedException();
        }

        public OrganizationId RemoveEmployeeFromOrganization(OrganizationId organizationId, Employee employee)
        {
            throw new NotImplementedException();
        }

        public OrganizationId RemoveOrganizationProject(OrganizationId organizationId, Project project)
        {
            throw new NotImplementedException();
        }

        public OrganizationId SetOrganizationOwner(OrganizationId organizationId, Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
