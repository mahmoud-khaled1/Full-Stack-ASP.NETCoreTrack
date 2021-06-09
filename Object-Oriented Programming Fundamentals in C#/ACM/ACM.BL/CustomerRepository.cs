using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public Customer Retrive(int custid)
        {
            Customer customer = new Customer(custid);

            if(custid==1)
            {
                customer.EmailAddress = "aly@gmail.com";
                customer.FirstName = "ALy";
                customer.LastName = "Ahmed";
            }
            return customer;
        }
        public bool Save(Customer customer)
        {
            return true;
        }

    }
}
