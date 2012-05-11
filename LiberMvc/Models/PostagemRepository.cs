using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Data;
using System.Collections;
using System.Data.Entity;

namespace LiberMvc.Models
{
	public class PostagemRepository
	{

		#region Database

		public LiberDB db;
		public PostagemRepository() : this(new LiberDB()) { }
		public PostagemRepository(LiberDB context)
		{ 
		  db = context;
		}

		#endregion

		#region Artigo
		public IQueryable<Postagem> Artigos
		{
			get
			{
				return Postagens.Where(p => p.TipoPostagem.Descricao == "Artigo");
			}
		}
		public IQueryable<Postagem> ArtigosPublicados
		{
			get { return Artigos.Where(a => a.Publicado); }
		}
		public IQueryable<Postagem> ArtigosDoUsuario(int id)
		{
			return ArtigosPublicados.Where(p => p.Autores.Select(a => a.Autor.PessoaID).Contains(id));
		}
		#endregion

		#region Blog
		public IQueryable<Postagem> Blogs
		{
			get
			{
				return Postagens.Where(p => p.TipoPostagem.Descricao == "Blog");
			}
		}
		public IQueryable<Postagem> BlogsPublicados
		{
			get { return Blogs.Where(a => a.Publicado); }
		}
		public IQueryable<Postagem> BlogsDoUsuario(int id)
		{
			return BlogsPublicados.Where(p => p.Autores.Select(a => a.AutorID).Contains(id));
		}
		#endregion

		#region Video
		public IQueryable<Postagem> Videos
		{
			get
			{
				return Postagens.Where(p => p.TipoPostagem.Descricao == "Video");
			}
		}
		public IQueryable<Postagem> VideosPublicados
		{
			get { return Videos.Where(a => a.Publicado); }
		}
		public IQueryable<Postagem> VideosDoUsuario(int id)
		{
			return VideosPublicados.Where(p => p.Autores.Select(a => a.Autor.PessoaID).Contains(id));
		}
		#endregion

		#region Ideias
		public IQueryable<Postagem> Ideias
		{
			get
			{
				return Postagens;
			}
		}
		public IQueryable<Postagem> IdeiasPublicadas
		{
			get { return Ideias.Where(a => a.Publicado); }
		}
		public IQueryable<Postagem> IdeiasDoUsuario(int id)
		{
			return IdeiasPublicadas.Where(p => p.Autores.Select(a => a.Autor.PessoaID).Contains(id));
		}
		#endregion

		#region Postagem

		public IQueryable<Postagem> Postagens
		{
			get
			{
				return db.Postagens.Include(p => p.TipoPostagem)
					.OrderByDescending(a => a.PublicadoEm)
					.ThenByDescending(a => a.PostagemID);
			}
		}

		public IQueryable<TipoPostagem> TiposPostagem
		{
			get
			{
				return db.TiposPostagem;
			}
		}

		public Postagem GetPostagem(int id)
		{
			return db.Postagens.Include(p => p.TipoPostagem).SingleOrDefault(a => a.PostagemID == id);
		}

		public IQueryable<Autor> Autores
		{
			get
			{
				return db.Autores;
			}
		}
		#endregion

		#region Insert/Edit/Delete Methods

		public void Add(Postagem postagem)
		{
			postagem.CriadoEm = DateTime.Now;
			//postagem.EditorID = Usuario.Logado.ID;
			db.Postagens.Add(postagem);
		}

		public void Edit(Postagem postagem)
		{
			db.Entry(postagem).State = EntityState.Modified;
		}

		public void Delete(Postagem postagem)
		{
			db.Postagens.Remove(postagem);
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
			if (db != null)
				db.Dispose();
		}

		#endregion

	}
}