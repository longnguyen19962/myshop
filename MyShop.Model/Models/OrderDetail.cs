using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("OrderDetails")]
    public class OrderDetail
    {
        [Key]
        public int OrderID { get; set; }

        [Key]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }

        //Phan lien ket giua cac bang
        [ForeignKey("OrderID")]
        public virtual Order Orders { set; get; }

        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }
    }
}