using System;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Collections.Generic;

namespace LiberMvc.Models
{
	public class PaginaRepository
	{
		#region Database
		internal LiberDB db;
		public PaginaRepository() : this(new LiberDB()) { }
		public PaginaRepository(LiberDB context)
		{ 
			db = context;
		}
		#endregion

		#region Queries
		public IQueryable<Pagina> ListaPaginas
		{
			get
			{
				return db.Paginas;
			}
		}
		public Pagina PegarPagina(int id)
		{
			return db.Paginas.FirstOrDefault(u => u.PaginaID == id);
		}
		public Pagina PegarPagina(string page)
		{
			return db.Paginas.FirstOrDefault(m => m.Link == page);
		}
		#endregion



		#region Persistence

		public void Save()
		{
			db.SaveChanges();
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