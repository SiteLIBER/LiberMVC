<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel" id="post">
		<h1>
			LIBER 500</h1>
		<h2>
			Fichas de apoio ao registro - desafio LIBER 500</h2>
		<p>
			O <strong>LIBER</strong> está coletando as 500 mil assinaturas necessárias para registrar o partido junto ao TSE e disputar eleições. Faça parte dessa conquista!</p>
		<p>
			A assinatura desta ficha não representa filiação ao partido, é somente um manifesto de apoio ao registro do <strong>LIBER</strong>.</p>
		<p id="ficha_btn">
			<a href="<%: Url.Content("~/Content/download/ficha_apoio_liber_500.pdf") %>" target="_blank">Baixe a ficha de apoio e o manual para coleta de assinaturas</a>
		</p>
		<h2>
			Dados obrigatórios:</h2>
		<ul>
			<li>Nome completo (sem abreviaturas)</li>
			<li>Nome da mãe (sem abreviaturas)</li>
			<li>Data de nascimento</li>
			<li>Assinatura (como no título de eleitor)</li>
		</ul>
		<h2>
			As fichas devem ser enviadas para:</h2>
		<address>
			<b>Felipe Kirsch</b><br />
			Rua dos Caetés, 737, ap 707, Perdizes<br />
			São Paulo - SP<br />
			CEP 05016-081<br />
		</address>
	</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
