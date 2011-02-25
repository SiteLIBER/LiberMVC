﻿<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<LiberMvc.Models.Blog>>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel">
		<h1>Blog</h1>
    <%= Html.DisplayForModel("ListaBlog")%>
	</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>