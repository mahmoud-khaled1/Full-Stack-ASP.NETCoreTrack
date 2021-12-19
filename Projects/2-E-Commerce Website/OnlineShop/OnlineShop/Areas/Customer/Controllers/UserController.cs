using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Data;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class UserController : Controller
    {
        UserManager<IdentityUser> _userManager;
        RoleManager<IdentityRole> _roleManager;
        ApplicationDbContext _db;
        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
           
        }
        [HttpGet]
        public IActionResult Index()
        {
          
                return View(_db.Products.Include(c => c.productTypes).Include(f => f.SpecialTag).ToList());

        }
        [HttpPost]
        public IActionResult Index(string search)
        {
            var products = _db.Products.Include(c => c.productTypes).Include(c => c.SpecialTag)
                           .Where(p => p.Name.Contains(search)).ToList();
            if (search==null)
            {
                products = _db.Products.Include(c => c.productTypes).Include(f => f.SpecialTag).ToList();
            }

            return View(products);
        }
        [HttpGet]
        public IActionResult ProductsByTypes(string type)
        {
            List<Products> productsss = _db.Products.Include(p => p.productTypes).Include(p => p.SpecialTag).
                Where(p => p.productTypes.ProductType == type).ToList();
            return View(productsss);
        }
        [HttpPost]
        [ActionName("ProductsByTypes")]
        public IActionResult ProductsByTypess(string search)
        {
            var products = _db.Products.Include(c => c.productTypes).Include(c => c.SpecialTag)
                           .Where(p => p.Name.Contains(search)).ToList();
            if (search == null)
            {
                products = _db.Products.Include(c => c.productTypes).Include(f => f.SpecialTag).ToList();
            }

            return View(products);
        }


    }
}
