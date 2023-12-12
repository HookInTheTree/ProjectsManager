using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectsManager.Application.Services.OrganizationManager;
using ProjectsManager.Application.Services.OrganizationManager.Models;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;

namespace ProjectsManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        private readonly IOrganizationManager manager;
        public OrganizationsController(IOrganizationManager _manager)
        {
            manager = _manager;
        }

        [HttpPost]
        public async Task<ActionResult<OrganizationModel>> Create(OrganizationCreationModel model)
        {
            var requestModel = new OrganizationCreationRequest()
            {
                Name = model.Name,
                PostalCode = model.PostalCode,
                Building = model.Building,
                City = model.City,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                State = model.State,
                Street = model.Street,
                Website = model.Website,
            };
            var createdModel = await manager.CreateOrganization(requestModel);
            return Ok(OrganizationModel.FromDTO(createdModel));
        }

        [HttpGet]
        public async Task<ActionResult<OrganizationModel>> Get()
        {
            var organizations = await manager.GetOrganizations();
            
            return Ok(organizations
                .Select(x => OrganizationModel.FromDTO(x))
                .ToList());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrganizationModel>> GetSpecific(Guid id)
        {
            var organization = await manager.GetOrganization(OrganizationId.Create(id));
            return Ok(OrganizationModel.FromDTO(organization));
        }

        [HttpPatch("{id}")]
        public async Task<ActionResult<OrganizationModel>> Update(Guid id, OrganizationUpdateModel model)
        {
            var requestModel = new OrganizationUpdateRequest()
            {
                Name = model.Name,
                PostalCode = model.PostalCode,
                Building = model.Building,
                City = model.City,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                State = model.State,
                Street = model.Street,
                Website = model.Website,
            };

            var updatedModel = await manager.UpdateOrganization(OrganizationId.Create(id), requestModel);
            return Ok(OrganizationModel.FromDTO(updatedModel));
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<OrganizationModel>> Delete(Guid id)
        {
            var deletedModel = await manager.DestroyOrganization(OrganizationId.Create(id));
            return Ok(OrganizationModel.FromDTO(deletedModel));
        }
    }
}
