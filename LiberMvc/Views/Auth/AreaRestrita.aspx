<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content0" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<div class="panel" id="">
    <h1>Área de acesso restrito</h1>
		<h3>É necessário ter um cadastro e fazer o login para entrar nesta página.</h3>
		<h3>Caso tenha cadastro, por favor, faça o login a direita.</h3>
		</div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
<%Html.RenderPartial("RightMenu"); %>
</asp:Content>
