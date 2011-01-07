﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<% if (ViewData.TemplateInfo.TemplateDepth > 1)
	 { %>
			<%= ViewData.ModelMetadata.SimpleDisplayText %>
<% } else	{ %>
	<% foreach (var prop in ViewData.ModelMetadata.Properties.Where(pm => pm.ShowForEdit && !ViewData.TemplateInfo.Visited(pm))) { %>
		<% if (prop.HideSurroundingHtml) { %>
			<%= Html.Editor(prop.PropertyName) %>
		<% } else { %>
<div class="display-item">
	<div class="editor-label<%= prop.IsRequired ? " orb" : "" %>" style="text-align: right;">
		<%= Html.Label(prop.PropertyName) %>
	</div>
	<div class="editor-field">
		<%= Html.Editor(prop.PropertyName) %>
		<%= Html.ValidationMessage(prop.PropertyName, "*") %>
	</div>
</div>
		<% } %>
	<% } %>
<% } %>