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
	public class VideosController : Controller
	{
		#region Repository
		PostagemRepository rep;

		public VideosController()
		{
			rep = new PostagemRepository();
		}
		#endregion
		//
		// GET: /Videos/

		#region GET: /Videos/
		public ActionResult Index(int? page)
		{
			var videos = new PaginatedList<Postagem>(rep.VideosPublicados.Include(p => p.Autores), page ?? 0, 10);
			//rep.Dispose();
			return View(videos);
		}
		#endregion

		//#region GET: /Videos/Home
		//public PartialViewResult Home()
		//{
		//  var videos = new PaginatedList<Postagem>(rep.Videos, 0, 20);
		//  //rep.Dispose();
		//  return PartialView("_Home", videos);
		//}
		//#endregion

		#region Dispose
		protected override void Dispose(bool disposing)
		{
			rep.Dispose();
			base.Dispose(disposing);
		}
		#endregion

	}
}