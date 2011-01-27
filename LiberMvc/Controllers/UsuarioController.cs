using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using System.Web.Security;
using AutoMapper;
using Elmah;

namespace LiberMvc.Controllers
{
	[Scc("Usuario")]
	public class UsuarioController : Controller
	{

		#region Repository
		IUsuarioRepository rep;

		public UsuarioController() : this(new UsuarioRepository()) {	}

		public UsuarioController(IUsuarioRepository repository)
		{ 
		  rep = repository;
		}
		#endregion

		#region Index
		public ActionResult Index()
		{
			if (User.Identity.IsAuthenticated)
				return RedirectToAction("Perfil", new { id = User.Identity.Name });
			else
				return RedirectToAction("Index", "Home");
		}
		#endregion

		#region Perfil
		public ActionResult Perfil(int id)
		{
				return View(rep.PegarPerfil(id));
		}
		#endregion

		#region LoginBox
		public ActionResult LoginBox()
		{
				return View();
		}
		#endregion

		#region UserBox
		[Auth]
		public ActionResult UserBox()
		{
				return View(rep.PegarUsuarioLogado());
		}
		#endregion

		#region Cadastro
		public ActionResult Cadastro()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Cadastro(CadastroModel form)
		{
			if (!ModelState.IsValid)
				return View();

			var usuario = rep.Cadastrar(form);
			if (usuario != null)
			{
				rep.Salvar();
				new LoginModel().Logar(rep.PegarUsuario(usuario.UsuarioID));
				return (form.DesejaFiliacao) ? RedirectToAction("Filiacao") : RedirectToAction("Index", "Home");
			}
			else
				return View("EmailExiste");
		}
		#endregion

		#region Filiacao
		[Auth]
		public ActionResult Filiacao()
		{
			return View(rep.PegarFiliado());
		}
		
		[Auth, HttpPost]
		public ActionResult Filiacao(FiliacaoModel form)
		{
			if (!ModelState.IsValid)
			{
				var model = rep.PegarFiliado();
				return View(model);
			}

			Usuario usuario = rep.PegarUsuarioLogado();
			UpdateModel(usuario);
			rep.Salvar();

			return RedirectToAction("FiliacaoConfirma");
		}
		#endregion

		#region FiliacaoConfirma
		[Auth]
		public ActionResult FiliacaoConfirma()
		{
			return View(rep.PegarFiliado());
		}
		#endregion

		#region FiliacaoImprimir
		[Auth]
		public ActionResult FiliacaoImprimir()
		{
			return View(rep.PegarFiliado());
		}
		#endregion
	}


}
