using System;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace LiberMvc.Models
{
	public class UsuarioRepository
	{
		LiberDB db = new LiberDB();
		public IQueryable<Usuario> ListaUsuarios()
		{
			return db.Usuarios;
		}
		public Usuario PegarUsuario(int id)
		{
			return db.Usuarios.FirstOrDefault(u => u.PessoaID == id);
		}
		public Usuario PegarUsuario(LoginModel form)
		{
			return (from u in db.Usuarios
							where u.Email == form.Email
							& u.Senha == form.Senha
							select u).FirstOrDefault();
		}
		public Usuario PegarUsuarioLogado()
		{
			return PegarUsuario(Usuario.Logado.ID);
		}
		public Usuario Cadastrar(CadastroModel form) 
		{
			form.Email = form.Email.Trim();
			var q = db.Usuarios.Where(usr => usr.Email == form.Email);
			if (q.Count() > 0) return null;

			Usuario u = form as ICadastroModel as Usuario;
			u.Pessoa.Titulos.Add(new TituloPessoa
			{
				TituloID = db.Titulos.FirstOrDefault(t => t.Codigo == "Usuario").TituloID
			});

			db.Usuarios.Add(u);
			return u;
		}
		public PerfilModel PegarPerfil(int id)
		{
			return db.Usuarios.FirstOrDefault(u => u.PessoaID == id) as IPerfilModel as PerfilModel;
		}
		public FiliacaoModel PegarFiliado()
		{
			var model = PegarUsuarioLogado() as IEndereco as FiliacaoModel;
			model.ListaEstadoCivil = db.EstadoCivil;
			model.ListaGrauInstrucao = db.GrauInstrucao;
			return model;
		}
		public void Salvar()
		{
			db.SaveChanges();
		}
	}
}