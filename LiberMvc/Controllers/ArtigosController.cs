using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using Elmah;

namespace LiberMvc.Controllers
{
	public class ArtigosController : Controller
	{

		#region Repository
		PostagemRepository rep;

		public ArtigosController()
		{
			rep = new PostagemRepository();
		}
		#endregion

		#region GET: /Artigos/
		public ActionResult Index(int? page)
		{
			var artigos = new PaginatedList<Postagem>(rep.ArtigosPublicados.Include(p => p.Autores), page ?? 0, 10);
			//rep.Dispose();
			return View(artigos);
		}
		#endregion

		

		#region GET: /Artigos/Details/5

		public ActionResult Details(int? id)
		{
			return RedirectToAction("Details", "Postagem", new { id = id + 200 });
			//if (id.HasValue)
			//{
			//  var art = rep.GetPostagem(id.Value);
			//  if (art != null)
			//  {
			//    ViewBag.Title = art.Titulo;
			//    rep.Dispose();
			//    return (art.Publicado || art.isEditorOrAdmin) ? View(art) : View();
			//  }
			//}
			//return View("ItemNotFound");
		}

		#endregion


		#region GET: /Artigos/Home
		public PartialViewResult Home()
		{
			var artigos = new PaginatedList<Postagem>(rep.Artigos, 0, 20);
			//rep.Dispose();
			return PartialView("_Home", artigos);
		}
		#endregion

		#region Dispose
		protected override void Dispose(bool disposing)
		{
			rep.Dispose();
			base.Dispose(disposing);
		}
		#endregion

		//#region GET: /Artigos/Table
		//public ActionResult Table(int? page)
		//{

		//  var artigos = new PaginatedList<Postagem>(rep.Artigos, page ?? 0, 20);
		//  //rep.Dispose();
		//  return View(artigos);
		//}
		//#endregion
		//#region GET: /Artigos/Create

		//[Auth(Roles = "Editor")]
		//public ActionResult Create()
		//{
		//  rep.Dispose();
		//  return View();
		//}

		//#endregion

		//#region POST: /Artigos/Create

		//[ValidateInput(false), HttpPost, Auth(Roles = "Editor")]
		//public ActionResult Create(Artigo form)
		//{
		//  try
		//  {
		//    rep.Add(form);
		//    rep.Save();
		//    rep.Dispose();
		//    return RedirectToAction("Details", new { id = form.ArtigoID });
		//  }
		//  catch
		//  {
		//    return View();
		//  }
		//}

		//#endregion

		//#region GET: /Artigos/Edit/5
		//[Auth(Roles = "Editor")]
		//public ActionResult Edit(int id)
		//{
		//  var art = rep.GetArtigo(id);
		//  //rep.Dispose();
		//  if (art.isOwnerOrAdmin)
		//    return View(art);
		//  else
		//    return View("AcessoNegado");
		//}
		//#endregion

		//#region POST: /Artigos/Edit/5

		//[ValidateInput(false), HttpPost, Auth(Roles = "Editor")]
		//public ActionResult Edit(int id, Artigo form)
		//{
		//  var art = rep.GetArtigo(id);
		//  if (art.isOwnerOrAdmin)
		//  {
		//    UpdateModel(art);
		//    rep.Save();
		//    rep.Dispose();
		//    return RedirectToAction("Details", new { id = id });
		//  }
		//  else
		//    return View("AcessoNegado");
		//}

		//#endregion

		//#region GET: /Artigos/Delete/5
		//[Auth(Roles = "Editor")]
		//public ActionResult Delete(int id)
		//{
		//  var art = rep.GetArtigo(id);
		//  rep.Dispose();
		//  if (art.isOwnerOrAdmin)
		//    return View(art);
		//  else
		//    return View("AcessoNegado");
		//}

		//#endregion

		//#region POST: /Artigos/ConfirmDelete/5

		//[Auth(Roles = "Editor")]
		//public ActionResult ConfirmDelete(int id)
		//{
		//  var art = rep.GetArtigo(id);
		//  if (art.isOwnerOrAdmin)
		//  {
		//    rep.Delete(art);
		//    rep.Save();
		//    rep.Dispose();
		//    return RedirectToAction("Table");
		//  }
		//  else
		//    return View("AcessoNegado");
		//}

		//#endregion
		//#region GET: /Artigos/Editor/5
		//[Auth(Roles = "Editor")]
		//public ActionResult Editor(int id, int? page)
		//{
		//  var artigos = new PaginatedList<Artigo>(rep.ArtigosDoUsuario(id), page ?? 0, 5);
		//  if (artigos.Count() > 0)
		//    ViewData["Editor"] = artigos.FirstOrDefault().Editor.Nome;
		//  rep.Dispose();
		//  return View(artigos);
		//}
		//#endregion

	}
}