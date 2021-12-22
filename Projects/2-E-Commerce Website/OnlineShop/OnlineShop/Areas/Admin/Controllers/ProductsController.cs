using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OnlineShop.Models;
using OnlineShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class ProductsController : Controller
    {
        private ApplicationDbContext _db;
        //For Attach imgs to and from wwwroot (FileReader)
        private IHostingEnvironment _he;

        public ProductsController(ApplicationDbContext db, IHostingEnvironment he)
        {
            _db = db;
            _he = he;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(_db.Products.Include(c=>c.productTypes).Include(f=>f.SpecialTag).ToList());
        }
        [HttpPost]
        public IActionResult Index(decimal? lowAmount,decimal? largeAmount)
        {
            var products = _db.Products.Include(c => c.productTypes).Include(c => c.SpecialTag)
                           .Where(c => c.Price >= lowAmount && c.Price <= largeAmount).ToList();
            if(lowAmount==null||largeAmount==null)
            {
                products = _db.Products.Include(c => c.productTypes).Include(f => f.SpecialTag).ToList();
            }
            
            
            return View(products);
        }
        //Create Get Action Method
        [HttpGet]
        public IActionResult Create()
        {
            // for drop down Items in View
            ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(),"Id", "ProductType");
            ViewData["tagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "Name");
            return View();
        }
        //Create Post Action Method
        [HttpPost]
        public async Task<IActionResult> Create(Products product,IFormFile Image)
        {
            //Check the validation of Data annotation in class productTypes
            if (ModelState.IsValid)
            {
                var searchProduct = _db.Products.FirstOrDefault(p => p.Name == product.Name);
                if(searchProduct!=null)
                {
                    TempData["productIsExist"] = "This product Is Already Exist";
                    return RedirectToAction("Index");
                }
                else
                {
                    if (Image != null)
                    {
                        var name = Path.Combine(_he.WebRootPath + "/images", Path.GetFileName(Image.FileName));
                        await Image.CopyToAsync(new FileStream(name, FileMode.Create));
                        product.Image = "images/" + Image.FileName;
                    }
                    if (Image == null)
                    {
                        product.Image = "images/noimage.png";
                    }
                    _db.Products.Add(product);
                    await _db.SaveChangesAsync();
                    TempData["save"] = "Product  has been successfully saved";
                    return RedirectToAction(actionName: nameof(Index));
                }

               
            }
            return View(product);

        }
        //Edit Get Action Method
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            // for drop down Items in View
            ViewData["productTypeId"] = new SelectList(_db.ProductTypes.ToList(), "Id", "ProductType");
            ViewData["tagId"] = new SelectList(_db.SpecialTags.ToList(), "Id", "Name");
            return View(_db.Products.Find(id));
        }
        //Edit Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Products Product, IFormFile Image)
        {

            //Check the validation of Data annotation in class productTypes
            if (ModelState.IsValid)
            {
                if (Image != null)
                {
                    var name = Path.Combine(_he.WebRootPath + "/images", Path.GetFileName(Image.FileName));
                    await Image.CopyToAsync(new FileStream(name, FileMode.Create));
                    Product.Image = "images/" + Image.FileName;
                }
                if (Image == null)
                {
                    Product.Image = "images/noimage.png";
                }
                _db.Update(Product);
                await _db.SaveChangesAsync();
                TempData["ediit"] = "Product  has been successfully Edited";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(Product);

        }
        //Details Get Action Method
        [HttpGet]
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = _db.Products.Where(p=>p.Id==id).Include(t=>t.productTypes).Include(r=>r.SpecialTag).FirstOrDefault();

            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //Details Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Details(Products product)
        {
            return RedirectToAction(nameof(Edit),product);
        }
        //Delete Get Action Method
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            var product = _db.Products.Where(p=>p.Id==id).Include(t=>t.productTypes).Include(s=>s.SpecialTag).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        //Delete Post Action Method
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int? id, Products product)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (id != product.Id)
            {
                return NotFound();
            }
            
            var productt = _db.Products.Find(id);
            if (productt == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _db.Remove(productt);
                await _db.SaveChangesAsync();
                TempData["del"] = "Product  has been successfully Deleted";
                return RedirectToAction(actionName: nameof(Index));
            }
            return View(productt);

        }


    }
}
