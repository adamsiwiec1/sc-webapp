using Microsoft.AspNetCore.Http;
using SCMVCWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ApplicationUserModel
{
    public class ApplicationUserRepo
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

        public List<ApplicationUser> ListAllUsers()
        {
            return database.ApplicationUser.ToList();
        }
    }
}
