using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Product
    {
        public decimal? CurrentPrice{ get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; set; }
        public string PoductName { get; set; }
        public Product(int productid)
        {
            this.ProductId = productid;
        }
        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(PoductName))
                isValid = false;
            if (CurrentPrice==null)
                isValid = false;

            return isValid;
        }

    }
}
