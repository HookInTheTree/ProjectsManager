using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectsManager.Application.Services.EmployeeManager;
using ProjectsManager.Application.Services.EmployeeManager.Models;
using ProjectsManager.Domain.Aggregates.Organization.ValueObjects;
using ProjectsManager.Models.Employees;

namespace ProjectsManager.Controllers
{
    [Route("api/organization/{organizationId}/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeManager employeeManager;
        public EmployeesController(IEmployeeManager _employeeManager)
        {
            employeeManager = _employeeManager;
        }

        [HttpGet]
        public async Task<ActionResult<List<EmployeeResponseModel>>> Get(Guid organizationId)
        {
            var employees = await employeeManager.GetEmployees(OrganizationId.Create(organizationId));
            return employees.Select(x => EmployeeResponseModel.FromDto(x)).ToList();
        }

        [HttpPost]
        public async Task<ActionResult<EmployeeResponseModel>> Create(EmployeeCreationModel model)
        {
            throw new NotImplementedException();
        }

    }
}
