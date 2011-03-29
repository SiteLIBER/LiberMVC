using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
namespace LiberMvc
{
	using Models;
	using System.Web.Caching;
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			
			routes.MapRoute(
					"Default", // Route name
					"{controller}/{action}/{id}", // URL with parameters
					new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);
		}

		protected void Session_Start(object sender, EventArgs e)
		{
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
		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			Mapper.CreateMap<Usuario, FiliacaoModel>();
			Mapper.CreateMap<FiliacaoModel, Usuario>();
			
			Mapper.CreateMap<CadastroModel, Usuario>();
			
			Mapper.CreateMap<PerfilModel, Usuario>();
			Mapper.CreateMap<Usuario, PerfilModel>();
		
			RegisterRoutes(RouteTable.Routes);
		}
	}
}