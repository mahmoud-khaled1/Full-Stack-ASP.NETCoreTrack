using System.Collections.Generic;

namespace TennisBookings.Web.External.Models
{
    public class ProductsApiResult
    {
        public int TotalProducts { get; set; }

        public IReadOnlyCollection<Product> Products { get; set; }
    }
}
