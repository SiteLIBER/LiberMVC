﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<bool?>" %>
<% if (Model.HasValue && Model.Value)	{ %>
<label><%= Html.RadioButtonFor(m => m, true, new { @checked = "checked" })%>Sim</label>
<label><%= Html.RadioButtonFor(m => m, false)%>Não</label>
<% } else { %>
<label><%= Html.RadioButtonFor(m => m, true)%>Sim</label>
<label><%= Html.RadioButtonFor(m => m, false, new { @checked = "checked" })%>Não</label>
<% } %>
