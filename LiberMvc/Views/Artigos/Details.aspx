<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.Artigo>" %>
<%@ Import Namespace="LiberMvc.Models" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel">
	    <h1>Artigo</h1>

        <div class="article">
            <h1><%= Html.Encode(Model.Titulo) %></h1>

	        <p class="general_informations">
		        <span class="date"><%= Model.PublicadoEm.ToShortDateString()%></span>
                <span class="author"><%= Html.Encode(Model.Autor)%></span>
	        </p>

            <div class="article_body">
    	        <%= Model.Conteudo %>
            </div>

        </div>

	    <p class="actions">
	    <% if (Model.isOwnerOrAdmin) { %>
		    <%= Html.ActionLink("Editar", "Edit", new { id = Model.ArtigoID }) %>
	    <% } %>
		    <%= Html.ActionLink("Voltar a Lista", "Index", null, new { @class = "button" })%>
	    </p>

	</div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
