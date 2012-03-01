using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	[Table("GrauInstrucao", Schema = "liber")]
	public class GrauInstrucao
	{
		[Key]
		public int GrauInstrucaoID { get; set; }

		[StringLength(50)]
		public string Descricao { get; set; }
	}
}
