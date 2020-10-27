using System;

namespace MakerspaceManager.Server.Models
{
    public class RequestGroup
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

        public Boolean AdminApproved { get; set; }

    }
}