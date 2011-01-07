<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Usuario>" %>
<%@ Import Namespace="LiberMvc.Models" %> 
	<h1><%= Model.Nome + " [" + Model.TipoUsuario.Descricao + "]" %></h1>

  <ul>
      <li><%= Html.ActionLink("Meu Perfil", "Perfil", "Usuario", new { id = Model.UsuarioID }, null) %></li>
			<% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin) { %>
			<li><%= Html.ActionLink("Meus Artigos", "Editor", "Artigos", new { id = Model.UsuarioID }, null)%></li>
			<% } %>
      <%-- <li><a href="#">Comentários</a></li>
      <li><a href="#">Últimas participações no fórum</a></li>
      <li><a href="#">Artigos favoritos</a></li>
      <li><a href="#">Contato</a></li> --%>
      <li><%= Html.ActionLink("Sair", "LogOff", "Auth") %></li>
  </ul>

