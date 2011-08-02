<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content0" ContentPlaceHolderID="HeadContent" runat="server">
	<script src="<%= Url.Content("~/Scripts/bxSlider.min.js") %>" type="text/javascript"></script>

	<script type="text/javascript">
		$(document).ready(function () {
			$('#banner').bxSlider({
				controls: false,
				pager: true,
				auto: true,
				pause: 15000
			});
		});
	</script>
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<% Html.RenderPartial("Destaque"); %>
	<% Html.RenderAction("Home", "Artigos"); %>
	<% Html.RenderAction("Home", "Blog"); %>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightHome"); %>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="BannerContent" runat="server">
	<% Html.RenderPartial("Banner"); %>
</asp:Content>
