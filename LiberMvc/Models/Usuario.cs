using System;
using System.Web;
using System.Web.Security;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;

namespace LiberMvc.Models
{
	[Table("Usuarios", Schema = "liber")]
	public partial class Usuario
	{

		//public void TipoUsuario()
		//{
 
		//}
		[Key, ForeignKey("Pessoa")]
		public int PessoaID { get; set; }

		public virtual Pessoa Pessoa { get; set; }

		public Int64? FacebookID { get; set; }

		[DisplayName("Apelido:"), Required(ErrorMessage = "*")]
		public string Apelido { get; set; }

		[StringLength(50), DataType(DataType.Password)]
		[DisplayName("Senha:"), Required(ErrorMessage = "*")]
		public string Senha { get; set; }

		[StringLength(250), DataType(DataType.EmailAddress)]
		[DisplayName("E-mail:"), Required(ErrorMessage = "*")]
		public string Email { get; set; }
		
		public bool Banido { get; set; }

		[DisplayName("Desejo receber newsletter")]
		public bool ReceberNewsletter { get; set; }

		public DateTime CriadoEm { get; set; }
		

		#region Logado
		public static class Logado
		{
			public static int ID { get { return HttpContext.Current.User.Identity.Name.ToInt32(); } }

			public static List<string> Roles
			{
				get
				{
					return HttpContext.Current.Session["roles"] as List<string>;
				}
				set
				{
					HttpContext.Current.Session["roles"] = value;
				}
			}
			public static bool isAdmin { get { return (Roles != null) ? Roles.Contains("Admin") : false; } }
			public static bool isEditor { get { return (Roles != null) ? Roles.Contains("Editor") : false; } }
		}
		#endregion

		internal void Logar(bool lembrar)
		{
			Usuario.Logado.Roles = Pessoa.Titulos.Select(t => t.Titulo.Codigo).ToList();
			FormsAuthentication.SetAuthCookie(PessoaID.ToString(), lembrar);
		}
	}
}