using JWTRepeat.Application.Abstractions;
using JWTRepeat.Infrastructure.Persistance;
using JWTRepeat.Infrastructure.Repositories.BaseRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace JWTRepeat.Infrastructure
{
    public static class InfraDI
    {
        public static IServiceCollection AddJWTContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<JWTRepeatDbContext>(options=>
            {
                options.UseNpgsql(configuration.GetConnectionString("Cs"));

            });
            
            return services;

        }
    }
}
