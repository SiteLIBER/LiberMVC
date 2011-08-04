using System;
namespace LiberMvc.Models
{
	public interface IPessoa
	{
		DateTime? DataNasc { get; set; }
		int? EstadoCivilID { get; set; }
		int? GrauInstrucaoID { get; set; }
		string Naturalidade { get; set; }
		string Nome { get; set; }
		string NomeMae { get; set; }
		string NomePai { get; set; }
		int PessoaID { get; set; }
		string Profissao { get; set; }
		string Telefone { get; set; }
	}
}
