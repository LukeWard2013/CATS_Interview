using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class Chassis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ChassisId { get; set; }
        public int TruckId { get; set; }

        public byte ChassisMakeId { get; set; }

        public virtual Truck Truck { get; set; }

        public virtual ChassisMake ChassisMake { get; set; }
    }
}