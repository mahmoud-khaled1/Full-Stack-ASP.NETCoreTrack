using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _db;
        public UsersController(UserManager<IdentityUser> userManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }

        public IActionResult Index()
        {
            //var dd = _userManager.GetUserId(HttpContext.User);
            var users = _userManager.Users.ToList();
            
            List<userViewModel> userVM = new List<userViewModel>();
            foreach (var item in users)
            {
                userViewModel u = new userViewModel();
                u.Email = item.Email;
                u.id = item.Id;
                u.Phone = item.PhoneNumber;
                if (item.LockoutEnd != null)
                      u.lockoutDate =(DateTimeOffset) item.LockoutEnd;
                
                userVM.Add(u);
            }
            

            return View(userVM);
        }
        public async Task<IActionResult> Lockout(userViewModel user)
        {
            //var userInfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);
            var userInfo = _userManager.Users.FirstOrDefault(c => c.Id == user.id);
            if (userInfo == null)
            {
                return NotFound();

            }
            //set time of lockout
            userInfo.LockoutEnd = DateTime.Now.AddYears(100);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                TempData["save"] = "User has been lockout successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }

        public async Task<IActionResult> Active(userViewModel user)
        {
            //var userInfo = _db.ApplicationUsers.FirstOrDefault(c => c.Id == user.Id);
            var userInfo = _userManager.Users.FirstOrDefault(c => c.Id == user.id);
            if (userInfo == null)
            {
                return NotFound();

            }
            userInfo.LockoutEnd = DateTime.Now.AddDays(-1);
            int rowAffected = _db.SaveChanges();
            if (rowAffected > 0)
            {
                TempData["save"] = "User has been active successfully";
                return RedirectToAction(nameof(Index));
            }
            return View(userInfo);
        }





    }
}
