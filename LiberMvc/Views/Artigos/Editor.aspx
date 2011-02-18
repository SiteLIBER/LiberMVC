<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<LiberMvc.Models.Artigo>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel">
		<h1>Artigos - <%= ViewData["Editor"] %></h1>
		<%= Html.DisplayForModel("Tabela") %>
	</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
