using System;
using System.Web;
using System.Web.Security;

namespace LiberMvc.Models
{
	public partial class Usuario
	{

		//public void TipoUsuario()
		//{
 
		//}

		#region Logado
		public static class Logado
		{
			public static int ID { get { return HttpContext.Current.User.Identity.Name.ToInt32(); } }

			public static string Roles
			{
				get
				{
					return (string)HttpContext.Current.Session["roles"];
				}
				set
				{
					HttpContext.Current.Session["roles"] = value;
				}
			}
			public static bool isAdmin { get { return Roles == "Admin"; } }
			public static bool isEditor { get { return Roles == "Editor"; } }
		}
		#endregion
	}
}