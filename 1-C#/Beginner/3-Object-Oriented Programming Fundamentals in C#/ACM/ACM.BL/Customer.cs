using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId{ get; set; }
        public string  FirstName { get; set; }
        public string LastName{ get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public List<Address> AddressList{ get; set; }
        public Customer():this(0)
        {

        }
        public Customer(int custid)
        {
            this.CustomerId = custid;
            AddressList = new List<Address>();
        }
       

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName))
                isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress))
                isValid = false;

            return isValid;
        }

    }

}
