using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Models
{
	public class Category
	{
        [Key]
        public int CategoryId { get; set; } // Clave primaria
        [Required, StringLength(50)]
        public string? Name { get; set; }
        [ForeignKey("Product")]
        public List<Product>? Products { get; set; } // Relación uno a muchos
    }
}

