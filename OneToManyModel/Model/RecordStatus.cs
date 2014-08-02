using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class RecordStatus           
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte RecordStatusId { get; set; }
        public string RecordStatusValue { get; set; }
        public virtual ICollection<Operator> Operators { get; set; }
    }
}