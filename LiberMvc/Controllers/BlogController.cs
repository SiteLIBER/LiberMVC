using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LiberMvc.Models;
using Elmah;

namespace LiberMvc.Controllers
{
	[Scc("Blog")]
	public class BlogController : Controller
	{
		#region Repository
		IBlogRepository rep;

		public BlogController() : this(new BlogRepository()) { }

		public BlogController(IBlogRepository repository)
		{
			rep = repository;
		}
		#endregion

		#region GET: /Blog/
		public ActionResult Index(int? page)
		{

			var blogs = new PaginatedList<Blog>(rep.BlogsPublicados, page ?? 0, 5);
			//blogs.ToList().Max(b => b.Editor.Nome);
			//rep.Dispose();
			return View(blogs);
		}
		#endregion

		#region GET: /Blog/Table
		public ActionResult Table(int? page)
		{

			var blogs = new PaginatedList<Blog>(rep.Blogs, page ?? 0, 20);
			//rep.Dispose();
			return View(blogs);
		}
		#endregion

		#region GET: /Blog/Details/5

		public ActionResult Details(int id)
		{
			var blog = rep.GetBlog(id);
			ViewData["Title"] = blog.Titulo;
			var ed = blog.Editor.Nome;
			rep.Dispose();
			return (blog.Publicado || blog.isOwnerOrAdmin) ? View(blog) : View();
		}

		#endregion

		#region GET: /Blog/Create

		[Auth(Roles = "Editor")]
		public ActionResult Create()
		{
			rep.Dispose();
			return View();
		}

		#endregion

		#region POST: /Blog/Create

		[ValidateInput(false), HttpPost, Auth(Roles = "Editor")]
		public ActionResult Create(Blog form)
		{
			try
			{
				rep.Add(form);
				rep.Save();
				rep.Dispose();
				return RedirectToAction("Details", new { id = form.BlogID });
			}
			catch
			{
				return View();
			}
		}

		#endregion

		#region GET: /Blog/Edit/5
		[Auth(Roles = "Editor")]
		public ActionResult Edit(int id)
		{
			var blog = rep.GetBlog(id);
			//rep.Dispose();
			if (blog.isOwnerOrAdmin)
				return View(blog);
			else
				return View("AcessoNegado");
		}
		#endregion

		#region POST: /Blog/Edit/5

		[ValidateInput(false), HttpPost, Auth(Roles = "Editor")]
		public ActionResult Edit(int id, Blog form)
		{
			var blog = rep.GetBlog(id);
			if (blog.isOwnerOrAdmin)
			{
				UpdateModel(blog);
				rep.Save();
				rep.Dispose();
				return RedirectToAction("Details", new { id = id });
			}
			else
				return View("AcessoNegado");
		}

		#endregion

		#region GET: /Blog/Delete/5
		[Auth(Roles = "Editor")]
		public ActionResult Delete(int id)
		{
			var blog = rep.GetBlog(id);
			rep.Dispose();
			if (blog.isOwnerOrAdmin)
				return View(blog);
			else
				return View("AcessoNegado");
		}

		#endregion

		#region POST: /Blog/ConfirmDelete/5

		[Auth(Roles = "Editor")]
		public ActionResult ConfirmDelete(int id)
		{
			var blog = rep.GetBlog(id);
			if (blog.isOwnerOrAdmin)
			{
				rep.Delete(blog);
				rep.Save();
				rep.Dispose();
				return RedirectToAction("Table");
			}
			else
				return View("AcessoNegado");
		}

		#endregion

		#region GET: /Blog/Home
		public ActionResult Home()
		{
			var blogs = rep.BlogsHome;
			//rep.Dispose();
			return View(blogs);
		}
		#endregion

		#region GET: /Blog/Editor/5
		[Auth(Roles = "Editor")]
		public ActionResult Editor(int id, int? page)
		{
			var blogs = new PaginatedList<Blog>(rep.BlogsDoUsuario(id), page ?? 0, 5);
			if (blogs.Count() > 0)
				ViewData["Editor"] = blogs.FirstOrDefault().Editor.Nome;
			rep.Dispose();
			return View(blogs);
		}
		#endregion
	}
}