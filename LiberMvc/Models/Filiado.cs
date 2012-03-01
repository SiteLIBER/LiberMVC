using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LiberMvc.Models
{
	[Table("Filiados", Schema = "liber")]
	public class Filiado
	{
		[Key, ForeignKey("Pessoa")]
		public int PessoaID { get; set; }

		public virtual Pessoa Pessoa { get; set; }

		// Dados Eleitorais
		[DisplayName("Título de Eleitor:"), StringLength(20), Required(ErrorMessage = "*")]
		public string TituloEleitor { get; set; }

		[DisplayName("Zona:"), StringLength(4), Required(ErrorMessage = "*")]
		public string Zona { get; set; }

		[DisplayName("Seção:"), StringLength(4), Required(ErrorMessage = "*")]
		public string Secao { get; set; }

		[DisplayName("Município - UF:"), StringLength(250), Required(ErrorMessage = "*")]
		public string MunicipioUF { get; set; }

		[DisplayName("Encontra-se filiado a outro partido?"), UIHint("SimNao")]
		public bool OutroPartido { get; set; }

		[DisplayName("Se sim, qual?"), StringLength(50)]
		public string OutroPartidoQual { get; set; }

		[HiddenInput(DisplayValue = false)]
		public DateTime FiliadoEm { get; set; }

	}
}
