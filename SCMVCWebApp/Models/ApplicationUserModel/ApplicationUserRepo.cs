using Microsoft.AspNetCore.Http;
using SCMVCWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ApplicationUserModel
{
    public class ApplicationUserRepo : IApplicationUserRepo
    {
        private ApplicationDbContext database;
        private IHttpContextAccessor httpContext;

        public ApplicationUserRepo(ApplicationDbContext applicationDbContext, IHttpContextAccessor contextAccesor)
        {
            this.database = applicationDbContext;
        }

        public string FindLoggedInUser()
        {
            return httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        public ApplicationUser FindAppUser(string studentId)
        {
            ApplicationUser appUser = database.ApplicationUser.Find(studentId);
            return appUser;
        }

        public List<ApplicationUser> ListAllUsers()
        {
            return database.ApplicationUser.ToList();
        }
    }
}
