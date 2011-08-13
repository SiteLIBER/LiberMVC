﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using System.Web.Security;
using Elmah;

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

		#region Facebook Login
		public ActionResult FacebookLogin(Facebook.Web.Mvc.FacebookAuthorizeInfo info)
		{
			return View();
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
