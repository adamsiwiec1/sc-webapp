using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ApplicationUserModel
{
    public interface IApplicationUserRepo
    {
        string FindLoggedInUser();
        List<ApplicationUser> ListAllUsers();

    }
}
