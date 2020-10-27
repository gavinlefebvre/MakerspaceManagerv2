using System;

namespace MakerspaceManager.Server.Models
{
    public class CompletionDoc
    {
        //[Key]
        public int CompletionDocId { get; set; }

        public Boolean JobSuccess { get; set; }

        //VARCHAR(500)? How big should this be?
        public string ProblemText { get; set; }

        public DateTime PickedUp { get; set; }

        public int JobRating { get; set; }
    }
}