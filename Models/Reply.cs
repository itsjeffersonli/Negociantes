using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negociantes.Models
{
    public class Reply
    {
    [Key]
    public int ReplyId { get; set; }

    [Required]
    public string Text { get; set; }

    [ScaffoldColumn(false)]
    public DateTime? DateTime { get; set; }

    [Display(Name = "Name")]
    public string Name { get; set; }

    [Display(Name = "FullName")]
    public string NameFull { get; set; }

    [Display(Name = "Messenger Link")]
    public string Messenger { get; set; }

    [Display(Name = "City")]
    public string City { get; set; }

    public string UserId { get; set; }
    [ForeignKey("UserId")]
    public virtual ApplicationUser User { get; set; }

    public int PostId { get; set; }
    [ForeignKey("PostId")]
    public virtual Post Post { get; set; }
}
}
