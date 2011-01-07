using System;
using System.Linq;
namespace LiberMvc.Models
{
	public interface IUsuarioRepository
	{
		IQueryable<Usuario> ListaUsuarios();
		Usuario PegarUsuario(LoginModel form);
		Usuario PegarUsuario(int id);
		Usuario PegarUsuarioLogado();
		Usuario Cadastrar(CadastroModel form);
		PerfilModel PegarPerfil(int id);
		FiliacaoModel PegarFiliado();
		void Salvar();
	}
}
