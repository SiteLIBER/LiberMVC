<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.Artigo>" %>



<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<script type="text/javascript" src="/Scripts/tinymce/jscripts/tiny_mce/tiny_mce.js"></script>
<script type="text/javascript" src="/Scripts/textedit.js"></script>

<div class="panel">
    <h1>Novo artigo</h1>
  
    <div id="editor-form">
	<% using (Html.BeginForm()) { %>
        <%= Html.ValidationSummary(true) %>
		<%= Html.EditorForModel("Artigo", Model) %>

		<p class="actions">
			<input type="submit" value="Enviar" class="button" />
        	<%= Html.ActionLink("Voltar a Lista", "Index", null, new { @class = "button" }) %>
        </p>
    <% } %>
    </div>
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

