using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SCMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Data
{
    public class DbInitializer
    {


        public static void Initialize(IServiceProvider services)
        {

            ////#1 -- database service
            //ApplicationDbContext database = services.GetRequiredService<ApplicationDbContext>();

            ////#2 -- role service
            ////startup.cs line 35 add --> .AddRoles<IdentityRole>()  (this is different from what we do next step, keep this)
            //RoleManager<IdentityRole> roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            ////#3 -- user service 
            ////startup.cs line 34 change --> to ApplicationUser from IdentityUser (not where we added it in the prior step, but one line above)
            ////_LoginPartial.cshtml change --> line 2 & 3 to ApplicationUser from IdentityUser
            //UserManager<ApplicationUser> userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            //string studentRole = "Student";
            //string tutorRole = "Tutor";
            //string administratorRole = "Administrator";

            //if (!database.Roles.Any())
            //{
            //    IdentityRole role = new IdentityRole(studentRole);
            //    roleManager.CreateAsync(role).Wait();
            //    //role manager creates AND saves, unlike db/user manager

            //    role = new IdentityRole(tutorRole);
            //    roleManager.CreateAsync(role).Wait();

            //    role = new IdentityRole(administratorRole);
            //    roleManager.CreateAsync(role).Wait();
            //}
        }
    }
}
