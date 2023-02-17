using Management.BLL.Contracts.Persistence;
using Management.Products.EF;
using Management.Products.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Management.Products
{
    public static class ProductsServicesRegistration
    {
        public static IServiceCollection AddProductServices(this IServiceCollection services, IConfiguration
            configuration)
        {
            services.AddDbContext<DatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbContextt"), 
                    providerOptions => providerOptions.EnableRetryOnFailure());
            });
            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }

    }
}
