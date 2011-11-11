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
	public class PaginaController : Controller
	{

		#region Repository
		private PaginaRepository rep;

		public PaginaController()
		{
			rep = new PaginaRepository();
		}
		#endregion
		//
		// GET: /Pagina/

		public ViewResult Index(string page)
		{
			Pagina pagina = rep.PegarPagina(page);
			if (pagina != null)
				return View(pagina);
			else
				return View("NotFound");
		}

		////
		//// GET: /Pagina/Details/5

		//public ViewResult Details(int id)
		//{
		//    return View(pagina);
		//}

		//
		// GET: /Pagina/Create

		//public ActionResult Create()
		//{
		//    ViewBag.MenuID = new SelectList(db.Menus, "MenuID", "Titulo");
		//    return View();
		//} 

		////
		//// POST: /Pagina/Create

		//[HttpPost]
		//public ActionResult Create(Pagina pagina)
		//{
		//    if (ModelState.IsValid)
		//    {
		//        db.Paginas.Add(pagina);
		//        db.SaveChanges();
		//        return RedirectToAction("Index");  
		//    }

		//    ViewBag.MenuID = new SelectList(db.Menus, "MenuID", "Titulo", pagina.MenuID);
		//    return View(pagina);
		//}

		////
		//// GET: /Pagina/Edit/5

		//public ActionResult Edit(int id)
		//{
		//    Pagina pagina = db.Paginas.Find(id);
		//    ViewBag.MenuID = new SelectList(db.Menus, "MenuID", "Titulo", pagina.MenuID);
		//    return View(pagina);
		//}

		////
		//// POST: /Pagina/Edit/5

		//[HttpPost]
		//public ActionResult Edit(Pagina pagina)
		//{
		//    if (ModelState.IsValid)
		//    {
		//        db.Entry(pagina).State = EntityState.Modified;
		//        db.SaveChanges();
		//        return RedirectToAction("Index");
		//    }
		//    ViewBag.MenuID = new SelectList(db.Menus, "MenuID", "Titulo", pagina.MenuID);
		//    return View(pagina);
		//}

		////
		//// GET: /Pagina/Delete/5

		//public ActionResult Delete(int id)
		//{
		//    Pagina pagina = db.Paginas.Find(id);
		//    return View(pagina);
		//}

		////
		//// POST: /Pagina/Delete/5

		//[HttpPost, ActionName("Delete")]
		//public ActionResult DeleteConfirmed(int id)
		//{            
		//    Pagina pagina = db.Paginas.Find(id);
		//    db.Paginas.Remove(pagina);
		//    db.SaveChanges();
		//    return RedirectToAction("Index");
		//}

		protected override void Dispose(bool disposing)
		{
			rep.Dispose();
			base.Dispose(disposing);
		}
	}
}