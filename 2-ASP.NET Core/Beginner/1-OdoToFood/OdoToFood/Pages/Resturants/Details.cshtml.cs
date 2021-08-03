using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;

namespace OdoToFood.Pages.Resturants
{
    public class DetailsModel : PageModel
    {
        public Resturant Resturant{ get; set; }
        public void OnGet(int restID)
        {
            Resturant = new Resturant();
            Resturant.Id = restID;
            
        }
    }
}
