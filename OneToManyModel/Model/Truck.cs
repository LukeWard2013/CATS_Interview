
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class Truck
    {
        [Key]
        public int TruckId { get; set; }

        public int OperatorId { get; set; }

        public byte WeightValueId { get; set; }

        [Required]
        [Range(0, 9999, ErrorMessage = "A vehicle count must be a number between 0 and 9999")]
        [RegularExpression("[0-9]+", ErrorMessage="A vehicle count must be a number between 0 and 9999")]
        public virtual int Count { get; set; }

        [ForeignKey("OperatorId")]

        public virtual Operator Operator { get; set; }

        public virtual TruckWeight TruckWeight { get; set; }

        public virtual ICollection<Body> Bodies { get; set; }

        public virtual ICollection<Chassis> Chassis { get; set; } 
    }
}