<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<IEnumerable<LiberMvc.Models.Artigo>>" %>
<%@ Import Namespace="LiberMvc.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel">
		<h1>Artigos</h1>

		<%= Html.DisplayForModel("Lista") %>

        <% if (Usuario.Logado.isEditor || Usuario.Logado.isAdmin) { %>
            <%= Html.ActionLink("Criar Novo", "Create", null, new { @class = "button" })%>
        <% } %>
    
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="RightContent" runat="server">
    <% Html.RenderPartial("RightMenu"); %>
</asp:Content>

