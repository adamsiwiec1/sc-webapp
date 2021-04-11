using SCMVCWebApp.Models.ClientModel;
using SCMVCWebApp.Models.ConsultantModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.CompanyModel
{
    public class Company
    {
        [Key]
        public int CompanyID { get; set; }

        [Required(ErrorMessage = "Please enter a company name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a company category.")] //Eventually want to make this another table we track data for
        public string Category { get; set; }

        public List<Client> ClientAtCompany { get; set; }

        public List<Consultant> ConsultantsWorkingCompany { get; set; }

        public Company(string companyName, string category)
        {
            this.Name = companyName;
            this.Category = category;
            this.ClientAtCompany = new List<Client>();
            this.ConsultantsWorkingCompany = new List<Consultant>();
        }


        public Company() { }
    }
}
