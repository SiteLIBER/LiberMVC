<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel">
		<h1>E-mail já existe!</h1>
		<h3>Por favor, use outro e-mail para o cadastro, ou faça o login.</h3>
	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
<% Html.RenderPartial("RightMenu");  %>
</asp:Content>

