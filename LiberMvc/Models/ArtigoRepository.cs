using System;
using System.Linq;
using System.Web;
using AutoMapper;
namespace LiberMvc.Models
{
	public class ArtigoRepository : IArtigoRepository
	{
		DBDataContext db = new DBDataContext();

		#region Query Methods

		public IQueryable<Artigo> Artigos
		{
			get {
				return db.Artigos
					.OrderByDescending(a => a.PublicadoEm)
					.ThenByDescending(a => a.ArtigoID);
			}
		}
		public IQueryable<Artigo> ArtigosPublicados
		{
			get { return Artigos.Where(a => a.Publicado); }
		}
		public IQueryable<Artigo> ArtigosHome
		{
			get { return ArtigosPublicados.Take(10); }
		}
		public IQueryable<Artigo> ArtigosDoUsuario(int id)
		{
			return (Usuario.Logado.ID == id)
				? Artigos.Where(a => a.EditorID == id)
				: ArtigosPublicados.Where(a => a.EditorID == id);
		}
		public Artigo GetArtigo(int id)
		{
			return db.Artigos.SingleOrDefault(a => a.ArtigoID == id);
		}

		#endregion

		#region Insert/Delete Methods
		public void Add(Artigo artigo)
		{
			artigo.CriadoEm = DateTime.Now;
			artigo.EditorID = Usuario.Logado.ID;
			db.Artigos.InsertOnSubmit(artigo);
		}

		public void Delete(Artigo artigo)
		{
			db.Artigos.DeleteOnSubmit(artigo);
		}
		#endregion

		#region Persistence
		public void Save()
		{
			db.SubmitChanges();
		}
		#endregion

	}
}