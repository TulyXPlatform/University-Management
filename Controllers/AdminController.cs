using ContosoUniversity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Identity.Owin;
using System.Web;
using System.Web.Mvc;

namespace ContosoUniversity.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private UserManager<ApplicationUser> userManager;
        private RoleManager<IdentityRole> roleManager;

        public AdminController()
        {
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db)); // FIXED

        }

        public ActionResult ManageRoles()
        {
            var users = db.Users.ToList();
            var roles = db.Roles.ToList();
            ViewBag.Roles = roles;
            return View(users);
        }

        [HttpPost]
        public ActionResult UpdateRole(string userId, string roleName)
        {
            var user = userManager.FindById(userId);
            if (user == null)
                return HttpNotFound();

            // Remove all previous roles
            var currentRoles = userManager.GetRoles(user.Id);
            userManager.RemoveFromRoles(user.Id, currentRoles.ToArray());

            

            // Add new role
            if (!roleManager.RoleExists(roleName))
                roleManager.Create(new IdentityRole(roleName)); // auto-create if missing

            // Assign new role
            userManager.AddToRole(user.Id, roleName);

            return RedirectToAction("ManageRoles");
        }
    }

}