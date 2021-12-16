using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required]
        public string Name{ get; set; }
        [Required]
        public decimal Price{ get; set; }
        public string Image { get; set; }
        [Required]
        [Display(Name = "Product Color")]
        public string productColor{ get; set; }
        public bool isAvaliable { get; set; }

        [Display(Name = "Product Type")]
        [Required]
        public int productTypeId{ get; set; }
        [ForeignKey("productTypeId")]
        public virtual ProductTypes productTypes { get; set; }


        [Display(Name = "Special Tag")]
        [Required]
        public int SpecialTagId { get; set; }
        [ForeignKey("SpecialTagId")]
        public virtual SpecialTag SpecialTag { get; set; }



    }
}
