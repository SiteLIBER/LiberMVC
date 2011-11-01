using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LiberMvc.Models
{
	public class LiberDB : DbContext
	{
		public DbSet<Usuario> Usuarios { get; set; }
		public DbSet<Pessoa> Pessoas { get; set; }
		public DbSet<TituloPessoa> TitulosPessoas { get; set; }
		public DbSet<Titulo> Titulos { get; set; }
		public DbSet<Filiado> Filiados { get; set; }
		public DbSet<Autor> Autores { get; set; }
		public DbSet<AutorPostagem> AutoresPostagens { get; set; }
		public DbSet<Postagem> Postagens { get; set; }
		public DbSet<TipoPostagem> TiposPostagem { get; set; }
		public DbSet<GrauInstrucao> GrauInstrucao { get; set; }
		public DbSet<EstadoCivil> EstadoCivil { get; set; }
		public DbSet<Pagina> Paginas { get; set; }
		public DbSet<Menu> Menus { get; set; }



		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			base.OnModelCreating(modelBuilder);
		}
	}
}