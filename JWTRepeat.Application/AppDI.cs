using JWTRepeat.Application.Abstractions;
using JWTRepeat.Application.Services.UserServices;
using Microsoft.Extensions.DependencyInjection;

namespace JWTRepeat.Application
{
    public static class AppDI
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
