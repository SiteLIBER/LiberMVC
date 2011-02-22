<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<LiberMvc.PaginatedList<LiberMvc.Models.Artigo>>" %>

<%@ Import Namespace="LiberMvc.Models" %>
<% var route = Url.RequestContext.RouteData.Values; %>

<% foreach (var art in Model) { %>
<div class="article_resume">
	<h2>
		<%= Html.ActionLink(art.Titulo, "Details", "Artigos", new { id=art.ArtigoID }, null)%>
	</h2>
	<p class="general_informations">
		<span class="date"><%= art.PublicadoEm.ToShortDateString() %></span>
		<span class="author">
			Por <%= Html.Label(art.Autor ?? art.Editor.Nome) %>
			<%--<%= Html.ActionLink(art.Editor.Nome, "Editor", "Artigos", new { id=art.EditorID }, null) %>--%>
		</span>
	</p>
	<p class="abstract">
		<%= art.Chamada %>
	</p>
</div>
<% } %>

<div class="actions">
<% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin) { %>
	<%= Html.ActionLink("Criar novo", "Create", null, new { @class = "button" })%>
<% } %>

<% if (Usuario.Logado.isAdmin) { %>
	<%= Html.ActionLink("Listar para edição", "Table", null, new { @class = "button" })%>
<% } %>

<% if (Model.HasPreviousPage) { %>
	<%= Html.ActionLink("<< Anterior", route["action"].ToString(), new { id = route["id"], page = (Model.PageIndex - 1) }, new { @class = "button" })%>
<% } %>

<% if (Model.HasNextPage)	{ %>
	<%= Html.ActionLink("Próxima >>", route["action"].ToString(), new { id = route["id"], page = (Model.PageIndex + 1) }, new { @class = "button" })%>
<% } %>

	<br class="clear" />
</div>
