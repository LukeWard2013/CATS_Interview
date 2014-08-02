using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class FinanceMethod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FinanceMethodId { get; set; }
        public int OperatorId { get; set; }
        public byte FinanceMethodOptionId { get; set; }

        public virtual FinanceMethodOption FinanceMethodOption { get; set; }
        public virtual Operator Operator { get; set; }
    }
}