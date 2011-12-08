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
	[Auth(Roles="Editor")]
	public class AdminPaginaController : Controller
	{
		#region Repository
		PaginaRepository rep;

		public AdminPaginaController()
		{
			rep = new PaginaRepository();
		}
		#endregion

		#region GET: /AdminPagina/

		public ViewResult Index()
		{
			return View(rep.ListaPaginas);
		}
		#endregion

		#region GET: /AdminPagina/Details/5

		public ViewResult Details(int id)
		{
			Pagina pagina = rep.PegarPagina(id);
			return View(pagina);
		}

		#endregion

		#region GET: /AdminPagina/Create

		public ActionResult Create()
		{
			return View();
		}

		#endregion

		#region POST: /AdminPagina/Create

		[HttpPost]
		public ActionResult Create(Pagina pagina)
	{
			if (ModelState.IsValid)
			{
				try 
				{
					rep.Add(pagina);
					rep.Save();
					return RedirectToAction("Details", new { id = pagina.PaginaID });
				}
				catch (Exception err)
				{
					return View("Error", err);
				}
			}

			return View(pagina);
		}

		#endregion

		#region GET: /AdminPagina/Edit/5

		public ActionResult Edit(int id)
		{
			var pagina = rep.PegarPagina(id);
			return View(pagina);
		}
		
		#endregion

		#region  POST: /AdminPagina/Edit/5
		
		[HttpPost]
		public ActionResult Edit(int id, Pagina pagina)
		{
			if (ModelState.IsValid)
			{
				try
				{
					rep.Edit(pagina);
					rep.Save();
					rep.Dispose();
					return RedirectToAction("Details", new { id = id });
				}
				catch (Exception err)
				{
					return View("Error", err);
				}
			}
			return View(pagina);
		}

		#endregion

		#region  GET: /AdminPagina/Delete/5
		
		public ActionResult Delete(int id)
		{
			var pagina = rep.PegarPagina(id);
			rep.Dispose();
			return View(pagina);
		}

		#endregion

		#region POST: /AdminPagina/Delete/5
		
		[HttpPost, ActionName("Delete")]
		public ActionResult DeleteConfirmed(int id)
		{
			var pagina = rep.PegarPagina(id);
			rep.Delete(pagina);
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