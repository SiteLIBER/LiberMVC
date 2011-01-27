﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel" id="post">
		<h1>Divulgue o LIBER</h1>

        <h2>Banner horizontal</h2>

        <p><img src="<%= Url.Content("~/Content/images/bannerLIBERhor01.png") %>" /></p>

        <p><strong>Código HTML:</strong></strong></p>

        <pre>&lt;a href="http://www.libertarios.com.br/"&gt;&lt;img src="<%= "http://www.libertarios.com.br" + Url.Content("~/Content/images/bannerLIBERhor01.png") %>" style="border:0px;"&gt;&lt;/a&gt;</pre>

        <h2>Banner vertical</h2>

        <p><img src="<%= Url.Content("~/Content/images/bannerLIBERvert01.png") %>" /></p>

        <p><strong>Código HTML:</strong></strong></p>

        <pre>&lt;a href="http://www.libertarios.com.br/"&gt;&lt;img src="<%= "http://www.libertarios.com.br" + Url.Content("~/Content/images/bannerLIBERvert01.png") %>" style="border:0px;"&gt;&lt;/a&gt;</pre>


	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">

	<% Html.RenderPartial("RightMenu"); %>

</asp:Content>
