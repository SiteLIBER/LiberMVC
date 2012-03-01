using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	[Table("EstadoCivil", Schema = "liber")]
	public class EstadoCivil
	{
		[Key]
		public int EstadoCivilID { get; set; }

		[StringLength(50)]
		public string Descricao { get; set; }
	}
}
