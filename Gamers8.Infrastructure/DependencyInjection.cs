
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Gamers8.Infrastructure
{
    using Booking.Infrastructure.Persistence;
    using Gamers8.Infrastructure;
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Gamers8Context>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(Gamers8Context).Assembly.FullName)));

            services.AddDatabaseDeveloperPageExceptionFilter();
            return services;
        }

    }
}