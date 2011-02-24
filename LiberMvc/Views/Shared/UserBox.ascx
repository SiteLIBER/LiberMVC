﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Usuario>" %>
<%@ Import Namespace="LiberMvc.Models" %> 

<h1>Painel do usuário</h1>

<p id="user_informations">
    <%= Model.Nome %> |
    <%= Html.ActionLink("Meu Perfil", "Perfil", "Usuario", new { id = Model.UsuarioID }, null) %> |
    <%= Html.ActionLink("Sair", "LogOff", "Auth") %>
    <br />
    <strong><%= Model.TipoUsuario.Descricao %></strong>
</p>

<ul>
    <li><strong class="article">Artigos</strong>
        <ul>
            <% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin) { %>
            <li><%= Html.ActionLink("Novo", "Create", "Artigos")%></li>
            <% } %>

            <% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin) { %>
            <li><%= Html.ActionLink("Meus", "Editor", "Artigos", new { id = Model.UsuarioID }, null)%></li>
            <% } %>

            <% if (Usuario.Logado.isAdmin) { %>
            <li><%= Html.ActionLink("Todos", "Table", "Artigos")%></li>
            <% } else { %>
            <li><%= Html.ActionLink("Todos", "Index", "Artigos")%></li>
            <% } %>
        </ul>
    </li>

      <%-- <li><a href="#">Comentários</a></li>
      <li><a href="#">Últimas participações no fórum</a></li>
      <li><a href="#">Artigos favoritos</a></li>
      <li><a href="#">Contato</a></li> --%>
</ul>

<ul>
    <li><strong class="blog">Blog</strong>
        <ul>
            <% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin) { %>
            <li><%= Html.ActionLink("Novo", "Create", "Blog")%></li>
            <% } %>

            <% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin) { %>
            <li><%= Html.ActionLink("Meus", "Editor", "Blog", new { id = Model.UsuarioID }, null)%></li>
            <% } %>

            <% if (Usuario.Logado.isAdmin) { %>
            <li><%= Html.ActionLink("Todos", "Table", "Blog")%></li>
            <% } else { %>
            <li><%= Html.ActionLink("Todos", "Index", "Blog")%></li>
            <% } %>
        </ul>
    </li>

      <%-- <li><a href="#">Comentários</a></li>
      <li><a href="#">Últimas participações no fórum</a></li>
      <li><a href="#">Artigos favoritos</a></li>
      <li><a href="#">Contato</a></li> --%>
</ul>

