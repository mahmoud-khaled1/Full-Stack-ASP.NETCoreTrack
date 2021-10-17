using Microsoft.Extensions.Options;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using TennisBookings.Web.Configuration;
using TennisBookings.Web.External.Models;
using Microsoft.Extensions.Caching.Memory;

namespace TennisBookings.Web.External
{
    public class ProductsApiClient : IProductsApiClient
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<ProductsApiClient> _logger;
        private readonly IMemoryCache _cache;
        private readonly IOptionsMonitor<ExternalServicesConfig> _productsApiConfig;

        public ProductsApiClient(HttpClient httpClient, IOptionsMonitor<ExternalServicesConfig> options, ILogger<ProductsApiClient> logger, IMemoryCache cache)
        {
            var externalServicesConfig = options.Get(ExternalServicesConfig.ProductsApi);

            httpClient.BaseAddress = new Uri(externalServicesConfig.Url);

            _httpClient = httpClient;
            _logger = logger;
            _cache = cache;
            _productsApiConfig = options;
        }

        public async Task<ProductsApiResult> GetProducts()
        {
            const string cacheKey = "Products";

            if (_cache.TryGetValue<ProductsApiResult>(cacheKey, out var forecast))
            {
                return forecast;
            }

            const string path = "api/products";

            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, path);
                request.Headers.Add("ApiKey", _productsApiConfig.Get(ExternalServicesConfig.ProductsApi)
                    .ApiKey);

                var response = await _httpClient.SendAsync(request);

                if (!response.IsSuccessStatusCode)
                {
                    return null;
                }

                var content = await response.Content.ReadAsAsync<ProductsApiResult>();

                if (content != null)
                {
                    var cacheOptions = new MemoryCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(_productsApiConfig.Get(ExternalServicesConfig.ProductsApi).MinsToCache)
                    };

                    _cache.Set(cacheKey, content, cacheOptions);
                }

                return content;
            }
            catch (HttpRequestException e)
            {
                _logger.LogError(e, "Failed to get products data from API");
            }

            return null;
        }
    }
}
