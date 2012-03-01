using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	[Table("Agendas", Schema="liber")]
	public class Agenda
	{
		[Key]
		public int AgendaID { get; set; }

		[StringLength(200)]
		public string Titulo { get; set; }

		public DateTime DataInicio { get; set; }

		public DateTime? DataFim { get; set; }
		
		[StringLength(200)]
		public string Local { get; set; }

		[DataType(DataType.MultilineText)]
		public string Conteudo { get; set; }



	}
}
