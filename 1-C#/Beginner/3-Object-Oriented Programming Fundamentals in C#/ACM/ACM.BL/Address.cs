using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Address
    {
        public int AddressId { get; set; }
        public int AdressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string postalCode { get; set; }
        public string State { get; set; }

        public Address(int AddressId)
        {
            this.AddressId = AddressId;
        }
        public bool Validate()
        {
            var isValid = true;

            if (postalCode == null)
                isValid = false;

            return isValid;
        }


    }
}
