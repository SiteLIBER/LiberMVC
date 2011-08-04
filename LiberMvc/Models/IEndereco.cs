using System;
namespace LiberMvc.Models
{
	 interface IEndereco
	{
		string CEP { get; set; }
		string Cidade { get; set; }
		string Estado { get; set; }
		string Logradouro { get; set; }
	}
}
