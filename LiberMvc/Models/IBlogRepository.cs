using System;
using System.Linq;
using System.Collections.Generic;
namespace LiberMvc.Models
{
	public interface IBlogRepository
	{
		IQueryable<Blog> Blogs { get; }
		IQueryable<Blog> BlogsHome { get; }
		IQueryable<Blog> BlogsPublicados { get; }
		IQueryable<Blog> BlogsDoUsuario(int id);
		Blog GetBlog(int id);

		void Add(Blog Blog);
		void Delete(Blog Blog);

		void Save();
		void Dispose();
	}
}
