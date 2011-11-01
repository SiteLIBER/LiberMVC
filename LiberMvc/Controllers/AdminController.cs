using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace LiberMvc.Controllers
{
	[Auth(Roles = "Editor")]
	public class AdminController : Controller
	{
		//
		// GET: /Admin/

		public ActionResult Index()
		{
			return View();
		}


		/// <summary>
		/// upload a file.
		/// ALERT: form must have: enctype="multipart/form-data"
		/// </summary>
		/// <param name="file"></param>
		/// <returns></returns>
		[HttpPost]
		public ActionResult UploadImage(HttpPostedFileBase file)
		{

			if (file.ContentLength > 0)
			{
				var fileName = Path.GetFileName(file.FileName);
				var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
				file.SaveAs(path);
			}

			return RedirectToAction("Index");
		}

		/// <summary>
		/// upload multiple files.
		/// ALERT: form must have: enctype="multipart/form-data"
		/// </summary>
		/// <param name="files"></param>
		/// <returns></returns>
		[HttpPost]
		public ActionResult UploadMultipleImages(IEnumerable<HttpPostedFileBase> files)
		{
			foreach (var file in files)
			{
				if (file.ContentLength > 0)
				{
					var fileName = Path.GetFileName(file.FileName);
					var path = Path.Combine(Server.MapPath("~/App_Data/uploads"), fileName);
					file.SaveAs(path);
				}
			}
			return RedirectToAction("Index");
		}
	}

}
