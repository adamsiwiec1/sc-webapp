using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ConsultantModel
{
    public interface IConsultantRepo
    {
        string FindLoggedInUser();
        List<Consultant> ListAllConsultants();
        Consultant FindConsultant(string userId);

    }
}
