using GameCatalogue.Application.Interfaces;
using GameCatalogue.Application.Mappings;
using GameCatalogue.Application.Services;
using GameCatalogue.Domain.Interfaces;
using GameCatalogue.Infra.Data.Context;
using GameCatalogue.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GameCatalogue.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"
                ), b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IPlatformRepository, PlatformRepository>();
            services.AddScoped<IGameRepository, GameRepository>();

            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IPlatformService, PlatformService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;
        }
    }
}
