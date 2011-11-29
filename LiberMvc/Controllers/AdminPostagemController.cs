using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;

namespace LiberMvc.Controllers
{
	[Auth(Roles = "Editor")]
	public class AdminPostagemController : Controller
	{
		#region Repository
		PostagemRepository rep;

		public AdminPostagemController()
		{
			rep = new PostagemRepository();
		}
		#endregion
		
		#region GET: /AdminPostagem/

		public ViewResult Index(int? page)
		{
			var postagens = new PaginatedList<Postagem>(rep.Postagens, page ?? 0, 20);
			return View(postagens);
		}

		#endregion

		#region GET: /AdminPostagem/Details/5

		public ViewResult Details(int id)
		{
			Postagem postagem = rep.GetPostagem(id);
			return View(postagem);
		}

		#endregion

		#region GET: /AdminPostagem/Create

		public ActionResult Create()
		{
			ViewBag.TipoPostagemID = new SelectList(rep.TiposPostagem, "TipoPostagemID", "Descricao");
			return View();
		}

		#endregion

		#region POST: /AdminPostagem/Create

		[HttpPost, ValidateInput(false)]
		public ActionResult Create(Postagem postagem)
		{
			if (ModelState.IsValid)
			{
				try
				{
					rep.Add(postagem);
					rep.Save();
					rep.Dispose();
					return RedirectToAction("Details", new { id = postagem.PostagemID });
				}
				catch (Exception err)
				{
					return View("Error", err);
				}
			}
			ViewBag.TipoPostagemID = new SelectList(rep.TiposPostagem.ToList(), "TipoPostagemID", "Descricao", postagem.TipoPostagemID);
			return View(postagem);
		}

		#endregion

		#region GET: /AdminPostagem/Edit/5

		public ActionResult Edit(int id)
		{
			var post = rep.GetPostagem(id);
			ViewBag.TipoPostagemID = new SelectList(rep.TiposPostagem, "TipoPostagemID", "Descricao", post.TipoPostagemID);
			return View(post);
		}

		#endregion

		#region POST: /AdminPostagem/Edit/5

		[HttpPost, ValidateInput(false)]
		public ActionResult Edit(int id, Postagem postagem)
		{
			if (ModelState.IsValid)
			{
				try
				{
					rep.Edit(postagem);
					rep.Save();
					rep.Dispose();
					return RedirectToAction("Details", new { id = id });
				}
				catch (Exception err)
				{
					return View("Error", err);
				}
			}
			ViewBag.TipoPostagemID = new SelectList(rep.TiposPostagem.ToList(), "TipoPostagemID", "Descricao", postagem.TipoPostagemID);
			return View(postagem);
		}

		#endregion

		#region GET: /AdminPostagem/Delete/5

		public ActionResult Delete(int id)
		{
			var post = rep.GetPostagem(id);
			rep.Dispose();
			return View(post);
		}

		#endregion

		#region POST: /AdminPostagem/Delete/5

		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int id)
		{
			var post = rep.GetPostagem(id);
			rep.Delete(post);
			rep.Save();
			rep.Dispose();
			return RedirectToAction("Index");
		}

		#endregion

		#region Dispose
		
		protected override void Dispose(bool disposing)
		{
			rep.Dispose();
			base.Dispose(disposing);
		}
		
		#endregion
	}
}