using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class WorkshopOption   
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte WorkshopOptionId { get; set; }
        public string WorkshopOptionText { get; set; }
        public virtual ICollection<Operator> Operators { get; set; }
    }
}