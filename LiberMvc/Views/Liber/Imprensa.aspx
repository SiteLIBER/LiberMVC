﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel" id="doacao">
		<h1>Imprensa</h1>
	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">

	<% Html.RenderPartial("RightMenu"); %>

</asp:Content>
