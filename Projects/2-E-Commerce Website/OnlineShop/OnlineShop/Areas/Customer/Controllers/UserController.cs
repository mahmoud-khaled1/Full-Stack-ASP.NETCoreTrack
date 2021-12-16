using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
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

        public IActionResult Index()
        {
            return View();
        }
        
        //[HttpGet]
        //public async Task<IActionResult> Create()
        //{
        //    return View();
        //}
        //[HttpPost]
        //public async Task<IActionResult> Create(UserManager user)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var result = await _userManager.CreateAsync(user, user.PasswordHash);


        //        //create roles  and assign them to database for users .
        //        string[] roleNames = { "Admin", "User" };
        //        IdentityResult roleResult;

        //        foreach (var roleName in roleNames)
        //        {
        //            var roleExist = await _roleManager.RoleExistsAsync(roleName);
        //            if (!roleExist)
        //            {
        //                //create the roles and seed them to the database: 
        //                roleResult = await _roleManager.CreateAsync(new IdentityRole(roleName));
        //            }
        //        }
        //        if (result.Succeeded)
        //        {
        //            //var isSaveRole = await _userManager.AddToRoleAsync(user, "User");
        //            var isSaveRole = await _userManager.AddToRoleAsync(user, "User");
        //            TempData["save"] = "User has been created successfully";
        //            return RedirectToAction(nameof(Index));
        //        }
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState. AddModelError(string.Empty, error.Description);
        //        }
        //    }
        //    return View();
        //}



    }
}
