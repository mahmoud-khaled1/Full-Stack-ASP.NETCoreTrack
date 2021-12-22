using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using OnlineShop.Data;
using OnlineShop.Models;
using OnlineShop.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private readonly ILogger<OrderController> _logger;
        private readonly ApplicationDbContext _db;

        public OrderController(ILogger<OrderController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        //Get Checkout action method
        [HttpGet]
        public IActionResult Checkout()
        {
            return View();
        }
        //Post Checkout method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Checkout(Order order)
        {
            List<Products> products = HttpContext.Session.Get<List<Products>>("products");
            if(products!=null)
            {
                order.OrderDetails = new List<OrderDetails>();
                foreach (var item in products)
                {
                    OrderDetails orderdetails = new OrderDetails();
                    orderdetails.PorductId = item.Id;
                    order.OrderDetails.Add(orderdetails);
                }
            }
           
            order.OrderNo = GetOrderNo();
            order.OrderDate = DateTime.Now;
            _db.Orders.Add(order);
            await _db.SaveChangesAsync();
            HttpContext.Session.Set("products", new List<Products>());
            return RedirectToAction("Index","Home");
        }
        public string GetOrderNo()
        {
            int cnt = _db.Orders.ToList().Count() + 1;
            return cnt.ToString("000");
        }
    }
}
