using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using Elmah;

namespace LiberMvc.Controllers
{
	[Scc("Artigos")]
	[HandleError(View = "Error")]
	public class ArtigosController : Controller
	{

		#region Repository
		IArtigoRepository rep;

		public ArtigosController() : this(new ArtigoRepository()) {	}

		public ArtigosController(IArtigoRepository repository)
		{ 
		  rep = repository;
		}
		#endregion

		#region GET: /Artigos/
		public ActionResult Index()
		{
			return View(rep.ArtigosPublicados);
		}
		#endregion 

		#region GET: /Artigos/Details/5

		public ActionResult Details(int id)
		{
			var art = rep.GetArtigo(id);
			return (art.Publicado || art.isOwnerOrAdmin) ? View(art) : View();
		}

		#endregion

		#region GET: /Artigos/Create

		[Auth(Roles="Editor")]
		public ActionResult Create()
		{
			return View();
		}

		#endregion 
		
		#region POST: /Artigos/Create

		[HttpPost, Auth(Roles="Editor")]
		public ActionResult Create(Artigo form)
		{
			try
			{
				rep.Add(form);
				rep.Save();
				return RedirectToAction("Details", new { id = form.ArtigoID });
			}
			catch
			{
				return View();
			}
		}

		#endregion 

		#region GET: /Artigos/Edit/5
		[Auth(Roles = "Editor")]
		public ActionResult Edit(int id)
		{
			var art = rep.GetArtigo(id);
			if (art.isOwnerOrAdmin)
				return View(art);
			else
				return View("AcessoNegado");
		}
		#endregion 

		#region POST: /Artigos/Edit/5

		[HttpPost, Auth(Roles = "Editor"), ValidateInput(false)]
		public ActionResult Edit(int id, Artigo form)
		{
			var art = rep.GetArtigo(id);
			if (art.isOwnerOrAdmin)
			{
				UpdateModel(art);
				rep.Save();
				return RedirectToAction("Details", new { id = id });
			}
			else
				return View("AcessoNegado");
		}

		#endregion 

		#region GET: /Artigos/Delete/5
		[Auth(Roles = "Editor")]
		public ActionResult Delete(int id)
		{
			var art = rep.GetArtigo(id);
			if (art.isOwnerOrAdmin)
				return View(art);
			else
				return View("AcessoNegado");
		}

		#endregion 

		#region POST: /Artigos/Delete/5

		[HttpPost, Auth(Roles = "Editor")]
		public ActionResult Delete(int id, Artigo form)
		{
			var art = rep.GetArtigo(id);
			if (art.isOwnerOrAdmin)
			{
				rep.Delete(form);
				rep.Save();
				return RedirectToAction("Index");
			}
			else
				return View("AcessoNegado");
		}

		#endregion

		#region GET: /Artigos/Home
		public ActionResult Home()
		{
			return View(rep.ArtigosHome);
		}
		#endregion 

		#region GET: /Artigos/Editor/5
		public ActionResult Editor(int id)
		{
			return View(rep.ArtigosDoUsuario(id));
		}
		#endregion 
	}
}