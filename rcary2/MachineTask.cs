using System;
using System.Collections.Generic;
using System.Text;

namespace mysqlefcore
{
    public class MachineTask
    {
        public int MachineTaskId { get; set; }

        //[ForeignKey]
        public int JobId { get; set; }

        public int TrackerForeignKey { get; set; }
        public PrintTracker TrackerOwner { get; set; }

        //[ForeignKey] -- Assigned on creation
        public TaskDoc OwnedTaskDoc { get; set; }

        public CompletionDoc OwnedCompletionDoc { get; set; }

        //Machine [Requried]
        public Machine AssignedMachine {get; set; }

        public System.DateTime BeginTime { get; set; }

        public System.DateTime EndTime { get; set; }

        public User SlicedBy { get; set; }

        public User LoadedBy { get; set; }

        public User RemovedBy { get; set; }

        public System.Boolean Approved { get; set; }
        
        public string Filename { get; set; }

    }

/*         public class TaskDoc
    {
        //[Key]
        public int TaskDocId { get; set; }

        public System.Boolean AdminApproved { get; set; }

        //VARCHAR -- Should this be an enum??
        public string FailureType { get; set; }

        public System.Boolean FailureFlag { get; set; }

        public System.Boolean ReprintFlag { get; set; }

        //Planning to store URL here
        public string FailurePic { get; set; }
    } */

/*         public class CompletionDoc
    {
        //[Key]
        public int CompletionDocId { get; set; }

        public System.Boolean JobSuccess { get; set; }

        //VARCHAR(500)? How big should this be?
        public string ProblemText { get; set; }

        public System.DateTime PickedUp { get; set; }

        public int JobRating { get; set; }
    } */
}