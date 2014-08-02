using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class ChassisMakeByWeight
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Id { get; set; }
        public byte ChassisMakeValueId { get; set; }
        public byte WeightValueId { get; set; }

        public virtual TruckWeight TruckWeight { get; set; }
        public virtual ChassisMake ChassisMake { get; set; }
    }
}