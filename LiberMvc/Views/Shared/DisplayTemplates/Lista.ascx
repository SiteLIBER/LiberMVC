﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<LiberMvc.PaginatedList<LiberMvc.Models.Artigo>>" %>
<% foreach (var art in Model)
	 { %>
<div class="article_resume">
	<h2>
		<%= Html.ActionLink(art.Titulo, "Details", "Artigos", new { id=art.ArtigoID }, null)%>
	</h2>
	<p class="general_informations">
		<span class="date">
			<%= art.PublicadoEm.ToShortDateString() %></span> <span class="author">Por
				<%= Html.Label(art.Autor ?? art.Editor.Nome) %>
				<%--<%= Html.ActionLink(art.Editor.Nome, "Editor", "Artigos", new { id=art.EditorID }, null) %>--%>
			</span>
	</p>
	<p class="abstract">
		<%= art.Chamada %>
	</p>
</div>
<% } %>
<div class="actions">
	<% if (Model.HasPreviousPage)
		{ %>
	<%= Html.ActionLink("<<< Anterior", "Editor", new {id = Url.RequestContext.RouteData.Values["id"], page = (Model.PageIndex - 1) }, new { @class="button" })%>
	<% } %>
	<% if (Model.HasNextPage)
		{ %>
	<%= Html.ActionLink("Próxima >>>", "Editor", new { id = Url.RequestContext.RouteData.Values["id"], page = (Model.PageIndex + 1) }, new { @class = "button" })%>
	<% } %>
</div>