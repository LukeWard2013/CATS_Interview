

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class TruckWeight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte WeightValueId { get; set; }
        public string WeightValue { get; set; }

        [ForeignKey("WeightValueId")]
        public virtual ICollection<Truck> Trucks { get; set; } 
    }
}