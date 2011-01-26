<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%-- TENHA ATITUDE BEGIN --%>
<% Html.RenderPartial("PanelBox"); %>
<%-- TENHA ATITUDE END --%>

<%-- LOGIN BEGIN --%>
<div class="panel" id="loginbox">
<% if (!Request.IsAuthenticated)
		 Html.RenderAction("LoginBox", "Usuario");
   else
		 Html.RenderAction("UserBox", "Usuario");
%>
</div>
<%-- LOGIN END --%>

<%-- LIBER 500 BEGIN --%>
<%--<% Html.RenderPartial("Liber500Box"); %>--%>
<%-- LIBER 500 END --%>

<%-- DOE BEGIN --%>
<%--<% Html.RenderPartial("DonateBox"); %>--%>
<%-- DOE END --%>

<%-- VÍDEO BEGIN --%>
<% Html.RenderPartial("VideoBox"); %>
<%-- VÍDEO END --%>

<%-- REDES SOCIAIS BEGIN --%>
<% Html.RenderPartial("SocialBox"); %>
<%-- REDES SOCIAIS END --%>

<%-- FACEBOOK BEGIN --%>
<% Html.RenderPartial("FacebookBox"); %>
<%-- FACEBOOK END --%>