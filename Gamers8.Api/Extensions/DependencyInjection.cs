using Gamers8.Api.Services;
using Gamers8.Core.Services;

namespace Gamers8.Api.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresentation(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddSingleton<ICurrentUserService, CurrentUserService>();

            return services;
        }

    }
}
