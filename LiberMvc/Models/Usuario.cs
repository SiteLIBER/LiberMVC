using System;
using System.Web;
using System.Web.Security;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace LiberMvc.Models
{
	public partial class Usuario : ICadastroModel, IPerfilModel
	{

		//public void TipoUsuario()
		//{
 
		//}
		[Key, ForeignKey("Pessoa")]
		public int PessoaID { get; set; }

		public Int64? FacebookID { get; set; }

		public string Apelido { get; set; }

		[StringLength(50), DataType(DataType.Password), Required]
		public string Senha { get; set; }

		[StringLength(250), DataType(DataType.EmailAddress), Required]
		public string Email { get; set; }
		
		public bool Banido { get; set; }

		public bool ReceberNewsletter { get; set; }

		public DateTime CriadoEm { get; set; }

		public virtual Pessoa Pessoa { get; set; }


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
			public static bool isAdmin { get { return Roles.Contains("Admin"); } }
			public static bool isEditor { get { return Roles.Contains("Editor"); } }
		}
		#endregion

		internal void Logar(bool lembrar)
		{
			Usuario.Logado.Roles = Pessoa.Titulos.Select(t => t.Titulo.Codigo).ToList();
			FormsAuthentication.SetAuthCookie(PessoaID.ToString(), lembrar);
		}
	}
}