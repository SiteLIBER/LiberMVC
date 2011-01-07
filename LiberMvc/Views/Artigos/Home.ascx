<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Artigo>>" %>
<%@ Import Namespace="LiberMvc.Models" %>
<!-- ARTICLES BEGIN -->
<div class="panel" id="artigos">
	
	<h1>Artigos</h1>
	<%
			var first = Model.First();
			var others = Model.Skip(1);
	%>
	<div id="artigo_destaque">
		<h2>
			<%= Html.ActionLink(first.Titulo, "Details", "Artigos", new { id=first.ArtigoID }, null)%>
		</h2>
		<p class="general_informations">
			<%= first.PublicadoEm.ToShortDateString() %> - 
			<span class="author">
				Por <%= Html.Label((!String.IsNullOrEmpty(first.Autor)) ? first.Autor : first.Editor.Nome) %>
<%--				<% if (!String.IsNullOrEmpty(first.Autor)) { %>
				 <%= Html.ActionLink(first.Autor, "Autor", "Artigos", new { id=first.Autor }, null) %>
				<% } else { %>
					<%= Html.ActionLink(first.Editor.Nome, "Editor", new { id=first.EditorID }, null) %>
				<% } %>--%>
				
			</span>
		</p>
		<p class="abstract">
			<%= first.Chamada %>
		</p>
	</div>
	<% foreach (var art in others)	{ %>
	<div class="artigo">
		<h2>
			<%= Html.ActionLink(art.Titulo, "Details", "Artigos", new { id=art.ArtigoID }, null)%>
		</h2>
		<p class="general_informations">
			<%= art.PublicadoEm.ToShortDateString() %> - 
			<span class="author">
				Por <%= Html.Label((!String.IsNullOrEmpty(art.Autor)) ? art.Autor : art.Editor.Nome) %>
<%--				<% if (!String.IsNullOrEmpty(art.Autor)) { %>
				 <%= Html.ActionLink(art.Autor, "Autor", "Artigos", new { id= art.Autor }, null) %>
				<% } else { %>
					<%= Html.ActionLink(art.Editor.Nome, "Editor", new { id=art.EditorID }, null) %>
				<% } %>--%>
			</span>
		</p>
		<p class="abstract">
			<%= art.Chamada %>
		</p>
	</div>
	<% } %>

	<p>
		<%= Html.ActionLink("Mais artigos", "Index", "Artigos", null, new { @class="button" }) %>
	</p>
</div>
<!-- ARTICLES END -->
