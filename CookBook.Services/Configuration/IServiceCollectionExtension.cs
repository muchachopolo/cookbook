using CookBook.Services.Users;
using Microsoft.Extensions.DependencyInjection;

namespace CookBook.Services.Configuration
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<LoginService>();
            return services;
        }
    }
}
