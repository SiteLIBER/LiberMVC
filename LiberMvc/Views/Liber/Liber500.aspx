﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

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
			<a href="<%: Url.Content("~/Content/download/ficha_apoio_liber_500_2.pdf") %>" target="_blank" class="first_btn">Baixe a ficha de apoio</a>
            <a href="<%: Url.Content("~/Content/download/manual_500.pdf") %>" target="_blank" class="last_btn">Baixe o manual para coleta de assinaturas</a>
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
			<b>Bernardo Santoro</b><br />
			Rua Henrique Raffard nº 337, Bingen<br />
			Petrópolis - RJ<br />
			CEP 25665-062<br />
		</address>
	</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
