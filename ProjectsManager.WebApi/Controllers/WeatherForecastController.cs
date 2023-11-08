using Microsoft.AspNetCore.Mvc;
using ProjectsManager.Domain.Common.ValueObjects;
using ProjectsManager.Domain.EmployeeAggregate.ValueObjects;
using ProjectsManager.Domain.ProjectAggregate.ValueObjects;
using ProjectsManager.Domain.WorkItem;
using ProjectsManager.Domain.WorkItem.Repositories;
using ProjectsManager.Domain.WorkItem.ValueObjects;

namespace ProjectsManager.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWorkItemRepository workItemRepository;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWorkItemRepository repo)
    {
        _logger = logger;
        workItemRepository = repo;
    }

    [HttpGet(Name = "GetWeather")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
            .ToArray();
    }

    [HttpGet(Name = "GetWorkItems")]
    public async Task<List<WorkItem>> GetWorkItems()
    {
        return await workItemRepository.GetAll();
    }


    [HttpPost(Name = "CreateWorkItem")]
    public async Task<WorkItem> CreateWork()
    {
        var workItem = new WorkItem(
            WorkItemId.CreateUnique(),
            new Name("145234523452345234514523452345234523451452345234523452345145234523452345234514523452345234523451452345234523452345"),
            new Description("12341234123412342134123414523452345234523451452345234523452345145234523452345234514523452345234523451452345234523452345"),
            new Duration(DateTime.Now, DateTime.Now.AddDays(1)),
            ProjectId.CreateUnique(),
            EmployeeId.CreateUnique());

        await workItemRepository.Insert(workItem);
        await workItemRepository.Save();
        return workItem;
    }
}