<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<LiberMvc.PaginatedList<LiberMvc.Models.Artigo>>" %>
<%@ Import Namespace="LiberMvc.Models" %>
<% var route = Url.RequestContext.RouteData.Values; %>


<table>
    <thead>
        <tr>
            <th>Título</th>
            <th>Data de publicação</th>
            <th>Autor</th>
        </tr>
    </thead>

    <tbody>
    <% foreach (var art in Model) { %>
        <tr>
            <td><%= art.Titulo %></td>
            <td><%= art.PublicadoEm.ToShortDateString() %></td>
            <td><%= Html.Label(art.Autor ?? art.Editor.Nome) %></td>
        </tr>
    <% } %>
    </tbody>
</table>

<div class="actions">
<% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin)	{ %>
	<%= Html.ActionLink("Criar Novo", "Create", null, new { @class = "button" })%>
<% } %>
<% if (Model.HasPreviousPage) { %>
	<%= Html.ActionLink("<<< Anterior", route["action"].ToString(), new { id = route["id"], page = (Model.PageIndex - 1) }, new { @class = "button" })%>
<% } %>
<% if (Model.HasNextPage)	{ %>
	<%= Html.ActionLink("Próxima >>>", route["action"].ToString(), new { id = route["id"], page = (Model.PageIndex + 1) }, new { @class = "button" })%>
<% } %>
	<br class="clear" />
</div>
