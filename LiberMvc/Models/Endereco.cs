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
		[StringLength(250), DisplayName("Endereço")]
		public string Logradouro { get; set; }

		[StringLength(250)]
		public string Cidade { get; set; }

		[StringLength(2)]
		public string Estado { get; set; }
		
		[StringLength(9), DisplayName("CEP")]
		public string CEP { get; set; }
	}
}
