using Microsoft.Extensions.DependencyInjection;
using PMS.Modules.Users.Core.DAL;
using PMS.Modules.Users.Core.Services;
using PMS.Modules.Users.Shared;
using PMS.Shared.Database;

namespace PMS.Modules.Users.Core;

public static class Extensions
{
    public static IServiceCollection AddCoreLayer(this IServiceCollection services)
    {
        services.AddPostgres<UsersDbContext>();
        services.AddTransient<IUsersService, UsersService>();
        services.AddTransient<IUsersModuleApi, UsersModuleApi>();
            
        return services;
    }
}