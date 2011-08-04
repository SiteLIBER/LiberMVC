using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//using System.Collections;
using System.Collections.Generic;

namespace LiberMvc.Models
{
	public class FiliacaoModel : IEndereco, IPessoa
	{
		// Dados Pessoais
		[ScaffoldColumn(false)]
		public int PessoaID { get; set; }

		[DisplayName("Nome Completo:"), StringLength(250), Required(ErrorMessage = "*")]
		public string Nome { get; set; }

		[DisplayName("Data Nascimento:"), Required(ErrorMessage = "*")]
		public DateTime? DataNasc { get; set; }

		[DisplayName("Naturalidade:"), StringLength(50), Required(ErrorMessage = "*")]
		public string Naturalidade { get; set; }

		[DisplayName("Nome do Pai:"), StringLength(250), Required(ErrorMessage = "*")]
		public string NomePai { get; set; }

		[DisplayName("Nome da Mãe:"), StringLength(250), Required(ErrorMessage = "*")]
		public string NomeMae { get; set; }

		[DisplayName("Estado Civil:"), Required(ErrorMessage = "*")]
		public int? EstadoCivilID { get; set; }

		[ScaffoldColumn(false)]
		public IEnumerable<EstadoCivil> ListaEstadoCivil { get; set; }

		[DisplayName("Profissão:"), Required(ErrorMessage = "*")]
		public string Profissao { get; set; }

		[DisplayName("Grau de Instrução:"), Required(ErrorMessage = "*")]
		public int? GrauInstrucaoID { get; set; }

		[ScaffoldColumn(false)]
		public IEnumerable<GrauInstrucao> ListaGrauInstrucao { get; set; }


		// Contato
		[DisplayName("Endereço residencial:"), StringLength(250), Required(ErrorMessage = "*")]
		public string Logradouro { get; set; }

		[DisplayName("Cidade:"), StringLength(250), Required(ErrorMessage = "*")]
		public string Cidade { get; set; }

		[DisplayName("UF:"), StringLength(2), Required(ErrorMessage = "*")]
		public string Estado { get; set; }
		public IDictionary<string, string> ListaEstados = Listas.Estados;

		[DisplayName("CEP:"), StringLength(9), Required(ErrorMessage = "*")]
		public string CEP { get; set; }

		[DisplayName("Telefone:"), StringLength(50), Required(ErrorMessage = "*")]
		public string Telefone { get; set; }


		// Dados Eleitorais
		public Filiado Filiado { get; set; }
	}
}