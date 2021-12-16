using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.ViewModels
{
    public class roleUserViewModel
    {
        [Required]
        [Display(Name ="User")]
        public int userId { get; set; }
        [Required]
        [Display(Name = "Role")]
        public int roleId { get; set; }
    }
}
