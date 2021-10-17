using System.Threading.Tasks;
using TennisBookings.Web.External.Models;

namespace TennisBookings.Web.External
{
    public interface IProductsApiClient
    {
        Task<ProductsApiResult> GetProducts();
    }
}
