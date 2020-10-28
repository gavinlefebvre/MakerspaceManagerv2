using System.Reflection.Metadata.Ecma335;
using MakerspaceManager.Shared;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakerspaceManager.Server.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public enum PermitType
        {
            None,
            Blue,
            Red,
            Green,
            MPass
        }

        //[ForeignKey] -- tracks Jobs associated with User
        public ICollection<PrintTracker> UserPrintJobs { get; set; } = new List<PrintTracker>();

        //Temporary Auth Token
        //public string Token { get; set; }
        public ICollection<IdentityRole<Guid>> Roles { get; set; } = new List<IdentityRole<Guid>>();
        //User Attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LoginUserName { get; private set; }
        public Boolean ReceiveSMS { get; set; }
        //public RoleType Role { get; set; }
        public string College { get; set; }
        public PermitType Permit { get; set; }

        // this is already present in IdentityUser, skipping for now
        // public string PhoneNumber { get; set; }

        // private setter for LoginUserName
        public void SetLoginUserName(string username)
        {
            this.LoginUserName = username;
            this.UserName = username;
            this.Email = username;
        }
    }
}
