using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LiberMvc.Models
{
	[Table("Autores", Schema = "liber")]
	public class Autor
	{
		[Key] 
		public int AutorID { get; set; }

		[StringLength(250)]
		[DisplayName("Nome do Autor")]
		public string Nome { get; set; }

		[StringLength(1000), DataType(DataType.MultilineText)]
		public string Descricao { get; set; }

		[ForeignKey("Pessoa")]
		public int? PessoaID { get; set; }

		public virtual Pessoa Pessoa { get; set; }
	}
}
