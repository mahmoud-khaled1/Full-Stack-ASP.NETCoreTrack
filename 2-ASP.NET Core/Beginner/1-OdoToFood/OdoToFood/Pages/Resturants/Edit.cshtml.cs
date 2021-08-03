using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdeToFood.Core;
using OdoToFood.Data;
namespace OdoToFood.Pages.Resturants
{
    public class EditModel : PageModel
    {
        public EditModel(IResturantData resturantData)
        {
                
        }
        public void OnGet()
        {

        }
    }
}
