using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	[Table("Titulos", Schema = "liber")]
	public class Titulo
	{
		[Key] public int TituloID { get; set; }
		public string Codigo { get; set; }
		public string Nome { get; set; }
	}
}
