﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<% if (Model == null)
	 { %>
		<%= ViewData.ModelMetadata.NullDisplayText %>
<% }
	 else if (ViewData.TemplateInfo.TemplateDepth > 1)
	 { %>
		<%= ViewData.ModelMetadata.SimpleDisplayText %>
<% }
	 else
	 { 
		foreach (var prop in ViewData.ModelMetadata.Properties.Where(pm => pm.ShowForDisplay && !ViewData.TemplateInfo.Visited(pm)))
		 { 
		  if (prop.HideSurroundingHtml)
			 { %>
		<%= Html.Display(prop.PropertyName) %>
		<% }
			 else
			 { %>
				<div class="display-item">
					<div class="display-label" style="text-align: right;">
						<%= prop.GetDisplayName() %>
					</div>
					<div class="display-field">
						<%= Html.Display(prop.PropertyName) %>
					</div>
				</div>
		<% } %>
	<% } %>
<% } %>