using System;
using System.ComponentModel.DataAnnotations;

namespace StoreApi.Models
{
	public class Address
	{
        [Key]
        public int IdAddress { get; set; }
        [StringLength(50)]
        public string? Calle { get; set; }
        [StringLength(5)]
        public string? NumeroApart { get; set; }
        [StringLength(30)]
        public string? Sector { get; set; }
        [StringLength(30)]
        public string? Provincia { get; set; }
        [StringLength(30)]
        public string? Pais { get; set; }
    }
}

