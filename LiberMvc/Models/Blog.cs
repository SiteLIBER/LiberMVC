using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace LiberMvc.Models
{
	//[Bind(Include = "Titulo,Conteudo,Publicado,PublicadoEm")]
	//[MetadataType(typeof(Blog_Validacao))]
	//public partial class Blog
	//{
	//  [HiddenInput(DisplayValue = false)]
	//  public bool isOwnerOrAdmin
	//  {
	//    get
	//    {
	//      return (EditorID == Usuario.Logado.ID || Usuario.Logado.isAdmin);
	//    }
	//  }
		
	//}

	//public class Blog_Validacao
	//{
	//  [HiddenInput(DisplayValue = false)]
	//  public int BlogID { get; set; }

	//  [HiddenInput(DisplayValue = false)]
	//  public int EditorID { get; set; }

	//  [Required(ErrorMessage = "'Título' é um campo obrigatório.")]
	//  [StringLength(250, ErrorMessage = "'Titulo' não pode ter mais de 250 caracteres.")]
	//  [DisplayName("Título:")]
	//  public string Titulo { get; set; }

	//  [Required(ErrorMessage = "'Corpo do Blog' é um campo obrigatório.")]
	//  [DisplayName("Corpo do Blog:")]
	//  [DataType(DataType.Html)]
	//  public string Conteudo { get; set; }

	//  [UIHint("SimNao")]
	//  [DisplayName("Publicado:")]
	//  public bool Publicado { get; set; }
		
	//  [Required(ErrorMessage = "'Publicado em' é um campo obrigatório.")]
	//  [DisplayName("Publicado em:")]
	//  [DataType(DataType.Date)]
	//  public DateTime? PublicadoEm { get; set; }

	//  [HiddenInput(DisplayValue = true)]
	//  [DisplayName("Criado em:")]
	//  [DataType(DataType.Date)]
	//  public DateTime? CriadoEm { get; set; }

	//  [HiddenInput(DisplayValue = false)]
	//  public Usuario Editor { get; set; }
	//}
}