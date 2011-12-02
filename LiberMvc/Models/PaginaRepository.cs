using System;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Collections.Generic;
using System.Data;

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

		#region Insert/Edit/Delete Methods

		public void Add(Pagina pagina)
		{
			pagina.CriadoEm = DateTime.Now;
			db.Paginas.Add(pagina);
		}

		public void Edit(Pagina pagina)
		{
			db.Entry(pagina).State = EntityState.Modified;
		}

		public void Delete(Pagina pagina)
		{
			db.Paginas.Remove(pagina);
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