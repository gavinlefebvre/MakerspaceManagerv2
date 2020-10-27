namespace MakerspaceManager.Server.Models
{
    public class PrintTracker
    {
        public enum StatusType
        {
            Completed,
            Failed,
            Reprint,
            Pending
        }

        //Called JobId in Design, not PrintTrackerId
        //[Key]
        public int PrintTrackerId { get; set; }

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

    }

}
