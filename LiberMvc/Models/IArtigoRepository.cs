using System;
using System.Linq;
using System.Collections.Generic;
namespace LiberMvc.Models
{
	public interface IArtigoRepository
	{
		IQueryable<Artigo> Artigos { get; }
		IQueryable<Artigo> ArtigosHome { get; }
		IQueryable<Artigo> ArtigosPublicados { get; }
		IQueryable<Artigo> ArtigosDoUsuario(int id);
		Artigo GetArtigo(int id);

		void Add(Artigo artigo);
		void Delete(Artigo artigo);

		void Save();
		void Dispose();
	}
}
