using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CATS_Interview.Model
{
    public class CallOutcome
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public byte CallOutcomeId { get; set; }
        public string CallOutcomeText { get; set; }
    }
}