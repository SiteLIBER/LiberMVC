using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using System.Web.Security;
using AutoMapper;
using Elmah;
using System.Net.Mail;

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
		[Auth]
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

		#region GET: EsqueciSenha
		public ActionResult EsqueciSenha()
		{
			return View(new EsqueciModel());
		}
		#endregion

		#region POST: EsqueciSenha
		[HttpPost]
		public ActionResult EsqueciSenha(EsqueciModel form)
		{

			Usuario usuario = rep.ListaUsuarios().SingleOrDefault(u => u.Email == form.Email);

			if (usuario != null)
			{
				SmtpClient smtp = new SmtpClient();
				smtp.EnableSsl = smtp.Port != 25;
				
				MailMessage mail = new MailMessage();
				mail.From = new MailAddress("noreply@pliber.org.br");
				mail.To.Add(new MailAddress(usuario.Email, usuario.Nome));
				mail.Subject = "Liber - Esqueci minha senha";
				mail.Body = "Sua senha é: " + usuario.Senha;

				smtp.Send(mail);

				form.ErrorMessage = "Senha enviada com sucesso!";
				form.Email = "";				
				return View(form);
			}
			else 
			{
				form.ErrorMessage = "E-mail não se encontra em nossa base!";

				return View(form);
			}

		}
		#endregion

	}


}
