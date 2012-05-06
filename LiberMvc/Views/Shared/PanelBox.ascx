﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<div class="panel" id="tenha_atitude">
    <h1>Tenha atitude</h1>
 
    <ul style="float:left">
        <li class="join"><a href='<%= Url.Action("Filiacao", "Usuario") %>'>Filie-se</a></li>
        <li class="donate"><a href='<%= Url.Action("Doacao", "Liber") %>'>Contribua</a></li>
    </ul>

    <ul style="float:right"> 
        <li class="know"><a href='<%= Url.Action("Filosofia", "Liber") %>'>Conheça mais</a></li>
        <li class="promotion"><a href='<%= Url.Action("Divulgacao", "Liber") %>'>Divulgue</a></li>
				<%-- <li class="invite"><a href='<%= Url.Action("Convide", "Usuario") %>'>Convide amigos</a></li>--%>
        <%-- <li class="forum"><a href='<%= Url.Action("Index", "Forum") %>'>Debata</a></li> --%>
    </ul>
 
    <br class="clear" />
</div>