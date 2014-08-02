using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class UsedTrucksOrTrailersOption    
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte UsedTrucksOrTrailersOptionId { get; set; }
        public string UsedTrucksOrTrailersOptionText { get; set; }
        public virtual ICollection<Operator> Operators { get; set; }
    }
}