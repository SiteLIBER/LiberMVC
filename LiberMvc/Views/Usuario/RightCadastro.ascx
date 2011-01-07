<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%-- TENHA ATITUDE --%>
<% Html.RenderPartial("PanelBox"); %>

<%-- LOGIN --%>
<%--<% if (!Request.IsAuthenticated)
		 Html.RenderPartial("LoginBox");
	 else
		 Html.RenderAction("UserBox", "Usuario"); %>
<br />
--%>
<%-- REDES SOCIAIS --%>
<% Html.RenderPartial("SocialBox"); %>