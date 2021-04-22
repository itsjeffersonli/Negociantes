using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Negociantes.Models
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required(ErrorMessage = "Subject Required.")]
        [Display(Name = "Category")]
        public string Subject { get; set; }

        [Required]
        [Display(Name = "Post description")]
        [DataType(DataType.MultilineText)]
        public string Text { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "FullName")]
        public string NameFull { get; set; }

        [Display(Name = "Messenger Link")]
        public string Messenger { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "User ID")]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        [ScaffoldColumn(false)]
        public DateTime? DateTime { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }
        [Display(Name = "Avatar")]
        public string ImagePath2 { get; set; }

        [Required(ErrorMessage = "Required.")]
        public virtual Category Category { get; set; }

        public ICollection<Reply> Replies { get; set; }
    }

    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string Name { get; set; }
    }

}
