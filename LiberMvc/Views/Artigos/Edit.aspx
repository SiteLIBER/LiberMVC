﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.Artigo>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<div class="panel">
    <h2>Editar</h2>

	<% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>
				<%= Html.EditorForModel() %>
		<input type="submit" value="Enviar" class="button" />
     <% } %>

    <div>
        <%= Html.ActionLink("Voltar a Lista", "Index") %>
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

