using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class Order
    {
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public List<OrderItem> OrderItem{get;set;}


        public Order(int orderid)
        {
            this.OrderId = OrderId;
        }
        public bool Validate()
        {
            var isValid = true;
            
            if (OrderDate == null)
                isValid = false;

            return isValid;
        }

    }
}
