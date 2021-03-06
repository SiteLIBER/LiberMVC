﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace LiberMvc
{
	using Models;
	using System.Web.Caching;
	using System.Data.Entity;
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

			routes.MapRoute(
					"Postagem", // Route name
					"P/{id}/{title}", // URL with parameters
					new { controller = "Postagem", action = "Details", id = 0, title = UrlParameter.Optional }, // Parameter defaults
					new { id = @"\d+" }
			);

			routes.MapRoute(
					"Liber", // Route name
					"Liber/{page}", // URL with parameters
					new { controller = "Pagina", action = "Index", page = "" } // Parameter defaults
			);

            routes.MapRoute(
                    "Agenda", // Route name
                    "Agenda/{id}/{title}", // URL with parameters
                    new { controller = "Agenda", action = "Details", id = 0, title = UrlParameter.Optional }, // Parameter defaults
                    new { id = @"\d+" }
            );

            routes.MapRoute(
					"Default", // Route name
					"{controller}/{action}/{id}", // URL with parameters
					new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);
		}

		protected void Session_Start(object sender, EventArgs e)
		{
			#region fix session exception when download breaks by user
			string sessionId = Session.SessionID;
			#endregion

			#region redirect to correct url
			var url = HttpContext.Current.Request.Url.AbsoluteUri;
			if (url.IndexOf("pliber.org.br") < 0)
			{
				if (url.IndexOf("www") < 0)
					url = url.Replace("//", "//www.");
				if (url.IndexOf("libertarios.com.br") > -1)
					HttpContext.Current.Response.Redirect(url.Replace("libertarios.com.br", "pliber.org.br"), true);
				if (url.IndexOf("pliber.org") > -1)
					HttpContext.Current.Response.Redirect(url.Replace("pliber.org", "pliber.org.br"), true);
			}
			else
			{
				if (url.IndexOf("www") < 0)
					HttpContext.Current.Response.Redirect(url.Replace("//", "//www."), true);
			}
			#endregion
		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			
			//Database.SetInitializer(new LiberDBInitializer());
		
			RegisterRoutes(RouteTable.Routes);
		}
	}
}