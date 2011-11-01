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
	public class AdminPaginaController : Controller
	{
		private LiberDB db = new LiberDB();

		//
		// GET: /AdminPagina/

		public ViewResult Index()
		{
			var paginas = db.Paginas.Include(p => p.Menu);
			return View(paginas.ToList());
		}

		//
		// GET: /AdminPagina/Details/5

		public ViewResult Details(int id)
		{
			Pagina pagina = db.Paginas.Find(id);
			return View(pagina);
		}

		//
		// GET: /AdminPagina/Create

		public ActionResult Create()
		{
			ViewBag.MenuID = new SelectList(db.Menus, "MenuID", "Titulo");
			return View();
		}

		//
		// POST: /AdminPagina/Create

		[HttpPost]
		public ActionResult Create(Pagina pagina)
		{
			if (ModelState.IsValid)
			{
				db.Paginas.Add(pagina);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			ViewBag.MenuID = new SelectList(db.Menus, "MenuID", "Titulo", pagina.MenuID);
			return View(pagina);
		}

		//
		// GET: /AdminPagina/Edit/5

		public ActionResult Edit(int id)
		{
			Pagina pagina = db.Paginas.Find(id);
			ViewBag.MenuID = new SelectList(db.Menus, "MenuID", "Titulo", pagina.MenuID);
			return View(pagina);
		}

		//
		// POST: /AdminPagina/Edit/5

		[HttpPost]
		public ActionResult Edit(Pagina pagina)
		{
			if (ModelState.IsValid)
			{
				db.Entry(pagina).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			ViewBag.MenuID = new SelectList(db.Menus, "MenuID", "Titulo", pagina.MenuID);
			return View(pagina);
		}

		//
		// GET: /AdminPagina/Delete/5

		public ActionResult Delete(int id)
		{
			Pagina pagina = db.Paginas.Find(id);
			return View(pagina);
		}

		//
		// POST: /AdminPagina/Delete/5

		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int id)
		{
			Pagina pagina = db.Paginas.Find(id);
			db.Paginas.Remove(pagina);
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		protected override void Dispose(bool disposing)
		{
			db.Dispose();
			base.Dispose(disposing);
		}
	}
}