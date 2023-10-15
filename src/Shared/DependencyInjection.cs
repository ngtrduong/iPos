using Microsoft.Extensions.DependencyInjection;
using Shared.Services.Implements;
using Shared.Services.Interfaces;

namespace Shared;
public static class DependencyInjection
{
    public static IServiceCollection AddSharedServices(this IServiceCollection services)
    {
        services.AddScoped<ICurrentUser, CurrentUser>();

        return services;
    }
}
