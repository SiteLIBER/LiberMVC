using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using System.Web.Security;
using Elmah;
using Facebook.Web;
using Facebook.Web.Mvc;

namespace LiberMvc.Controllers
{
	public class AuthController : Controller
	{

		#region Repository
		UsuarioRepository rep;

		public AuthController()
		{ 
		  rep = new UsuarioRepository();
		}
		#endregion

		#region GET: /Auth
		public ActionResult Index()
		{
			if (Request.IsAuthenticated)
				return View("AcessoNegado");
			else
				return View("AreaRestrita");
		}
		#endregion

		#region POST: /Auth/Login
		[HttpPost]
		public ActionResult Login(LoginModel form, string returnUrl)
		{
			// TODO: gravar registro do login com UsuarioID

			var usuario = rep.PegarUsuario(form);
			ActionResult arLoginFalhou;
			ActionResult arBanido;
			ActionResult arLogado;
			ActionResult arValidacaoFalhou;
			if (Request.IsAjaxRequest())
			{
				arLoginFalhou = PartialView("_LoginFalhouBox"); // JavaScript("window.location='" + Url.Action("LoginFalhou") + "';");
				arBanido = PartialView("_BanidoBox"); // JavaScript("window.location='" + Url.Action("Banido") + "';");
				arLogado = (!String.IsNullOrEmpty(returnUrl)) 
					? (ActionResult)JavaScript("window.location='" + returnUrl + "';")
					: JavaScript("$('#loginbox').load('" + Url.Action("UserBox", "Usuario") + "');"); //JavaScript("$(function(){$('#loginbox').load('" + Url.Action("UserBox", "Usuario") + "');});");
				arValidacaoFalhou = PartialView("_LoginFalhouBox");
			}
			else
			{
				arLoginFalhou = View("LoginFalhou");
				arBanido = View("Banido");
				arLogado = (!String.IsNullOrEmpty(returnUrl)) ? Redirect(returnUrl) : Redirect(Request.UrlReferrer.OriginalString);
				arValidacaoFalhou = Redirect(Request.UrlReferrer.OriginalString);
			}

			if (!ModelState.IsValid)
				return arValidacaoFalhou;

			if (usuario == null)
				return arLoginFalhou;

			if (usuario.Banido)
				return arBanido;

			usuario.Logar(form.Lembrar);
			return arLogado;
			
		}
		#endregion

		#region GET: /Auth/Facebook
		public ActionResult Facebook()
		{
			if (FacebookWebContext.Current.IsAuthenticated() && FacebookWebContext.Current.HasPermission("email"))
			{
				return RedirectToAction("FacebookAuth");
			}
			return View();
		}
		#endregion

		#region GET: /Auth/FacebookAuth
		[FacebookAuthorize(LoginUrl = "/Auth/Facebook", Permissions="email")]
		public ActionResult FacebookAuth()
		{
			var client = new FacebookWebClient();
			dynamic me = client.Get("me");
			long facebookId = Convert.ToInt64(me.id);
			string email = me.email;
			var usuario = rep.PegarUsuarioDoFacebook(facebookId);
			if (usuario != null)
			{
				usuario.Logar(true);
				return RedirectToRoute(new { controller = "Home" });
			}
			else
			{
				usuario = rep.PegarUsuario(email);
				if (usuario != null)
				{
					usuario.FacebookID = facebookId;
					rep.Editar(usuario);
					rep.Salvar();
					usuario.Logar(true);
					return RedirectToRoute(new { controller = "Home" });
				}
				else
					return RedirectToAction("FacebookRegister");
			}
		}
		#endregion

		#region GET: /Login/FacebookRegister
		public ActionResult FacebookRegister()
		{
			return View();
		}
		#endregion

		#region GET: /Login/FacebookRegistered

		[FacebookAuthorize(LoginUrl = "/Login/Facebook")]
		public ActionResult FacebookRegistered(CadastroModel form)
		{
			rep.Cadastrar(form);
			return RedirectToRoute(new { @controller = "Game" });
		}
		#endregion

		#region LogOff
		public ActionResult LogOff()
		{
			FormsAuthentication.SignOut();
			Session.Clear();

			if (Request.IsAjaxRequest())
				return JavaScript("window.location='/';");
			else
				return RedirectToRoute(new { controller = "Home", action = "Index" });
		}
		#endregion

		#region LoginFalhou
		public ActionResult LoginFalhou()
		{
			return View();
		}
		#endregion

		#region Banido
		public ActionResult Banido()
		{
			return View();
		}
		#endregion
	}
}
