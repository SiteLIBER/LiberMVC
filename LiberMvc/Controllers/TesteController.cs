using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;

namespace LiberMvc.Controllers
{
	[Auth(Roles = "Admin")]
	public class TesteController : Controller
    {
        //
        // GET: /Teste/

        public JsonResult Index()
        {
					var db = new LiberDB();
					return Json(db.Titulos, JsonRequestBehavior.AllowGet);
        }

				public ActionResult RouteRedirect()
				{
					var t = new LiberDB();
					return View(t.Pessoas.First());
				}

				public PartialViewResult Route()
				{
					ViewBag.Teste = 1;
					
					return PartialView();
				}
    }
}
