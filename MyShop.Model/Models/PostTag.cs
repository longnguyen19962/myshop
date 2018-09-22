using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string TagID { get; set; }

        // Lien ket ben ngoai
        [ForeignKey("PostID")]
        public virtual Post Posts { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
    }
}