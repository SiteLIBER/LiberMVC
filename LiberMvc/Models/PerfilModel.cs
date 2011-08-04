using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LiberMvc.Models
{
	public class PerfilModel : IPerfilModel
	{
		[Required(ErrorMessage = "*")]
		[DisplayName("Apelido:")]
		public string Apelido { get; set; }

		[Required(ErrorMessage = "*")]
		[DataType(DataType.EmailAddress)]
		[DisplayName("E-mail:")]
		public string Email { get; set; }
 	}
}