﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Blog>>" %>
<%@ Import Namespace="LiberMvc.Models" %>
<!-- BLOG BEGIN -->
<div class="panel" id="blog">
	<h1>Blog</h1>

	<% foreach (var blog in Model) { %>
	<div class="article_resume">
        <p class="general_informations">
		    <span class="date"><%= blog.PublicadoEm.ToShortDateString()%></span><br />
		    <%= Html.ActionLink(blog.Titulo, "Details", "Blog", new { id = blog.BlogID }, null)%>
        </p>
	</div>
	<% } %>

	<p class="actions">
		<%= Html.ActionLink("Ir para o blog", "Index", "Blog", null, new { @class = "button" })%>
		<br class="clear" />
	</p>
</div>
<!-- BLOG END -->