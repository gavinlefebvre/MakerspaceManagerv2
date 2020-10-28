using System;
using System.Collections.Generic;
using System.Text;

namespace mysqlefcore
{
    public class TaskDoc
    {
        //[Key]
        public int TaskDocId { get; set; }

        //public PrintTracker TrackerOwner { get; set; }

        public MachineTask MachineTaskOwner { get; set; }

        //public int CompletionDocId { get; set; }

        public CompletionDoc TaskCompletionDoc { get; set; }

        public System.Boolean AdminApproved { get; set; }

        //VARCHAR -- Should this be an enum??
        public string FailureType { get; set; }

        public System.Boolean FailureFlag { get; set; }

        public System.Boolean ReprintFlag { get; set; }

        //Planning to store URL here
        public string FailurePic { get; set; }
    }
}