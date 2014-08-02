using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class ChassisMake
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte ChassisMakeId { get; set; }
        public string ChassisMakeValue { get; set; }
    }
}