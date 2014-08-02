using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CATS_Interview.Model
{
    public class AxleCombination
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AxleCombinationId { get; set; }
        public int OperatorId { get; set; }
        public byte AxleCombinationOptionId { get; set; }

        public virtual AxleCombinationOption AxleCombinationOption { get; set; }
        public virtual Operator Operator { get; set; }
    }
}