using System;

namespace MakerspaceManager.Server.Models
{
    public class MachineTask
    {
        public int MachineTaskId { get; set; }

        //[ForeignKey]
        public int JobId { get; set; }

        //[ForeignKey] -- Assigned on creation
        public int TaskDocId { get; set; }

        //Machine [Requried]
        public Machine AssignedMachine {get; set; }

        public DateTime BeginTime { get; set; }

        public DateTime EndTime { get; set; }

        public ApplicationUser SlicedBy { get; set; }

        public ApplicationUser LoadedBy { get; set; }

        public ApplicationUser RemovedByBy { get; set; }

        public Boolean IsApproved { get; set; }
        
        public string Filename { get; set; }

    }
}