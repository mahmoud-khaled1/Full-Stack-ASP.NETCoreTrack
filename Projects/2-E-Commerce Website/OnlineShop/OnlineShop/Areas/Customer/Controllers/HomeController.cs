using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models;
using Microsoft.Extensions.Logging;
using OnlineShop.Data;
using Microsoft.EntityFrameworkCore;
using OnlineShop.Utility;

namespace OnlineShop.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Products.Include(c=>c.productTypes).Include(c=>c.SpecialTag).ToList());
        }

        //Get Product Details 
        [HttpGet]
        public IActionResult Details(int? id)
        {
            var product = _db.Products.Include(c => c.productTypes).Include(c => c.SpecialTag)
                .Where(p => p.Id == id).FirstOrDefault();
            if(product==null)
            {
               return NotFound();
            }
            return View(product);
        }
        //Post Product Details 
        [HttpPost]
        [ActionName("Details")]
        public IActionResult ProductDetail(int? Id)
        {
            List<Products> products = new List<Products>();
            if (Id==null)
            {
                return NotFound();
            }
            var product = _db.Products.Include(c => c.productTypes).Include(c => c.SpecialTag)
                .Where(p => p.Id == Id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            products = HttpContext.Session.Get<List<Products>>("products");
            if (products == null)
            {
                products = new List<Products>();
            }

            products.Add(product);
            HttpContext.Session.Set("products", products);
            return View(product);
        }

        [HttpGet]
        public IActionResult Remove(int? id)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if (products != null)
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                if (product != null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ActionName("Remove")]
        public IActionResult RemoveProduct(int ?id)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if(products!=null)
            {
                var product = products.FirstOrDefault(p => p.Id == id);
                if(product!=null)
                {
                    products.Remove(product);
                    HttpContext.Session.Set("products", products);
                }
            }
            return RedirectToAction("Index");
        }

        //Get ProductCard Action 
        [HttpGet]
        public IActionResult Cart()
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if(products==null)
            {
                products = new List<Products>();
            }
            return View(products);
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
