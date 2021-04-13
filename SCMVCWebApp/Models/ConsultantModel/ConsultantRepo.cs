using Microsoft.AspNetCore.Http;
using SCMVCWebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ConsultantModel
{
    public class ConsultantRepo : IConsultantRepo
    {
        private ApplicationDbContext database;
        private IHttpContextAccessor httpContext;

        public ConsultantRepo(ApplicationDbContext applicationDbContext, IHttpContextAccessor contextAccesor)
        {
            this.database = applicationDbContext;
        }

        public string FindLoggedInUser()
        {
            return httpContext.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
        }

        public Consultant FindConsultant(string consultantId)
        {
            Consultant consultant = database.Consultant.Find(consultantId);
            return consultant;
        }

        public List<Consultant> ListAllConsultants()
        {
            return database.Consultant.ToList();
        }

    }
}
