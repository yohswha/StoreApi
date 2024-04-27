using System;
using System.ComponentModel.DataAnnotations;

namespace StoreApi.Models
{
	public class TipoDocumento
	{
		public int IdDocumento { get; set; }
        [StringLength(11)]
        public string? Documento { get; set; }
    }
}

