using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Web.Mvc;

namespace LiberMvc.Models
{
	public class Postagem
	{
		[Key]
		public int PostagemID { get; set; }

		[Required(ErrorMessage = "'Tipo de Postagem' é um campo obrigatório.")]
		[DisplayName("Tipo de Postagem:")]
		public int TipoPostagemID { get; set; }

		[Required(ErrorMessage = "'Título' é um campo obrigatório.")]
		[StringLength(250, ErrorMessage = "'Titulo' não pode ter mais de 250 caracteres.")]
		[DisplayName("Título:")]
		public string Titulo { get; set; }

		[Required(ErrorMessage = "'Chamada' é um campo obrigatório.")]
		[StringLength(1000, ErrorMessage = "'Chamada' não pode ter mais de 1000 caracteres.")]
		[DisplayName("Chamada:")]
		[DataType(DataType.MultilineText)]
		public string Chamada { get; set; }

		[Required(ErrorMessage = "'Texto' é um campo obrigatório.")]
		[DisplayName("Texto:")]
		[DataType(DataType.Html)]
		[AllowHtml]
		public string Conteudo { get; set; }

		[UIHint("SimNao")]
		[DisplayName("Publicado:")]
		public bool Publicado { get; set; }

		[DisplayName("Publicado em:")]
		[DataType(DataType.Date)]
		public DateTime? PublicadoEm { get; set; }

		[HiddenInput(DisplayValue = true)]
		[DisplayName("Criado em:")]
		[DataType(DataType.Date)]
		public DateTime? CriadoEm { get; set; }

		[StringLength(500, ErrorMessage = "'Fonte' não pode ter mais de 500 caracteres.")]
		[DisplayName("Fonte:")]
		public string Fonte { get; set; }

		[ForeignKey("TipoPostagemID")]
		public TipoPostagem TipoPostagem { get; set; }

		[UIHint("Autores")]
		[DisplayName("Autor(es):")]
		public virtual ICollection<AutorPostagem> Autores { get; set; }

		[NotMapped]
		public IEnumerable<int> SelectedItemIds { get; set; }

	}
}
