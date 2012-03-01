using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	[Table("TiposPostagem", Schema = "liber")]
	public class TipoPostagem
	{
		[Key] 
		public int TipoPostagemID { get; set; }

		[StringLength(50)]
		public string Descricao { get; set; }
	}
}
