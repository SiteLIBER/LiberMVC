using System;
using System.Linq;
using System.Web;
using AutoMapper;
using System.Web.Security;

namespace LiberMvc.Models
{
	public class UsuarioRepository : IUsuarioRepository
	{
		DBDataContext db = new DBDataContext();
		public IQueryable<Usuario> ListaUsuarios()
		{
			return db.Usuarios;
		}
		public Usuario PegarUsuario(int id)
		{
			return db.Usuarios.FirstOrDefault(u => u.UsuarioID == id);
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

			Usuario u = Mapper.Map<CadastroModel, Usuario>(form);
			u.TipoUsuario = db.TipoUsuarios.FirstOrDefault(t => t.Descricao == "Usuario");
			db.Usuarios.InsertOnSubmit(u);
			return u;
		}
		public PerfilModel PegarPerfil(int id)
		{
			return Mapper.Map<Usuario, PerfilModel>(db.Usuarios.FirstOrDefault(u => u.UsuarioID == id));
		}
		public FiliacaoModel PegarFiliado()
		{
			var model = Mapper.Map<Usuario, FiliacaoModel>(PegarUsuarioLogado());
			model.ListaEstadoCivil = db.EstadoCivils;
			model.ListaGrauInstrucao = db.GrauInstrucaos;
			return model;
		}
		public void Salvar()
		{
			db.SubmitChanges();
		}
	}
}