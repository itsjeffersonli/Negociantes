using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Negociantes.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required]
        [Display(Name = "Message")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? DateTime { get; set; }
    }
}
