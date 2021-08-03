using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdoToFood.Data;

namespace OdoToFood.Pages.Resturants
{
    public class ListModel : PageModel
    {
        private readonly IConfiguration config;
        private readonly IResturantData resturantData;
        public string  Message { get; set; }
        public IEnumerable<Resturant> Resturants { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchTerm { get; set; }

        public ListModel(IConfiguration config, IResturantData resturantData )
        {
            this.config = config;
            this.resturantData = resturantData;
        }
        public void OnGet()
        {
              
            Message = config["Message"];
            Resturants = resturantData.GetRestaurantByName(SearchTerm);
        }
    }
}
