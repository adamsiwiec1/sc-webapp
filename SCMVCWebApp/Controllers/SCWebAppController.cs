using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Controllers
{
    public class SCWebAppController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
