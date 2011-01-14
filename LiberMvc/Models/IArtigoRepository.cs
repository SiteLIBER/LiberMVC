using System;
using System.Linq;
using System.Collections.Generic;
namespace LiberMvc.Models
{
	public interface IArtigoRepository
	{
		List<Artigo> Artigos { get; }
		List<Artigo> ArtigosHome { get; }
		List<Artigo> ArtigosPublicados { get; }
		List<Artigo> ArtigosDoUsuario(int id);
		Artigo GetArtigo(int id);

		void Add(Artigo artigo);
		void Delete(Artigo artigo);

		void Save();

	}
}
