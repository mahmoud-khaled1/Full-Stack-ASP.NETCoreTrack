using Microsoft.Extensions.DependencyInjection;
using TennisBookings.Web.External;

namespace TennisBookings.Web.Core.DependencyInjection
{
    public static class ProductsServiceCollectionExtensions
    {
        public static IServiceCollection AddExternalProducts(this IServiceCollection services)
        {
            services.AddHttpClient<IProductsApiClient, ProductsApiClient>();

            return services;
        }
    }
}
