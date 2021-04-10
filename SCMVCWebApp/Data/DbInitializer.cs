using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SCMVCWebApp.Models;
using SCMVCWebApp.Models.ClientModel;
using SCMVCWebApp.Models.CompanyConsultant;
using SCMVCWebApp.Models.CompanyModel;
using SCMVCWebApp.Models.ConsultantModel;
using SCMVCWebApp.Models.ProjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Data
{
    public class DbInitializer
    {


        public static void Initialize(IServiceProvider services)
        {

            //#1 -- database service
            ApplicationDbContext database = services.GetRequiredService<ApplicationDbContext>();

            //#2 -- role service
            //startup.cs line 35 add --> .AddRoles<IdentityRole>()  (this is different from what we do next step, keep this)
            RoleManager<IdentityRole> roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            //#3 -- user service 
            //startup.cs line 34 change --> to ApplicationUser from IdentityUser (not where we added it in the prior step, but one line above)
            //_LoginPartial.cshtml change --> line 2 & 3 to ApplicationUser from IdentityUser
            UserManager<ApplicationUser> userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            string clientRole = "Client";
            string consultantRole = "Consultant";
            string administratorRole = "Administrator";

            if (!database.Roles.Any())
            {
                IdentityRole role = new IdentityRole(clientRole);
                roleManager.CreateAsync(role).Wait();
                //role manager creates AND saves, unlike db/user manager

                role = new IdentityRole(consultantRole);
                roleManager.CreateAsync(role).Wait();

                role = new IdentityRole(administratorRole);
                roleManager.CreateAsync(role).Wait();
            }

            //if (!database.Company.Any())
            //{
            //    Company company = new Company("Bob's Hardware Store", "Retail");
            //    database.Company.Add(company);
            //    database.SaveChanges();

            //    company = new Company("Kathy's Burgers Restuarant Chain", "Food");
            //    database.Company.Add(company);
            //    database.SaveChanges();
            //}

            if (!database.ApplicationUser.Any())
            {
                Client client = new Client("Bob", "Johnson", "123 CompanyA Street, Reston, VA 20148 ", "7034849777", "bob@companya.com", "CompanyAClient1!"); //"CEO", 1);
                userManager.CreateAsync(client).Wait();
                userManager.AddToRoleAsync(client, clientRole).Wait();

                client = new Client("Linda", "Thompson", "123 CompanyA Street, Reston, VA 20148 ", "7034849777", "linda@companya.com", "CompanyAClient2!"); //"IT Director", 1);
                userManager.CreateAsync(client).Wait();
                userManager.AddToRoleAsync(client, clientRole).Wait();


                Consultant consultant = new Consultant("Chase", "Letourneau", "123 Forest Glenn Drive, Ashburn, VA 20148", "7034849955", "chase@siwiectech.com", "ChaseIsCool123!", "Back End Development");
                userManager.CreateAsync(consultant).Wait();
                userManager.AddToRoleAsync(consultant, consultantRole).Wait();

                consultant = new Consultant("Adam", "Siwiec", "123 Forest Glenn Drive, Ashburn, VA 20148", "7034849955", "adam@siwiectech.com", "Sonny12345?", "Project Management and Solutions Architecture");
                userManager.CreateAsync(consultant).Wait();
                userManager.AddToRoleAsync(consultant, consultantRole).Wait();

                consultant = new Consultant("Cole", "Rogers", "123 No Grind Street, CouchTown, XBOX 20148 ", "7034849335", "cole@siwiectech.com", "ColeIsCool123!", "Hanging out with his girlfriend and failing the CCNA");
                userManager.CreateAsync(consultant).Wait();
                userManager.AddToRoleAsync(consultant, consultantRole).Wait();

                client = new Client("Ashok", "Mandadi", "123 CompanyB Street, Reston, VA 20148", "7034849777", "ashok@companyb.com", "CompanyBClient1!");
                userManager.CreateAsync(client).Wait();
                userManager.AddToRoleAsync(client, clientRole).Wait();

                ApplicationUser applicationUser = new ApplicationUser("SC", "Admin", "123 Admin Street, Admin, USA 70048", "3040000005", "scadmin@siwiectech.com", "SCAdmin123#!");
                applicationUser.EmailConfirmed = true;
                userManager.CreateAsync(applicationUser).Wait();
                userManager.AddToRoleAsync(applicationUser, administratorRole).Wait();

            }

            //if (!database.CompanyConsultant.Any())
            //{
            //    Consultant consultant = database.Consultant.Where(c => c.Email == "adam@siwiectech.com").FirstOrDefault();
            //    CompanyConsultant companyConsultant = new CompanyConsultant(consultant.Id, 1);
            //    database.CompanyConsultant.Add(companyConsultant);
            //    database.SaveChanges();

            //    consultant = database.Consultant.Where(c => c.Email == "chase@siwiectech.com").FirstOrDefault();
            //    companyConsultant = new CompanyConsultant(consultant.Id, 1);
            //    database.CompanyConsultant.Add(companyConsultant);
            //    database.SaveChanges();

            //    consultant = database.Consultant.Where(c => c.Email == "adam@siwiectech.com").FirstOrDefault();
            //    companyConsultant = new CompanyConsultant(consultant.Id, 2);
            //    database.CompanyConsultant.Add(companyConsultant);
            //    database.SaveChanges();

            //}
            if (!database.Project.Any())
            {
                Project project = new Project("Build an Online store to expand Bob's Customer Base"); //, 1);
                database.Project.Add(project);
                database.SaveChanges();

                project = new Project("Create a DBMS for inventory and sales"); //,  1);
                database.Project.Add(project);
                database.SaveChanges();

                project = new Project("Create a mobile application"); //,  1);
                database.Project.Add(project);
                database.SaveChanges();

                project = new Project("Mine data on competitors - ethically"); //,  1);
                database.Project.Add(project);
                database.SaveChanges();

                project = new Project("Build a responsive, clean webpage where customers can place their orders."); //,  2);
                database.Project.Add(project);
                database.SaveChanges();

                project = new Project("Create a profit/sucess matrix for all the stores and emphasize solutions where needed"); //,  2);
                database.Project.Add(project);
                database.SaveChanges();

                project = new Project("Mine data about the surrounding market. Where do people eat? - 'ethical' hacking involved"); //,  1);
                database.Project.Add(project);
                database.SaveChanges();

            }





        }
    }
}
