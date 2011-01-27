using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LiberMvc.Controllers
{
	public class PagSeguroController : Controller
	{

		// GET: /PagSeguro/Retorno
		public ActionResult Retorno()
		{
			return View();
		}

		// POST: /PagSeguro/Retorno
		[HttpPost]
		public ActionResult Retorno(FormCollection form)
		{
			// TODO: doacao => ganha liber 
			// anualidade => ganha liber, entra em prestacao de contas e no historico do usuario
			return View();
		}
	}
}
