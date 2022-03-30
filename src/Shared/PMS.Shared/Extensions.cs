using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using PMS.Shared.Commands;
using PMS.Shared.Database;
using PMS.Shared.Dispatchers;
using PMS.Shared.Events;
using PMS.Shared.Exceptions;
using PMS.Shared.Messaging;
using PMS.Shared.Queries;
using PMS.Shared.Time;

namespace PMS.Shared;

public static class Extensions
{
    private const string ApiTitle = "PMS API";
    private const string ApiVersion = "v1";
        
    public static IServiceCollection AddSharedFramework(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddErrorHandling();
        services.AddCommands();
        services.AddEvents();
        services.AddQueries();
        services.AddMessaging();
        services.AddPostgres(configuration);
        services.AddControllers();
        services.AddSingleton<IClock, UtcClock>();
        services.AddSingleton<IDispatcher, InMemoryDispatcher>();
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        services.AddSwaggerGen(swagger =>
        {
            swagger.EnableAnnotations();
            swagger.CustomSchemaIds(x => x.FullName);
            swagger.SwaggerDoc(ApiVersion, new OpenApiInfo
            {
                Title = ApiTitle,
                Version = ApiVersion
            });
        });
            
        return services;
    }
        
    public static IApplicationBuilder UseSharedFramework(this IApplicationBuilder app)
    {
        app.UseErrorHandling();
        app.UseSwagger();
        app.UseReDoc(reDoc =>
        {
            reDoc.RoutePrefix = "docs";
            reDoc.SpecUrl($"/swagger/{ApiVersion}/swagger.json");
            reDoc.DocumentTitle = ApiTitle;
        });
        app.UseRouting();
            
        return app;
    }
}