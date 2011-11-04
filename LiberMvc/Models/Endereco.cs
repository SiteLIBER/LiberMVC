using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace LiberMvc.Models
{
	public class Endereco : IEndereco
	{
		[StringLength(250), DisplayName("Endereço"), Required(ErrorMessage = "*", AllowEmptyStrings = true)]
		public string Logradouro { get; set; }

		[StringLength(250), Required(ErrorMessage = "*", AllowEmptyStrings = true)]
		public string Cidade { get; set; }

		[StringLength(2), Required(ErrorMessage = "*", AllowEmptyStrings = true)]
		public string Estado { get; set; }

		[StringLength(9), DisplayName("CEP"), Required(ErrorMessage = "*", AllowEmptyStrings = true)]
		public string CEP { get; set; }
	}
}
