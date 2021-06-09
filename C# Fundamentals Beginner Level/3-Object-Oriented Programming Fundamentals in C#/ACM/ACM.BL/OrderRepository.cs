using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    class OrderRepository
    {
        public Order Retrive(int OrderId)
        {
            Order order = new Order(OrderId);

            if (OrderId == 20)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00, new TimeSpan(7, 0, 0));


            }
            return order;
        }
        public bool Save(Order order)
        {
            return true;
        }
    }
}
