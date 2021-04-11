using SCMVCWebApp.Models.CompanyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.ProjectModel
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        
        [Required]
        public string ProjectName { get; set; }

        [Required]
        public int CompanyID { get; set; }

        [ForeignKey("CompanyID")]
        public Company ForCompany { get; set; }

        public Project(string projectName, int companyID)
        {
            this.ProjectName = projectName;
            this.CompanyID = companyID;

        }
        public Project()
        {

        }
    }
}
