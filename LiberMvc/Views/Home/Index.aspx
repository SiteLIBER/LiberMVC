<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="Content0" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<%=Application["Teste"] %>
	<%-- <% Html.RenderPartial("Destaque"); %> --%>
	<% Html.RenderAction( "Home", "Artigos"); %>
	<% Html.RenderAction("Home", "Blog"); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightHome"); %>
</asp:Content>