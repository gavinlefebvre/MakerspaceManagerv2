using System;
using System.Collections.Generic;
using System.Text;

namespace mysqlefcore
{
    public class PrintTracker
    {
        public enum StatusType
        {
            Completed,
            Failed,
            Reprint
        }

        //Called JobId in Design, not PrintTrackerId
        public int PrintTrackerId { get; set; }

        //[Key]
        //public int JobId { get; set; }

        public User JobOwner { get; set; }

        public int UserId { get; set; }

        public StatusType JobStatus { get; set; }

        public string Description { get; set; }

        //This will be a time or datetime, but need to figure out annotations first
        public string EstPrintTime { get; set; }


        public int MaterialAmt { get; set; }

        //Might be a float, might be text
        public string Cost { get; set; }

        //Storing URL of slice file here
        public string SliceFile { get; set; }

        //[ForiegnKey]
        public int RequestGroupId { get; set; }
        //public ICollection<RequestGroup> RequestGroups { get; set; }

        public ICollection<MachineTask> MachineTasks { get; set; }

        //public ICollection<PrintMaterial> JobPrintMaterials { get; set; }
        

    }

/*         public class RequestGroup
    {
        public enum GroupType 
        {
            Research,
            StudentOrg,
            Class,
            Personal,
            Makers
        }
        
        //[Key]
        public int RequestGroupId { get; set; }
        
        public GroupType RequestingGroup { get; set; }
        
        public string GroupName { get; set; }

        public System.Boolean AdminApproved { get; set; }

    } */

}
