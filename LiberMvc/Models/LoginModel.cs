using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LiberMvc.Models
{
	public class LoginModel
	{
		public void Logar(Usuario usuario)
		{
			Usuario.Logado.Roles = usuario.TipoUsuario.Descricao;
			FormsAuthentication.SetAuthCookie(usuario.UsuarioID.ToString(), Lembrar);
		}

		[Required(ErrorMessage="*")]
		[DisplayName("E-mail")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required(ErrorMessage="*")]
		[DataType(DataType.Password)]
		[DisplayName("Senha")]
		public string Senha { get; set; }

		[DisplayName("Lembrar?")]
		public bool Lembrar { get; set; }
	}
}