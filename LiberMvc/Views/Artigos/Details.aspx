<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.Artigo>" %>
<%@ Import Namespace="LiberMvc.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel">
	    <h1>Artigo</h1>

        <div class="article">
            <%= Html.DisplayForModel("Artigo") %>
        </div>

	    <p class="actions">
	    <% if (Model.isOwnerOrAdmin) { %>
		    <%= Html.ActionLink("Editar", "Edit", new { id = Model.ArtigoID }, new { @class = "button" }) %>
	    <% } %>
		    <%= Html.ActionLink("Voltar a lista", "Index", null, new { @class = "button" }) %>

            <br class="clear" />
	    </p>

	</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
