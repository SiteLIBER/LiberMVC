<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<LiberMvc.Models.Artigo>" %>

<h1><%= Html.Encode(Model.Titulo) %></h1>

<p class="general_informations">
	<span class="date"><%= Model.PublicadoEm.ToShortDateString() %></span>
    <span class="author"><%= Html.Encode(Model.Autor) %></span>
</p>

<div class="article_body">
	<%= Model.Conteudo %>
</div>