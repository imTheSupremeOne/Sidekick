using Microsoft.Extensions.DependencyInjection;
using Sidekick.Business.Apis.PoeNinja;
using Sidekick.Core;
using Sidekick.Services;

namespace Sidekick
{
    public static class StartupExtensions
    {
        public static IServiceCollection AddSidekickServices(this IServiceCollection services)
        {
            services.AddInitializableService<ITrayService, TrayService>();

            return services;
        }

        public static IServiceCollection AddPoeNinja(this IServiceCollection services)
        {
            services.AddSingleton<IPoeNinjaClient, PoeNinjaClient>();
            services.AddInitializableService<IPoeNinjaCache, PoeNinjaCache>();
            return services;
        }
    }
}
