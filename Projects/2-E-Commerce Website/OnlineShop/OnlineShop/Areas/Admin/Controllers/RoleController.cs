using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using OnlineShop.Data;
using OnlineShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]
    public class RoleController : Controller
    {
        private readonly  RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
        ApplicationDbContext _db;

        public RoleController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();
            ViewBag.Roles = roles;
            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(string name)
        {
            IdentityRole role = new IdentityRole();
            role.Name = name;
            var isExist = await _roleManager.RoleExistsAsync(role.Name);
            if (isExist)
            {
                ViewBag.mgs = "This role is aldeady exist";
                ViewBag.name = name;
                return View();
            }
            var result = await _roleManager.CreateAsync(role);
            if (result.Succeeded)
            {
                TempData["save"] = "Role has been saved successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Edit(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            ViewBag.id = role.Id;
            ViewBag.name = role.Name;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, string name)
        {

            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            role.Name = name;
            var isExist = await _roleManager.RoleExistsAsync(role.Name);
            if (isExist)
            {
                ViewBag.mgs = "This role is aldeady exist";
                ViewBag.name = name;
                return View();
            }
            var result = await _roleManager.UpdateAsync(role);
            if (result.Succeeded)
            {
                TempData["save"] = "Role has been updated successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public async Task<IActionResult> Delete(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }
            ViewBag.id = role.Id;
            ViewBag.name = role.Name;
            return View();
        }

        [HttpPost]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);
            if (role == null)
            {
                return NotFound();
            }

            var result = await _roleManager.DeleteAsync(role);
            if (result.Succeeded)
            {
                TempData["delete"] = "Role has been deleted successfully";
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        public async Task<IActionResult> Assign()
        {
            var users = _userManager.Users.ToList();
            ViewData["userId"] = new SelectList(users.Where(f => f.LockoutEnd <(DateTimeOffset) DateTime.Now || f.LockoutEnd == null).ToList(), "Id", "UserName");
            ViewData["roleId"] = new SelectList(_roleManager.Roles.ToList(), "Name", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Assign(roleUserViewModel roleUser,string userId,string roleId)
        {
            //var user = _db.ApplicationUsers.FirstOrDefault(c => c.Id == roleUser.UserId);
            var user = await _userManager.FindByIdAsync(userId);
            var isCheckRoleAssign = await _userManager.IsInRoleAsync(user, roleId);
            if (isCheckRoleAssign)
            {
                ViewBag.mgs = "This user already assign this role.";
                var users = _userManager.Users.ToList();
                ViewData["UserId"] = new SelectList(users.Where(f => f.LockoutEnd < (DateTimeOffset)DateTime.Now || f.LockoutEnd == null).ToList(), "Id", "UserName");
                ViewData["roleId"] = new SelectList(_roleManager.Roles.ToList(), "Name", "Name");
                return View();
            }
            else
            {
                //First Remove Old Role of this user 
                var oldUserRole = _db.UserRoles.Where(u => u.UserId == userId).FirstOrDefault();
                if (oldUserRole != null)
                {
                    var roleName = _roleManager.Roles.Where(r => r.Id == oldUserRole.RoleId).FirstOrDefault();
                    await _userManager.RemoveFromRoleAsync(user, roleName.Name);
                   
                }
               //Then add New Role To this user 
                var role = await _userManager.AddToRoleAsync(user, roleId);
                if (role.Succeeded)
                {
                    TempData["save"] = "User Role assigned.";
                    return RedirectToAction(nameof(AssignUserRole));
                }
            }
           
            return View();
        }
        public ActionResult AssignUserRole()
        {
            var result = from ur in _db.UserRoles
                         join r in _db.Roles on ur.RoleId equals r.Id
                         join a in _userManager.Users on ur.UserId equals a.Id
                         select new UserRoleMapingViewModel()
                         {
                             UserId = ur.UserId,
                             RoleId = ur.RoleId,
                             UserName = a.UserName,
                             RoleName = r.Name
                         };
            ViewBag.UserRoles = result;
            return View();
        }






    }
}
