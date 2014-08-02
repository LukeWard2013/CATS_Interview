using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class Body
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BodyId { get; set; }
        public int TruckId { get; set; }

        public byte BodyTypeId { get; set; }
        public virtual Truck Truck { get; set; }

        //Foreign key will be inferred Body.BodyTypeId = BodyType.BodyTypeId so attribute not needed
        //[ForeignKey("BodyTypeId")]
        public virtual BodyType BodyType { get; set; }
    }
}