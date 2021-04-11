using Microsoft.AspNetCore.Mvc;
using SCMVCWebApp.Models;
using SCMVCWebApp.Models.ApplicationUserModel;
using SCMVCWebApp.Models.ConsultantModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Controllers
{
    public class ConsultantController : Controller
    {
        private IConsultantRepo iConsultantRepo;

        public ConsultantController(IConsultantRepo consultantRepo)
        {
            iConsultantRepo = consultantRepo;
        }

        public IActionResult ConsultantHome()
        {
            string userId = iConsultantRepo.FindLoggedInUser();
            Consultant consultant = iConsultantRepo.FindConsultant(userId);
            return View(consultant);
        }
    }
}
