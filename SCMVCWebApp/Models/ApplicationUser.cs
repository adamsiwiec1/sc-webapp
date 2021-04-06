using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SCMVCWebApp.Models
{
    public class ApplicationUser : IdentityUser
    {
        //No need for prim key/id bcuz it is inherited from IdentityUser


        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string FullName { get; set; }

        [Required]
        public string Address { get; set; }



        public ApplicationUser(string firstname, string lastname, string address, string phoneNumber, string email, string password, int majorID)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.FullName = firstname + " " + lastname;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.UserName = email;
            //this statement below enables password hashing
            PasswordHasher<ApplicationUser> passwordHasher = new PasswordHasher<ApplicationUser>();
            this.PasswordHash = passwordHasher.HashPassword(this, password);
            //this creates a new GUID for SecurityStamp
            this.SecurityStamp = Guid.NewGuid().ToString();
        }

        public ApplicationUser() { } 
    }
}
