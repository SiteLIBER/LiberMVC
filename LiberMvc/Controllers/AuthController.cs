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

		#region GET: /Login/Facebook
		public ActionResult Facebook()
		{
			if (FacebookWebContext.Current.IsAuthenticated())
			{
				return RedirectToAction("FacebookAuth");
			}
			return View();
		}
		#endregion

		#region GET: /Login/FacebookAuth
		[FacebookAuthorize(LoginUrl = "/Login/Facebook")]
		public ActionResult FacebookAuth()
		{
			var client = new FacebookWebClient();
			dynamic me = client.Get("me");
			long facebookId = Convert.ToInt64(me.id);
			var usuario = rep.PegarUsuarioDoFacebook(facebookId);
			if (usuario != null)
			{
				usuario.Logar(false);
				return RedirectToRoute(new { controller = "Home" });
			}
			else
			{
				//return View("LoginFailed", new LoginModel { UserName = me.name });
				return RedirectToAction("FacebookRegister");
			}
		}
		#endregion

		#region GET: /Login/FacebookRegister
		public ActionResult FacebookRegister()
		{
			ViewBag.Factions = FbJson.Create(factionRepository.ListAllFactions.Select(i => new FbJsonItem { ID = i.FactionID, Name = i.Name }));
			ViewBag.Races = FbJson.Create(raceRepository.ListAllRaces.Select(i => new FbJsonItem { ID = i.RaceID, Name = i.Name }));
			return View();
		}
		#endregion

		#region GET: /Login/FacebookRegistered

		[FacebookAuthorize(LoginUrl = "/Login/Facebook")]
		public ActionResult FacebookRegistered()
		{
			dynamic fb = FacebookWebContext.Current.SignedRequest.Data;
			//{"registration":
			//  {"name":"XXXXXX",
			//  "email":"ZZZZZ@gmail.com",
			//  "faction":"5",
			//  "race":"5"},
			//"user":{"country":"br","locale":"pt_BR"},
			//"user_id":"0000000000"}
			long facebookId = Convert.ToInt64(fb.user_id);
			short factionId = Convert.ToInt16(fb.registration.faction);
			short raceId = Convert.ToInt16(fb.registration.race);
			int rank = (playerRepository.db.Players.Count() > 0) ? playerRepository.db.Players.Max(p => p.Rank).ToInt32() + 1 : 1;

			Player player = playerRepository.GetPlayerByFacebookID(facebookId);
			if (player != null)
			{
				player.Login(false);
				return RedirectToRoute(new { controller = "Game" });
			}

			var newPlayer = new Player
			{
				FacebookID = facebookId,
				Name = fb.registration.name,
				Password = Guid.NewGuid().ToString(),
				Email = fb.registration.email,
				Activated = true,
				FactionID = factionId,
				RaceID = raceId,
				Rank = rank,
				Gold = 10000,
				Tax = 10,
				Created = DateTime.Now
			};
			playerRepository.Add(newPlayer);
			playerRepository.Save();

			player = playerRepository.GetPlayerByFacebookID(facebookId);
			playerRepository.ResetPlayer(player, DateTime.Now);

			playerRepository.Save();

			player.Login(false);
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
