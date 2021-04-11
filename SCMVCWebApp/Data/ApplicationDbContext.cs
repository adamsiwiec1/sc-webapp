using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using SCMVCWebApp.Models.ClientModel;
using SCMVCWebApp.Models.CompanyConsultant;
using SCMVCWebApp.Models.CompanyModel;
using SCMVCWebApp.Models.ConsultantModel;
using SCMVCWebApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SCMVCWebApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ApplicationUser> ApplicationUser { get; set; }

        public DbSet<Client> Client { get; set; }

        public DbSet<Consultant> Consultant { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Models.ProjectModel.Project> Project { get; set; } // Spent like 1 hour trying to figure out this migration error, lol. Stupid Visual studio..... not my fault.....

        public DbSet<CompanyConsultant> CompanyConsultant { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
