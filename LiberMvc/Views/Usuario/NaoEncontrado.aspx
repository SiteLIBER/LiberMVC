<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel">
		<h1>Usuário não encontrado!</h1>
		<h3>confira se o link está correto.</h3>
	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
<% Html.RenderPartial("RightMenu");  %>
</asp:Content>
