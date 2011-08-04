using System;
namespace LiberMvc.Models
{
	public interface ICadastroModel
	{
		string Email { get; set; }
		string Apelido { get; set; }
		bool ReceberNewsletter { get; set; }
		string Senha { get; set; }
	}
}
