using SCMVCWebApp.Models.CompanyModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ConsultantModel
{
    public class Consultant : ApplicationUser
    {

        public string Specialization { get; set; }

        //public List<Company> CompaniesResponsibleFor { get; set; }

        public Consultant(string firstname, string lastname, string address, string phoneNumber, string email, string password, string specialization) :
            base(firstname, lastname, address, phoneNumber, email, password)
        {
            this.Specialization = specialization;
            //this.CompaniesResponsibleFor = new List<Company>();
        }

        public Consultant()
        {

        }
    }
}
