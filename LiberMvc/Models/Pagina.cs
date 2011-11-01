using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace LiberMvc.Models
{
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
		public string Conteudo { get; set; }

		[UIHint("SimNao")]
		[DisplayName("Publicado:")]
		public bool Publicado { get; set; }

		[HiddenInput(DisplayValue = true)]
		[DisplayName("Criado em:")]
		[DataType(DataType.Date)]
		public DateTime? CriadoEm { get; set; }

		[Required]
		public int MenuID { get; set; }

		[ForeignKey("MenuID")]
		public Menu Menu { get; set; }

		[HiddenInput(DisplayValue = false)]
		public bool isEditorOrAdmin
		{
			get
			{
				return (Usuario.Logado.isEditor || Usuario.Logado.isAdmin);
			}
		}
	}
}
