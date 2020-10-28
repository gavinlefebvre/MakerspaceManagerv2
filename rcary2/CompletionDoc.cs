using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace mysqlefcore
{
    public class CompletionDoc
    {
        //[Key]
        public int CompletionDocId { get; set; }

        //[ForeignKey]
        public int TaskDocId { get; set; }

        //[ForiegnKey("TaskForiegnKey")]
        public TaskDoc CompletionDocOwner { get; set; }

        public System.Boolean JobSuccess { get; set; }

        //VARCHAR(500)? How big should this be?
        public string ProblemText { get; set; }

        public System.DateTime PickedUp { get; set; }

        public int JobRating { get; set; }
    }
}