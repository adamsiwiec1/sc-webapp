using Microsoft.AspNetCore.Mvc;
using SCMVCWebApp.Models;
using SCMVCWebApp.Models.ApplicationUserModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Controllers
{
    public class AppUserController : Controller
    {
        private IApplicationUserRepo iAppUserRepo;

        public AppUserController(IApplicationUserRepo appUserRepo)
        {
            iAppUserRepo = appUserRepo;
        }

        public IActionResult AdminHome()
        {
            string userId = iAppUserRepo.FindLoggedInUser();
            ApplicationUser appUser = iAppUserRepo.FindAppUser(userId);
            return View(appUser);
        }




    }
}
