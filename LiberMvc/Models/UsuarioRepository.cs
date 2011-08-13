using System;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace LiberMvc.Models
{
	public class UsuarioRepository
	{
		#region Database
		internal LiberDB db;
		public UsuarioRepository() : this(new LiberDB()) { }
		public UsuarioRepository(LiberDB context)
		{ 
			db = context;
		}
		#endregion

		#region Queries
		public IQueryable<Usuario> ListaUsuarios
		{
			get
			{
				return db.Usuarios;
			}
		}
		public Usuario PegarUsuario(int id)
		{
			return db.Usuarios.FirstOrDefault(u => u.PessoaID == id);
		}
		public Usuario UsuarioLogado
		{
			get
			{
				return PegarUsuario(Usuario.Logado.ID);
			}
		}
		#endregion

		public Usuario PegarUsuario(LoginModel form)
		{
			return (from u in db.Usuarios
							where u.Email == form.Email
							& u.Senha == form.Senha
							select u).FirstOrDefault();
		}
		public Usuario Cadastrar(CadastroModel form) 
		{
			var u = form.Usuario;
			u.Email = u.Email.Trim();
			var q = db.Usuarios.Where(usr => usr.Email == u.Email);
			if (q.Count() > 0) return null;

			u = db.Usuarios.Add(u);
			
			u.Pessoa.Titulos.Add(new TituloPessoa
			{
				TituloID = db.Titulos.FirstOrDefault(t => t.Codigo == "Usuario").TituloID
			});

			return u;
		}
		public PerfilModel PegarPerfil(int id)
		{
			return new PerfilModel { 
				Usuario = db.Usuarios.FirstOrDefault(u => u.PessoaID == id)
			};
		}
		public FiliacaoModel PegarFiliado()
		{
			var pessoa = UsuarioLogado.Pessoa;
			var model = new FiliacaoModel
			{
				Pessoa = pessoa,
				ListaEstadoCivil = db.EstadoCivil,
				ListaGrauInstrucao = db.GrauInstrucao,
				Filiado = pessoa.Filiado
			};
			return model;
		}
		public void Salvar()
		{
			db.SaveChanges();
		}
	}
}