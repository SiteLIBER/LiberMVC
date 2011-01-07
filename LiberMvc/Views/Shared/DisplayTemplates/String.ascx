<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<string>" %>  
<%--<div class="display-label"><strong><%=Html.LabelFor(model => model)%></strong></div>  
<div class="display-field"><%=Html.Encode(Model)%></div>  --%>
<%= Html.Encode(ViewData.TemplateInfo.FormattedModelValue) %>