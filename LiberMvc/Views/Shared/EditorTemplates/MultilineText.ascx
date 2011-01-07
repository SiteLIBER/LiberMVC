<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<%= Html.TextArea("", ViewData.TemplateInfo.FormattedModelValue.ToString(), new { @class = "text-box multi-line" }) %>