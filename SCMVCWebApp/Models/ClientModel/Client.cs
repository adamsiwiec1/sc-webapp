using SCMVCWebApp.Models.CompanyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ClientModel
{
    public class Client : ApplicationUser
    {

        //[Required]
        //public int CompanyID { get; set; }

        //[Required]
        //public string Position { get; set; } // CEO, IT director... etc...

        //[ForeignKey("CompanyID")]
        //public Company WorksAtCompany { get; set; }


        public Client(string firstname, string lastname, string address, string phoneNumber, string email, string password /*, string position, int  companyID*/) :
            base(firstname, lastname, address,phoneNumber, email, password)
        {
            //Position = position;
            //CompanyID = companyID;
        }
        public Client()
        {

        }
    }
}
