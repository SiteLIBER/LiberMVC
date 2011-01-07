<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<LiberMvc.Models.Artigo>>" %>
<%@ Import Namespace="LiberMvc.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel">
		<h1>Artigos</h1>
		<% foreach (var art in Model) { %>
		<div class="artigo">
			<h2>
				<%= Html.ActionLink(art.Titulo, "Details", "Artigos", new { id=art.ArtigoID }, null)%>
			</h2>
			<p class="general_informations">
				<%= art.PublicadoEm.ToShortDateString() %> - 
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
	</div>
<% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin) { %>
  <p>
    <%= Html.ActionLink("Criar Novo", "Create", null, new { @class = "button" })%>
  </p>
<% } %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="RightContent" runat="server">
<% Html.RenderPartial("RightMenu"); %>
</asp:Content>

