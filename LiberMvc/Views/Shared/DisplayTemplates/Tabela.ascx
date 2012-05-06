﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<LiberMvc.PaginatedList<LiberMvc.Models.Artigo>>" %>

<%@ Import Namespace="LiberMvc.Models" %>
<% var route = Url.RequestContext.RouteData.Values; %>
<table class="show_table">
    <thead>
        <tr>
            <th>Id</th>
            <th>Título</th>
            <th>Data de criação</th>
            <th>Data de publicação</th>
            <th>Autor</th>
            <th>Criado por</th>
            <th class="actions"></th>
        </tr>
    </thead>

    <tbody>
    <% foreach (var art in Model) { %>
        <tr class="<%= art.Publicado ? "published" : "unpublished" %>">
            <td>#<%= art.ArtigoID %></td>
            <td><%= Html.ActionLink(art.Titulo, "Details", "Artigos", new { id=art.ArtigoID }, null)%></td>
            <td><%= art.CriadoEm.ToShortDateString() %></td>
            <td>
                <% if (art.Publicado) { %>
                    <%= art.PublicadoEm.ToShortDateString()%>
                <% } else { %>
                    <%= "-" %>
                <% } %>
            </td>
            <td><%= Html.Label(art.Autor ?? art.Editor.Nome) %></td>
            <td><%= art.Editor.Nome %></td>
            <td>
                <a href="<%= Url.Action("Edit", "Artigos", new { id = art.ArtigoID }) %>"><img src="<%= Url.Content("~/Content/images/edit.png") %>" alt="Editar" /></a>
                <a href="<%= Url.Action("Delete", "Artigos", new { id = art.ArtigoID }) %>" class="destroy"><img src="<%= Url.Content("~/Content/images/destroy.png") %>" /></a>
            </td>
        </tr>
    <% } %>
    </tbody>
</table>

<div class="actions">
<% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin)	{ %>
	<%= Html.ActionLink("Criar novo", "Create", null, new { @class = "button" })%>
<% } %>

<% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin)	{ %>
    <%= Html.ActionLink("Listar para exibição", "Index", null, new { @class = "button" })%>
<% } %>

<% if (Model.HasPreviousPage) { %>
	<%= Html.ActionLink("<< Anterior", route["action"].ToString(), new { id = route["id"], page = (Model.PageIndex - 1) }, new { @class = "button" })%>
<% } %>

<% if (Model.HasNextPage)	{ %>
	<%= Html.ActionLink("Próxima >>", route["action"].ToString(), new { id = route["id"], page = (Model.PageIndex + 1) }, new { @class = "button" })%>
<% } %>
	<br class="clear" />
</div>

<script type="text/javascript">
	$(function () {
		$(".destroy").click(function (ev) {
			ev.preventDefault();
			var id = this.href;
			id = id.substring(id.lastIndexOf("/"));
			if (confirm("Deseja realmente apagar este artigo?"))
				window.location = '<%= Url.Action("ConfirmDelete") %>' + id;
		});
	});
</script>