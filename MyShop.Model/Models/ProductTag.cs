﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("ProductTags")]
    public class ProductTag
    {
        [Key]
        [Column(Order =1)]
        public int ProductID { get; set; }

        [Key]
        [Column(TypeName = "varchar", Order = 2)]
        [MaxLength(50)]
        public string TagID { get; set; }

        //Lien ket ben ngoai
        [ForeignKey("ProductID")]
        public virtual Product Products { set; get; }

        [ForeignKey("TagID")]
        public virtual Tag Tags { set; get; }
    }
}