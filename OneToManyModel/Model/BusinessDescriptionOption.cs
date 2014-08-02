using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class BusinessDescriptionOption          
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte BusinessDescriptionOptionId { get; set; }
        public string BusinessDescriptionOptionText { get; set; }
        public virtual ICollection<Operator> Operators { get; set; }
    }
}