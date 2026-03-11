using ContosoUniversity.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContosoUniversity.Startup))]
namespace ContosoUniversity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndAdminUser();
        }

        private void CreateRolesAndAdminUser()
        {
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));

            string[] roleNames = { "Admin", "Teacher", "Student" };

            foreach (var role in roleNames)
            {
                if (!roleManager.RoleExists(role))
                    roleManager.Create(new IdentityRole(role));
            }

            if (userManager.FindByEmail("admin@university.com") == null)
            {
                var adminUser = new ApplicationUser
                {
                    UserName = "admin@university.com",
                    Email = "admin@university.com",
                    
                };

                string adminPassword = "Admin@123";
                var createAdmin = userManager.Create(adminUser, adminPassword);

                if (createAdmin.Succeeded)
                {
                    userManager.AddToRole(adminUser.Id, "Admin");
                }
            }

        }

    }
}
