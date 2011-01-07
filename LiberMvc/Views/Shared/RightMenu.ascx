<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%-- TENHA ATITUDE BEGIN --%>
<% Html.RenderPartial("PanelBox"); %>
<%-- TENHA ATITUDE END --%>

<%-- LOGIN BEGIN --%>
<div class="panel" id="loginbox">
<% if (!Request.IsAuthenticated)
		 Html.RenderAction("LoginBox", "Usuario");
	 else
		 Html.RenderAction("UserBox", "Usuario"); %>
</div>
<%-- LOGIN END --%>

<%-- REDES SOCIAIS BEGIN --%>
<% Html.RenderPartial("SocialBox"); %>
<%-- REDES SOCIAIS END --%>
