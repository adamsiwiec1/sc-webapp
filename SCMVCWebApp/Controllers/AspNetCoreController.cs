using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SCMVCWebApp.Models;
using SCMVCWebApp.Models.ApplicationUserModel;

namespace SCMVCWebApp.Controllers
{
    [AllowAnonymous]
    public class AspNetCoreController : Controller
    {
        private IApplicationUserRepo iAppUserRepo;
        public AspNetCoreController(IApplicationUserRepo appUserRepo)
        {
            iAppUserRepo = appUserRepo;
        }

        public IActionResult Welcome() 
        {
            return View();
        }

        public IActionResult Interactive() => View();
        public IActionResult Editions() => View();
        public IActionResult Faq() => View();
    }
}
