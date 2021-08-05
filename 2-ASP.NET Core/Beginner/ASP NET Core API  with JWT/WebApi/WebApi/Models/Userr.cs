using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi.Models
{
    public partial class Userr
    {
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public DateTime UserCreateDate { get; set; }
    }
}
