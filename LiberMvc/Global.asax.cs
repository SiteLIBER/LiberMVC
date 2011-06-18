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
			//routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });

			#region remove old stuff - disabled
			//routes.IgnoreRoute("{*stats}", new { stats = @"stats(/.*)?" });
			////routes.IgnoreRoute("{*folder}/{*pathInfo}", new { folder = "stats" });
			//routes.IgnoreRoute("{*php}", new { php = @".*\.php(/.*)?" });
			////routes.IgnoreRoute("{*folder}/{*pathInfo}", new { folder = "index.php" });
			//routes.IgnoreRoute("{*rss}", new { rss = @"(.*)?rss(\.xml)?(/.*)?" });
			////routes.IgnoreRoute("{*folder}/{*pathInfo}", new { folder = "rss.xml" });
			////routes.IgnoreRoute("{*folder}/{*pathInfo}", new { folder = "crss" });
			//routes.IgnoreRoute("{*user}", new { user = @"user(/.*)?" });
			////routes.IgnoreRoute("{*folder}/{*pathInfo}", new { folder = "user" });
			//routes.IgnoreRoute("{*files}", new { files = @"files(/.*)?" });
			////routes.IgnoreRoute("{*folder}/{*pathInfo}", new { folder = "files" });
			//routes.IgnoreRoute("{*forum}", new { forum = @"forum(/.*)?" });
			////routes.IgnoreRoute("{*folder}/{*pathInfo}", new { folder = "forum" });
			#endregion

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

			#region AutoMapper Declarations
			Mapper.CreateMap<Usuario, FiliacaoModel>();
			Mapper.CreateMap<FiliacaoModel, Usuario>();

			Mapper.CreateMap<CadastroModel, Usuario>();

			Mapper.CreateMap<PerfilModel, Usuario>();
			Mapper.CreateMap<Usuario, PerfilModel>();
			#endregion
		
			RegisterRoutes(RouteTable.Routes);
		}
	}
}