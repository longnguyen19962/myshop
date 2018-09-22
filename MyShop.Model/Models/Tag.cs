using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }
    }
}