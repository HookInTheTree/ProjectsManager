using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjectsManager.Infrastructure.Database;
using ProjectsManager.Infrastructure.Identity;

namespace ProjectsManager.Infrastructure;

public static class DependencyInjection 
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, InfrastructureOptions options)
    {
        services.AddDbContext<AppDbContext>(
            opts => opts.UseSqlServer(options.ConnectionString));
        
        services.AddIdentity<ApplicationUser, ApplicationRole>();
        return services;
    }
}