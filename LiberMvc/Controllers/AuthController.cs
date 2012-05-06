using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using System.Web.Security;

namespace LiberMvc.Controllers
{
	[HandleError(View = "Error")]
	public class AuthController : Controller
	{

		#region Repository
		IUsuarioRepository rep;

		public AuthController() : this(new UsuarioRepository()) {	}

		public AuthController(IUsuarioRepository repository)
		{ 
		  rep = repository;
		}
		#endregion

		#region Index
		public ActionResult Index()
		{
			if (Request.IsAuthenticated)
				return View("AcessoNegado");
			else
				return View("AreaRestrita");
		}
		#endregion

		#region Login
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
				arLoginFalhou = View("LoginFalhouBox"); // JavaScript("window.location='" + Url.Action("LoginFalhou") + "';");
				arBanido = View("BanidoBox"); // JavaScript("window.location='" + Url.Action("Banido") + "';");
				arLogado = (!String.IsNullOrEmpty(returnUrl)) 
					? (ActionResult)JavaScript("window.location='" + returnUrl + "';")
					: JavaScript("$('#loginbox').load('" + Url.Action("UserBox", "Usuario") + "');"); //JavaScript("$(function(){$('#loginbox').load('" + Url.Action("UserBox", "Usuario") + "');});");
				arValidacaoFalhou = View("LoginFalhouBox");
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
			
			form.Logar(usuario);
			return arLogado;
			
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
