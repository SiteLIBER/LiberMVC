using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	public class Titulo
	{
		[Key] public int TituloID { get; set; }
		public string Codigo { get; set; }
		public string Nome { get; set; }
	}
}
