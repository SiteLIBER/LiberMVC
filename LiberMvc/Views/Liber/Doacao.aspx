<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel" id="doacao">
		<h1>Faça uma doação</h1>
		<p>Ajude o LIBER a conquistar mais liberdade para todos. Doe aqui:</p>
		<form target="pagseguro" action="https://pagseguro.uol.com.br/checkout/doacao.jhtml" method="post">
			<input type="hidden" name="email_cobranca" value="brunopaludo@hotmail.com" />
			<input type="hidden" name="moeda" value="BRL" />
			<input type="hidden" name="ref_transacao" value="<%= Model %>" />
			<input type="image" src="https://p.simg.uol.com.br/out/pagseguro/i/botoes/doacoes/205x30-doar-azul.gif" name="submit" alt="Pague com PagSeguro - é rápido, grátis e seguro!" />
		</form>
		<p></p>
	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">

	<% Html.RenderPartial("RightMenu"); %>

</asp:Content>
