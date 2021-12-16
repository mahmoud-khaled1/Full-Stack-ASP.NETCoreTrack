using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewModels
{
    public class userViewModel
    {
        public string id { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTimeOffset lockoutDate { get; set; }
        
    }
}
