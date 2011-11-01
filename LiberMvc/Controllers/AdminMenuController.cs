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
	public class AdminMenuController : Controller
	{
		private LiberDB db = new LiberDB();

		//
		// GET: /AdminMenu/

		public ViewResult Index()
		{
			var menus = db.Menus.Include(m => m.Root);
			return View(menus.ToList());
		}

		//
		// GET: /AdminMenu/Details/5

		public ViewResult Details(int id)
		{
			Menu menu = db.Menus.Find(id);
			return View(menu);
		}

		//
		// GET: /AdminMenu/Create

		public ActionResult Create()
		{
			ViewBag.RootID = new SelectList(db.Menus, "MenuID", "Titulo");
			return View();
		}

		//
		// POST: /AdminMenu/Create

		[HttpPost]
		public ActionResult Create(Menu menu)
		{
			if (ModelState.IsValid)
			{
				db.Menus.Add(menu);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			ViewBag.RootID = new SelectList(db.Menus, "MenuID", "Titulo", menu.RootID);
			return View(menu);
		}

		//
		// GET: /AdminMenu/Edit/5

		public ActionResult Edit(int id)
		{
			Menu menu = db.Menus.Find(id);
			ViewBag.RootID = new SelectList(db.Menus, "MenuID", "Titulo", menu.RootID);
			return View(menu);
		}

		//
		// POST: /AdminMenu/Edit/5

		[HttpPost]
		public ActionResult Edit(Menu menu)
		{
			if (ModelState.IsValid)
			{
				db.Entry(menu).State = EntityState.Modified;
				db.SaveChanges();
				return RedirectToAction("Index");
			}
			ViewBag.RootID = new SelectList(db.Menus, "MenuID", "Titulo", menu.RootID);
			return View(menu);
		}

		//
		// GET: /AdminMenu/Delete/5

		public ActionResult Delete(int id)
		{
			Menu menu = db.Menus.Find(id);
			return View(menu);
		}

		//
		// POST: /AdminMenu/Delete/5

		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int id)
		{
			Menu menu = db.Menus.Find(id);
			db.Menus.Remove(menu);
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