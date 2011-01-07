<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<string>" %>
<%= Html.TextArea("", ViewData.TemplateInfo.FormattedModelValue.ToString(), new { @class = "text-box multi-line" }) %>