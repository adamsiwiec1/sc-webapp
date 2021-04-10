using SCMVCWebApp.Models.CompanyModel;
using SCMVCWebApp.Models.ConsultantModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models.CompanyConsultant
{
    public class CompanyConsultant
    {
        [Key]
        public int CompanyConsultantID { get; set; }

        [Required]
        public string ConsultantId { get; set; }

        [Required]
        public int CompanyID { get; set; }

        [ForeignKey("ConsultantId")]
        public Consultant ConsultantReference { get; set; }

        [ForeignKey("CompanyID")]
        public Company CompanyReference { get; set; }

        public CompanyConsultant(string consultantId, int companyID)
        {
            this.ConsultantId = consultantId;
            this.CompanyID = companyID;
        }

    }
}
