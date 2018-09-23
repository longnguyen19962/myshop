using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("PostTags")]
    public class PostTag
    {
        [Key]
        [Column(Order =1)]
        public int PostID { get; set; }

        [Key]
        [Column(TypeName = "varchar",Order=2)]
        [MaxLength(50)]
        public string TagID { get; set; }

        // Lien ket ben ngoai
        [ForeignKey("PostID")]
        public virtual Post Posts { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
    }
}