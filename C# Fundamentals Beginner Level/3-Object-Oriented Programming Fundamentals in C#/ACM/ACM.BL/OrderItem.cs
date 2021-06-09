using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId{ get; set; }
        public  decimal? PurchasePrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem(int OrderItemId)
        {
            this.OrderItemId = OrderItemId;
        }
        public bool Validate()
        {
            var isValid = true;

            if (Quantity<=0 )
                isValid = false;
            if (ProductId <= 0)
                isValid = false;
            if (PurchasePrice ==null)
                isValid = false;


            return isValid;
        }
    }
}
