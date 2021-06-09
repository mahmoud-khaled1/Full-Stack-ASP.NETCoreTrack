using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class ProductRepository
    {
        public Product Retrive(int ProductId)
        {
            Product product = new Product(ProductId);

            if(ProductId==2)
            {
                product.PoductName = "SunFlowers";
                product.CurrentPrice = 15.545M;

            }
            return product;
        }
        public bool Save(Product product)
        {
            return true;
        }
    }
}
