using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	public class CadastroModel
	{
		[Required(ErrorMessage = "*")]
		[DisplayName("Nome:")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "*")]
		[DataType(DataType.EmailAddress)]
		[DisplayName("E-mail:")]
		public string Email { get; set; }

		[Required(ErrorMessage = "*")]
		[DataType(DataType.Password)]
		[DisplayName("Senha:")]
		public string Senha { get; set; }

		[DisplayName("Desejo receber newsletter")]
		public bool ReceberNewsletter { get; set; }

		[DisplayName("Desejo me filiar agora")]
		public bool DesejaFiliacao { get; set; }
	}

}