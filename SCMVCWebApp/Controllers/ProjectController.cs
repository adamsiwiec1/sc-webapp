using Microsoft.AspNetCore.Mvc;
using SCMVCWebApp.Data;
using SCMVCWebApp.Models.ProjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Controllers
{
    public class ProjectController : Controller
    {

        private ApplicationDbContext database;

        private IProjectRepo iProjectRepo;

        //Dependency Injection 
        public ProjectController(ApplicationDbContext dbContext, IProjectRepo projectRepo)
        {
            database = dbContext;
            iProjectRepo = projectRepo;
        }

        public IActionResult ListAllProjects()
        {
            List<Project> projects = iProjectRepo.ListAllProjects();

            //foreach(Project x in projects)
            //{
            //    x.ForCompany = iCompanyRepo.FindCompany(x.CompanyID);
            //}


            return View(projects);
        }


    }
}
