using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class BodyType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte BodyTypeId { get; set; }
        public string BodyTypeValue { get; set; }
    }
}