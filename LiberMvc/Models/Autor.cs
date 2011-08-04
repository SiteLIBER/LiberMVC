using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	public class Autor
	{
		[Key] 
		public int AutorID { get; set; }

		[StringLength(250)]
		public string Nome { get; set; }

		[StringLength(1000), DataType(DataType.MultilineText)]
		public string Descricao { get; set; }
	}
}
