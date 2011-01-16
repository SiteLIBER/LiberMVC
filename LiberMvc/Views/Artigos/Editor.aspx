<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<LiberMvc.Models.Artigo>>" %>
<%@ Import Namespace="LiberMvc.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel">
		<h1>Artigos - <%= ViewData["Editor"] %></h1>
		<%= Html.DisplayForModel("Lista") %>
	</div>
	
    <% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin) { %>
    <p>
        <%= Html.ActionLink("Criar Novo", "Create", null, new { @class = "button" })%>
    </p>
    <% } %>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
<% Html.RenderPartial("RightMenu"); %>
</asp:Content>

