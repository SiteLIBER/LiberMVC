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
	public class PostagemController : Controller
	{
		#region Repository
		private PostagemRepository rep;

		public PostagemController()
		{
			rep = new PostagemRepository();
		}
		#endregion
		//
		// GET: /Postagem/

		public ViewResult Index()
		{
			var postagens = rep.Postagens.Include(p => p.TipoPostagem);
			return View(postagens.ToList());
		}

		//
		// GET: /Postagem/Details/5
		// GET: /#/5

		public ViewResult Details(int id, string title)
		{
			Postagem postagem = rep.GetPostagem(id);
			return View(postagem);
		}

		//
		// GET: /Postagem/Create

		public ActionResult Create()
		{
			ViewBag.TipoPostagemID = new SelectList(rep.TiposPostagem, "TipoPostagemID", "Descricao");
			return View();
		}

		//
		// POST: /Postagem/Create

		[HttpPost]
		public ActionResult Create(Postagem postagem)
		{
			if (ModelState.IsValid)
			{
				rep.Add(postagem);
				rep.Save();
				return RedirectToAction("Index");
			}

			ViewBag.TipoPostagemID = new SelectList(rep.TiposPostagem, "TipoPostagemID", "Descricao", postagem.TipoPostagemID);
			return View(postagem);
		}

		//
		// GET: /Postagem/Edit/5

		public ActionResult Edit(int id)
		{
			Postagem postagem = rep.GetPostagem(id);
			ViewBag.TipoPostagemID = new SelectList(rep.TiposPostagem, "TipoPostagemID", "Descricao", postagem.TipoPostagemID);
			return View(postagem);
		}

		//
		// POST: /Postagem/Edit/5

		[HttpPost]
		public ActionResult Edit(Postagem postagem)
		{
			if (ModelState.IsValid)
			{
				rep.Edit(postagem);
				rep.Save();
				return RedirectToAction("Index");
			}
			ViewBag.TipoPostagemID = new SelectList(rep.TiposPostagem, "TipoPostagemID", "Descricao", postagem.TipoPostagemID);
			return View(postagem);
		}

		//
		// GET: /Postagem/Delete/5

		public ActionResult Delete(int id)
		{
			Postagem postagem = rep.GetPostagem(id);
			return View(postagem);
		}

		//
		// POST: /Postagem/Delete/5

		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int id)
		{
			Postagem postagem = rep.GetPostagem(id);
			rep.Delete(postagem);
			rep.Save();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			rep.Dispose();
			base.Dispose(disposing);
		}
	}
}