<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>
<asp:Content ID="Content0" ContentPlaceHolderID="HeadContent" runat="server">
	<script src="<%= Url.Content("~/Scripts/slides/jquery.scrollTo-1.4.2-min.js") %>" type="text/javascript"></script>
	<script src="<%= Url.Content("~/Scripts/slides/jquery.localscroll.js") %>" type="text/javascript"></script>
	<script src="<%= Url.Content("~/Scripts/slides/jquery.serialScroll-1.2.2.js") %>" type="text/javascript"></script>
	<script src="<%= Url.Content("~/Scripts/slides/coda-slider.js") %>" type="text/javascript" charset="utf-8"></script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<% Html.RenderPartial("Destaque"); %> 
	<% Html.RenderAction( "Home", "Artigos"); %>
	<% Html.RenderAction("Home", "Blog"); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightHome"); %>
</asp:Content>