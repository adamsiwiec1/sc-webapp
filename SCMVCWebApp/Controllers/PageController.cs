using Microsoft.AspNetCore.Mvc;
using SCMVCWebApp.Data;
using SCMVCWebApp.Models;
using SCMVCWebApp.Models.ApplicationUserModel;

namespace SCMVCWebApp.Controllers
{
    public class PageController : Controller
    {
        private IApplicationUserRepo iAppUserRepo;
        private ApplicationDbContext database;
        public PageController(IApplicationUserRepo appUserRepo, ApplicationDbContext dbContext)
        {
            database = dbContext;
            iAppUserRepo = appUserRepo;
        }

        public IActionResult Chat() => View();
        public IActionResult Confirmation() => View();
        public IActionResult Contacts() => View();
        public IActionResult Error() => View();
        public IActionResult Error404() => View();
        public IActionResult ErrorAnnounced() => View();
        public IActionResult Forget() => View();
        public IActionResult ForumDiscussion() => View();
        public IActionResult ForumList() => View();
        public IActionResult ForumThreads() => View();
        public IActionResult InboxGeneral() => View();
        public IActionResult InboxRead() => View();
        public IActionResult InboxWrite() => View();
        public IActionResult Invoice() => View();
        public IActionResult AccountSettings() => View();
        public IActionResult Locked()
        {
            if (User.Identity.IsAuthenticated)
            {
                string userId = iAppUserRepo.FindLoggedInUser();
                ApplicationUser appUser = iAppUserRepo.FindAppUser(userId);
                return View(appUser);
            }
            else
            { return View(); }

        }

        public IActionResult Login() => View();
        public IActionResult LoginAlt() => View();
        public IActionResult Profile()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            //    string userId = iAppUserRepo.FindLoggedInUser();
            //    ApplicationUser appUser = iAppUserRepo.FindAppUser(userId);
            //    return View(appUser);
            //}
            //else
            //{ return View(); }
            return View();
        }
        public IActionResult Projects() => View();
        public IActionResult Register() => View();
        public IActionResult Search() => View();
    }
}
