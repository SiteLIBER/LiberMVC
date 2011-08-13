using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LiberMvc.Models
{
	public class Pessoa
	{
		[Key]
		public int PessoaID { get; set; }

		[StringLength(250), DisplayName("Nome Completo")]
		public string Nome { get; set; }

		[DataType(DataType.Date), DisplayName("Data de Nascimento")]
		public DateTime? DataNasc { get; set; }

		[StringLength(50)]
		public string Naturalidade { get; set; }

		[StringLength(250), DisplayName("Nome do Pai")]
		public string NomePai { get; set; }

		[StringLength(250), DisplayName("Nome da Mãe")]
		public string NomeMae { get; set; }

		[DisplayName("Estado Civil")]
		public int? EstadoCivilID { get; set; }

		public Endereco Endereco { get; set; }
		
		[StringLength(50)]
		public string Telefone { get; set; }



		[StringLength(100), DisplayName("Profissão")]
		public string Profissao { get; set; }
		
		[DisplayName("Grau de Instrução")]
		public int? GrauInstrucaoID { get; set; }

		[ForeignKey("EstadoCivilID")]
		public virtual EstadoCivil EstadoCivil { get; set; }

		[ForeignKey("GrauInstrucaoID")]
		public virtual GrauInstrucao GrauInstrucao { get; set; }
		
		public virtual ICollection<TituloPessoa> Titulos { get; set; }

		public virtual Filiado Filiado { get; set; }


	}
}
