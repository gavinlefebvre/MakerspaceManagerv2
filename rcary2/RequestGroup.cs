using System;
using System.Collections.Generic;
using System.Text;

namespace mysqlefcore
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

        public System.Boolean AdminApproved { get; set; }

        public ICollection<User> RequestUsers { get; set; }

    }
}