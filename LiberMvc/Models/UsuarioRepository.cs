using System;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Collections.Generic;

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
		public Usuario PegarUsuario(LoginModel form)
		{
			return (from u in db.Usuarios
							where u.Email == form.Email
							& u.Senha == form.Senha
							select u).FirstOrDefault();
		}
		public Usuario PegarUsuarioDoFacebook(Int64 facebookId)
		{
			return db.Usuarios.FirstOrDefault(u => u.FacebookID == facebookId);
		}
		#endregion




		public Usuario Cadastrar(CadastroModel form) 
		{
			var u = form.Usuario;
			u.Email = u.Email.Trim();
			var q = db.Usuarios.Where(usr => usr.Email == u.Email);
			if (q.Count() > 0) return null;
			u.CriadoEm = DateTime.Now;
			u.Pessoa = new Pessoa { 
				Nome = "",
				Naturalidade = "",
				NomePai = "",
				NomeMae = "",
				Profissao = "",
				Telefone = "",
				DataNasc = DateTime.Now,
				EstadoCivilID = 1,
 				GrauInstrucaoID = 1
			};
			u.Pessoa.Endereco = new Endereco { 
				Logradouro = "",
				Cidade = "",
				Estado = "",
				CEP = ""
			};
			u.Pessoa.Titulos = new List<TituloPessoa>();
			u.Pessoa.Titulos.Add(new TituloPessoa
			{
				TituloID = db.Titulos.FirstOrDefault(t => t.Codigo == "Usuario").TituloID
			});
			u = db.Usuarios.Add(u);
			
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
			if (pessoa.Filiado == null)
			{
				pessoa.Filiado = new Filiado
				{
					Pessoa = pessoa,
					PessoaID = pessoa.PessoaID,
					FiliadoEm = DateTime.Now
				};
			}
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