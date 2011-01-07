<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.Artigo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Novo</h2>

<div id="display-form">      
	<% using (Html.BeginForm()) { %>
		<%= Html.ValidationSummary(true) %>
		<%= Html.EditorForModel() %>
	<p>
		<input type="submit" value="Cadastrar" />
	</p>
    <% } %>
</div>
<div>
    <%= Html.ActionLink("Voltar a Lista", "Index") %>
</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="HeadContent" runat="server">
	<script src="<%= Url.Content("~/Scripts/jquery-ui-1.8.5.custom.min.js") %>" type="text/javascript"></script>
  <script type="text/javascript" src="<%= Url.Content("~/Scripts/jquery.ui.datepicker-pt-BR.js") %>"></script>

	<link href="<%= Url.Content("~/Content/ui-darkness/jquery-ui-1.8.5.custom.css") %>" rel="stylesheet" type="text/css" />
	
	<script type="text/javascript">
		$(function () {
			$(".datePicker").datepicker();
		});
	</script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="RightContent" runat="server">
<% Html.RenderPartial("RightMenu"); %>
</asp:Content>

