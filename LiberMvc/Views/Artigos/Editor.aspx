<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<LiberMvc.Models.Artigo>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel">
		<h1>Artigos - <%=Model.FirstOrDefault().Editor.Nome %></h1>
		<% foreach (var art in Model) { %>
		<div class="artigo">
			<h2>
				<%= Html.ActionLink(art.Titulo, "Details", "Artigos", new { id=art.ArtigoID }, null)%>
			</h2>
			<p class="general_informations">
				<%= art.PublicadoEm.ToShortDateString() %> - 
				<span class="author">
					Por	<%= Html.ActionLink(art.Editor.Nome, "Editor", "Artigos", new { id=art.EditorID }, null) %>
				</span>
			</p>
			<p class="abstract">
				<%= art.Chamada %>
			</p>
		</div>
	<% } %>
	</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
<% Html.RenderPartial("RightMenu"); %>
</asp:Content>

