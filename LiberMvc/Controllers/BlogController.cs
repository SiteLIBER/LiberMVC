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
	public class BlogController : Controller
	{
		#region Repository
		PostagemRepository rep;

		public BlogController()
		{
			rep = new PostagemRepository();
		}
		#endregion

		#region GET: /Blog/
		public ActionResult Index(int? page)
		{
			var blogs = new PaginatedList<Postagem>(rep.BlogsPublicados.Include(p => p.Autores), page ?? 0, 10);
			return View(blogs);
		}
		#endregion



		#region GET: /Blog/Details/5

		public ActionResult Details(int? id)
		{
			return RedirectToAction("Details", "Postagem", new { id = id });
		}

		#endregion

		

		#region GET: /Blog/Home
		public PartialViewResult Home()
		{
			var blogs = new PaginatedList<Postagem>(rep.Blogs, 0, 20);
			//rep.Dispose();
			return PartialView("_Home", blogs);
		}
		#endregion

		protected override void Dispose(bool disposing)
		{
			rep.Dispose();
			base.Dispose(disposing);
		}

//#region GET: /Blog/Table
		//public ActionResult Table(int? page)
		//{
		//  var blogs = new PaginatedList<Postagem>(rep.Blogs, page ?? 0, 20);
		//  //rep.Dispose();
		//  return View(blogs);
		//}
		//#endregion
		//#region GET: /Blog/Create

		//[Auth(Roles = "Editor")]
		//public ActionResult Create()
		//{
		//  rep.Dispose();
		//  return View();
		//}

		//#endregion

		//#region POST: /Blog/Create

		//[ValidateInput(false), HttpPost, Auth(Roles = "Editor")]
		//public ActionResult Create(Po form)
		//{
		//  try
		//  {
		//    rep.Add(form);
		//    rep.Save();
		//    rep.Dispose();
		//    return RedirectToAction("Details", new { id = form.BlogID });
		//  }
		//  catch
		//  {
		//    return View();
		//  }
		//}

		//#endregion

		//#region GET: /Blog/Edit/5
		//[Auth(Roles = "Editor")]
		//public ActionResult Edit(int id)
		//{
		//  var blog = rep.GetBlog(id);
		//  //rep.Dispose();
		//  if (blog.isOwnerOrAdmin)
		//    return View(blog);
		//  else
		//    return View("AcessoNegado");
		//}
		//#endregion

		//#region POST: /Blog/Edit/5

		//[ValidateInput(false), HttpPost, Auth(Roles = "Editor")]
		//public ActionResult Edit(int id, Blog form)
		//{
		//  var blog = rep.GetBlog(id);
		//  if (blog.isOwnerOrAdmin)
		//  {
		//    UpdateModel(blog);
		//    rep.Save();
		//    rep.Dispose();
		//    return RedirectToAction("Details", new { id = id });
		//  }
		//  else
		//    return View("AcessoNegado");
		//}

		//#endregion

		//#region GET: /Blog/Delete/5
		//[Auth(Roles = "Editor")]
		//public ActionResult Delete(int id)
		//{
		//  var blog = rep.GetBlog(id);
		//  //rep.Dispose();
		//  if (blog.isOwnerOrAdmin)
		//    return View(blog);
		//  else
		//    return View("AcessoNegado");
		//}

		//#endregion

		//#region POST: /Blog/ConfirmDelete/5

		//[Auth(Roles = "Editor")]
		//public ActionResult ConfirmDelete(int id)
		//{
		//  var blog = rep.GetBlog(id);
		//  if (blog.isOwnerOrAdmin)
		//  {
		//    rep.Delete(blog);
		//    rep.Save();
		//    rep.Dispose();
		//    return RedirectToAction("Table");
		//  }
		//  else
		//    return View("AcessoNegado");
		//}

		//#endregion
		//#region GET: /Blog/Editor/5
		//[Auth(Roles = "Editor")]
		//public ActionResult Editor(int id, int? page)
		//{
		//  var blogs = new PaginatedList<Blog>(rep.BlogsDoUsuario(id), page ?? 0, 5);
		//  if (blogs.Count() > 0)
		//    ViewData["Editor"] = blogs.FirstOrDefault().Editor.Nome;
		//  //rep.Dispose();
		//  return View(blogs);
		//}
		//#endregion
	}
}