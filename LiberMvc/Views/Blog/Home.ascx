<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<IEnumerable<Blog>>" %>
<%@ Import Namespace="LiberMvc.Models" %>
<!-- BLOG BEGIN -->
<div class="panel" id="blog">
	<h1>Blog</h1>
	<ul class="posts">
		<% foreach (var blog in Model)
		 { %>
		<li>
			<%= blog.PublicadoEm.ToShortDateString()%><br />
			<%= Html.ActionLink(blog.Titulo, "Details", "Blog", new { id = blog.BlogID }, null)%>
		</li>
		<% } %>
	</ul>
	<p class="actions">
		<%= Html.ActionLink("Ir para o blog", "Index", "Blog", null, new { @class = "button" })%>
		<br class="clear" />
	</p>
</div>
<!-- BLOG END -->
