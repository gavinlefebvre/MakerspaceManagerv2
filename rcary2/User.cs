using System;
using System.Collections.Generic;
using System.Text;

namespace mysqlefcore
{
    public class User
    {
        public enum RoleType
        {
            Owner,
            Staff,
            Student
        }

        public enum PermitType
        {
            Blue,
            Red,
            Green,
            MPass
        }

        //[Key]
        public int UserId { get; set; }

        //[ForeignKey] -- tracks Jobs associated with User
        //public PrintTracker UserPrintJobs { get; set; }
        public ICollection<PrintTracker> PrintTrackers { get; set; }

        //public ICollection<MachineTask> MachineTasks { get; set; }

        public RequestGroup UserRequestGroup { get; set; }

        //Temporary Auth Token
        public string Token { get; set; }

        //User Attributes
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNUmber { get; set; }
        public System.Boolean ReceiveSMS { get; set; }
        public RoleType Role { get; set; }
        public string College { get; set; }
        public PermitType Permit { get; set; }

    }
}