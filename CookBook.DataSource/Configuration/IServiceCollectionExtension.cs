using System;
using CookBook.DataSource.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CookBook.DataSource.Configuration
{
    public static class IServiceCollectionExtension
    {
        public static IServiceCollection AddDataSourceRepositories(this IServiceCollection services)
        {
            services.AddDbContext<DataRepository>(options =>
            {
                options.UseInMemoryDatabase("CookBook");
            });
            return services;
        }
    }
}
