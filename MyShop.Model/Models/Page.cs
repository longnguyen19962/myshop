﻿using MyShop.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyShop.Model.Models
{
    [Table("Pages")]
    public class Page : Auditable

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }

        // Biet chinh xac kieu du lieu
        [Column(TypeName = "varchar")]
        [MaxLength(256)]
        [Required]
        public string Alias { get; set; }

        public string Content { get; set; }
    }
}