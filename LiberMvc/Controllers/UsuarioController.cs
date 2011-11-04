using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using System.Web.Security;
using Elmah;
using System.Net.Mail;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace LiberMvc.Controllers
{
	[Scc("Usuario")]
	public class UsuarioController : Controller
	{

		#region Repository
		UsuarioRepository rep;

		public UsuarioController() 
		{
		  rep = new UsuarioRepository();
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
				return PartialView("_LoginBox");
		}
		#endregion

		#region UserBox
		[Auth]
		public ActionResult UserBox()
		{
				return PartialView("_UserBox", rep.UsuarioLogado);
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
				try
				{
					rep.Salvar();
					usuario.Logar(false);
					return (form.DesejaFiliacao) ? RedirectToAction("Filiacao") : RedirectToAction("Index", "Home");
				}
				catch (DbEntityValidationException dbEx)
				{
					foreach (var validationErrors in dbEx.EntityValidationErrors)
					{
						foreach (var validationError in validationErrors.ValidationErrors)
						{
							Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
						}
					}
					return View("Error", dbEx);
				}
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
				var model = rep.PegarFiliado();
			if (!ModelState.IsValid)
			{
				return View(model);
			}

			//Usuario usuario = rep.UsuarioLogado;
			//UpdateModel(usuario.Pessoa);
			
			UpdateModel(model);
			
			try
			{
				rep.Salvar();
				return RedirectToAction("FiliacaoConfirma");
			}
			catch (DbEntityValidationException dbEx)
			{
				foreach (var validationErrors in dbEx.EntityValidationErrors)
				{
					foreach (var validationError in validationErrors.ValidationErrors)
					{
						Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
					}
				}
				return View("Error", dbEx);
			}
			
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

			Usuario usuario = rep.ListaUsuarios.SingleOrDefault(u => u.Email == form.Email);

			if (usuario != null)
			{
				SmtpClient smtp = new SmtpClient();
				smtp.EnableSsl = smtp.Port != 25;
				
				MailMessage mail = new MailMessage();
				mail.From = new MailAddress("noreply@pliber.org.br");
				mail.To.Add(new MailAddress(usuario.Email, usuario.Apelido));
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
