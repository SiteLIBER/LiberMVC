using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiberMvc.Controllers
{
	[HandleError(View = "Error")]
	public class LiberController : Controller
	{
		//
		// GET: /Liber/

		public ActionResult Index()
		{
			return RedirectToAction("Programa");
		}

		public ActionResult Historia()
		{
			return View();
		}

		public ActionResult Filosofia()
		{
			return View();
		}

		public ActionResult Programa()
		{
			return View();
		}

		public ActionResult Estatuto()
		{
			return View();
		}

		public ActionResult Lideranca()
		{
			return View();
		}

        public ActionResult Liber500()
        {
            return View();
        }

		public ActionResult Direitos()
		{
			return View();
		}

		public ActionResult Economia()
		{
			return View();
		}

		public ActionResult Domestico()
		{
			return View();
		}

		public ActionResult Exterior()
		{
			return View();
		}

		public ActionResult Doacao()
		{
			return View(LiberMvc.Models.Usuario.Logado.ID);
		}

		public ActionResult Divulgacao()
		{
			return View();
		}

		public ActionResult Contato()
		{
			return View();
		}

		public ActionResult Imprensa()
		{
			return View();
		}

		public ActionResult Diretorios()
		{
			return View();
		}

		public ActionResult FAQ()
		{
			return View();
		}

		public ActionResult Contas()
		{
			return View();
		}

	}
}
