<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.Artigo>" %>
<%@ Import Namespace="LiberMvc.Models" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel">
	<h1><%= Html.Encode(Model.Titulo) %></h1>
	<p>
		<span class="date">
			<%= Model.PublicadoEm.ToShortDateString()%></span> <span class="author">
				<%= Html.Encode(Model.Autor)%></span>
	</p>

    <div class="article_body">
    	<%= Model.Conteudo %>
    </div>


	<p>
	<% if (Model.isOwnerOrAdmin) { %>
		<%= Html.ActionLink("Editar", "Edit", new { id = Model.ArtigoID }) %>	|
	<% } %>
		<%= Html.ActionLink("Voltar a Lista", "Index") %>
	</p>
	</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
