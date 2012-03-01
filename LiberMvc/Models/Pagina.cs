using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace LiberMvc.Models
{
	[Table("Paginas", Schema = "liber")]
	public class Pagina
	{
		[Key]
		public int PaginaID { get; set; }


		[Required(ErrorMessage = "'Título' é um campo obrigatório.")]
		[StringLength(250, ErrorMessage = "'Titulo' não pode ter mais de 250 caracteres.")]
		[DisplayName("Título:")]
		public string Titulo { get; set; }

		[Required(ErrorMessage = "'Texto' é um campo obrigatório.")]
		[DisplayName("Texto:")]
		[DataType(DataType.Html)]
		[AllowHtml]
		public string Conteudo { get; set; }

		[UIHint("SimNao")]
		[DisplayName("Publicado:")]
		public bool Publicado { get; set; }

		[HiddenInput(DisplayValue = true)]
		[DisplayName("Criado em:")]
		[DataType(DataType.Date)]
		public DateTime? CriadoEm { get; set; }

		//[InverseProperty("Pagina")]
		//public virtual ICollection<Menu> Menus { get; set; }

		public string Link { get; set; }

	}
}
