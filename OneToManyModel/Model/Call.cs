using System;

namespace CATS_Interview.Model
{
    public class Call
    {
        public int CallId { get; set; }
        public int OperatorId { get; set; }
        public DateTime? CallBackDate { get; set; }
        public string Operative { get; set; }
        public DateTime InterviewStart { get; set; }
        public DateTime InterviewEnd { get; set; }
        public string Notes { get; set; }
        public bool? CurrentCall { get; set; }

        public byte CallOutcomeId { get; set; }
        public virtual CallOutcome CallOutcome { get; set; }
    }
}