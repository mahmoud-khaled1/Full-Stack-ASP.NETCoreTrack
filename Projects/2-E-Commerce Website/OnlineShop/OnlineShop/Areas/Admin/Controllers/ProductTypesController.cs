using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    // if you did't log in you can't access any action so will move you to login page first to log in
    [Authorize]
    public class ProductTypesController : Controller
    {
        ApplicationDbContext _db;

        public ProductTypesController(ApplicationDbContext db)
        {
            _db = db;
        }
        //Show all Product Type
        // anyone can access this action 
        //[AllowAnonymous]
        public IActionResult Index()
        {
            return View(_db.ProductTypes.ToList());
        }
        
        // if you did't login when you click on this button will move you to login page first to log in
        [Authorize] 
        [HttpGet]
        //Create Get Action Method
        public IActionResult Create()
        {
            return View();
        }
        //Create Post Action Method
        [HttpPost]
        
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductTypes productTypes)
        {
            //Check the validation of Data annotation in class productTypes
            if (ModelState.IsValid)
            {
                _db.ProductTypes.Add(productTypes);
                await _db.SaveChangesAsync();
                TempData["save"] = "Product Type has been successfully saved";
                return RedirectToAction(actionName:nameof(Index));
            }
            return View(productTypes);
                
        }
        //Edit Get Action Method
        [HttpGet]
        
        public IActionResult Edit(int ? id)
        {
            if(id==null)
            {
                return NotFound();
            }
            //var productType = _db.ProductTypes.Where(p => p.Id == id);
            var productType = _db.ProductTypes.Find(id);
            if(productType==null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ProductTypes productTypes)
        {
            //Check the validation of Data annotation in class productTypes
            if (ModelState.IsValid)
            {
                _db.Update(productTypes);
                await _db.SaveChangesAsync();
                TempData["ediit"] = "Product Type has been successfully Edited";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(productTypes);

        }
        //Details Get Action Method
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //var productType = _db.ProductTypes.Where(p => p.Id == id);
            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Details Post Action Method
        [HttpPost]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(ProductTypes productTypes)
        {
            return RedirectToAction(nameof(Index));
        }

        //Delete Get Action Method
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //var productType = _db.ProductTypes.Where(p => p.Id == id);
            var productType = _db.ProductTypes.Find(id);
            if (productType == null)
            {
                return NotFound();
            }
            return View(productType);
        }
        //Delete Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id,ProductTypes productTypes)
        {
            if (id == null)
            {
                return NotFound();
            }
            if(id!=productTypes.Id)
            {
                return NotFound();
            }
            //var productType = _db.ProductTypes.Where(p => p.Id == id);
            var productType = _db.ProductTypes.Find(id);
            if(productType==null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(productType);
                await _db.SaveChangesAsync();
                TempData["del"] = "Product Type has been successfully Deleted";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(productTypes);

        }
    }
}
