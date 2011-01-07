using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	public class PerfilModel
	{
		[Required(ErrorMessage = "*")]
		[DisplayName("Nome:")]
		public string Nome { get; set; }

		[Required(ErrorMessage = "*")]
		[DataType(DataType.EmailAddress)]
		[DisplayName("E-mail:")]
		public string Email { get; set; }
 	}
}