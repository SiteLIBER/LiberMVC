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
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
					"Default", // Route name
					"{controller}.aspx/{action}/{id}", // URL with parameters
					new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);
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