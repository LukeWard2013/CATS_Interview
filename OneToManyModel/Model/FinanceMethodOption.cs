using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class FinanceMethodOption
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte FinanceMethodOptionId { get; set; }
        public string FinanceMethodOptionText { get; set; }
    }
}