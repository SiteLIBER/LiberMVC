<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel" id="doacao">
		<h1>Contato</h1>
<p> Secretaria<br>
                contato@libertarios.com.br<br>
                <br>
                Acessoria de Imprensa<br>
                imprensa@libertarios.com.br<br>
                <br>
                Diret&oacute;rio Nacional<br>
                diretoria@libertarios.com.br<br>
                <br>
                Site<br>
                webmaster@libertarios.com.br</p>
	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">

	<% Html.RenderPartial("RightMenu"); %>

</asp:Content>

