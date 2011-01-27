<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel">
		<h1>Prestação de Contas</h1>
		<iframe id="ifr_contas" style="width: 100%; height: 752px;" src="https://spreadsheets.google.com/pub?key=0AgpZiPcMXN9wdExCSVBYRld1N2VQN3JMNUNiU2NOQ3c&hl=en&single=true&gid=0&output=html"></iframe>
	</div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>