namespace MakerspaceManager.Server.Models
{
    public class TaskDoc
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
    }
}