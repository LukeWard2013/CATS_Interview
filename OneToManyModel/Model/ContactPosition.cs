using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CATS_Interview.Model
{
    public class ContactPosition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public byte ContactPositionId { get; set; }
        public string ContactPositionText { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; } 
    }
}