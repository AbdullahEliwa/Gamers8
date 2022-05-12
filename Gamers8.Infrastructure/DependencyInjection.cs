
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Booking.Infrastructure.Persistence;
using Gamers8.Infrastructure.Repositories;
using Gamers8.Infrastructure.Repositories.SummitFeature;
using Gamers8.Core.Repositories.SummitFeature;
using Gamers8.Core.Repositories;
using Gamers8.Core.Services;
using Gamers8.Infrastructure.Services;

namespace Gamers8.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<Gamers8Context>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(Gamers8Context).Assembly.FullName)));

            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddScoped<ISummitRepository, SummitRepository>();
            services.AddScoped<ISummitDayRepository, SummitDayRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IStorageService, LocalStorageService>();



            return services;
        }

    }
}