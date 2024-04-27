
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoreApi.Models
{
	public class Supplier
	{
        [Key]
        public int SupplierId { get; set; } // Clave primaria
        [Required, StringLength(100)]
        public string? Name { get; set; }
        [ForeignKey("Address")]
        public int IdAddress { get; set; }
        public Address? address { get; set; }
        [ForeignKey("TipoDocumento") ]
        public int IdDocumento { get; set; }
        public TipoDocumento? Documento { get; set; }
        [Required]
        public string? phone{ get; set; }
        public List<Product>? Products { get; set; } // Relación uno a muchos
    }
}

