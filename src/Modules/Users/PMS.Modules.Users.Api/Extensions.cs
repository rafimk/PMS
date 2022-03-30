using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PMS.Modules.Users.Core;

namespace PMS.Modules.Users.Api;

public static class Extensions
{
    public static IServiceCollection AddUsersModule(this IServiceCollection services)
    {
        services.AddCoreLayer();
            
        return services;
    }
        
    public static IApplicationBuilder UseUsersModule(this IApplicationBuilder app)
    {
        return app;
    }
}