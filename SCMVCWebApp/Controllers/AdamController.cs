using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Controllers
{
    public class AdamController : Controller
    {

        public AdamController()
        {

        }

        public IActionResult PeekLayout()
        {
            return View();
        }

        

    }
}
