using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	[Table("TitulosPessoas", Schema = "liber")]
	public class TituloPessoa
	{
		[Key, Column(Order=0)] 
		public int PessoaID { get; set; }
		
		[Key, Column(Order=1)]
		public int TituloID { get; set; }

		[ForeignKey("TituloID")]
		public virtual Titulo Titulo { get; set; }
		
		[ForeignKey("PessoaID")]
		public virtual Pessoa Pessoa { get; set; }
	}
}
