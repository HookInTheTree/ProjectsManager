using Microsoft.Extensions.DependencyInjection;
using ProjectsManager.Application.Services.EmployeeManager;
using ProjectsManager.Application.Services.OrganizationManager;
using ProjectsManager.Application.Services.ProjectManager;
using ProjectsManager.Application.Services.WorkItemManager;

namespace ProjectsManager.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IOrganizationManager, OrganizationManager>();
        services.AddScoped<IProjectManager, ProjectManager>();
        services.AddScoped<IEmployeeManager, EmployeeManager>();
        services.AddScoped<IWorkItemManager, WorkItemManager>();
        return services;
    }

}