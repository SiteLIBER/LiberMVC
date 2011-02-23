using System;
using System.Linq;
using System.Web;
using AutoMapper;
using System.Collections.Generic;
namespace LiberMvc.Models
{
	public class BlogRepository : IBlogRepository
	{

		#region Database
		public DBDataContext db;

		public BlogRepository() : this(new DBDataContext()) {	}

		public BlogRepository(DBDataContext context)
		{ 
		  db = context;
		}
		#endregion

		#region Query Methods

		public IQueryable<Blog> Blogs
		{
			get	{	return db.Blogs
							.OrderByDescending(a => a.PublicadoEm)
							.ThenByDescending(a => a.BlogID);
			} 
		}
		public IQueryable<Blog> BlogsPublicados
		{
			get { return Blogs.Where(a => a.Publicado); }
		}
		public IQueryable<Blog> BlogsHome
		{
			get { return BlogsPublicados.Take(5); }
		}
		public IQueryable<Blog> BlogsDoUsuario(int id)
		{
			return (Usuario.Logado.ID == id)
				? Blogs.Where(a => a.EditorID == id)
				: BlogsPublicados.Where(a => a.EditorID == id);
		}
		public Blog GetBlog(int id)
		{
			return db.Blogs.SingleOrDefault(a => a.BlogID == id);
		}

		#endregion

		#region Insert/Delete Methods

		public void Add(Blog Blog)
		{
			Blog.CriadoEm = DateTime.Now;
			Blog.EditorID = Usuario.Logado.ID;
			db.Blogs.InsertOnSubmit(Blog);
		}
		public void Delete(Blog Blog)
		{
			db.Blogs.DeleteOnSubmit(Blog);
		}

		#endregion

		#region Persistence

		public void Save()
		{
			db.SubmitChanges();
		}

		#endregion

		#region Free Memory

		public void Dispose()
		{ 
			db.Dispose();
		}

		#endregion

	}
}