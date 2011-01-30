﻿<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.FiliacaoModel>" %>

<script type="text/javascript">
	function imprimir() {
		window.print();
		window.close();
	}
	setTimeout(imprimir, 800);
</script>

<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01//EN" "http://www.w3.org/TR/html4/strict.dtd">

<html lang="pt-BR">

<head>
    <title>Libertários - Ficha de Filiação</title>

    <link href="<%= Url.Content("~/Content/styles/filiacao_print.css") %>" rel="stylesheet" type="text/css" media="screen, print" />

    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8"/>
</head>

<body>

    <div id="head">
        <h1 id="logo"><img src="<%= Url.Content("~/Content/images/logo_print.png") %>" alt="Libertários" /></h1>
	    <h2>Ficha de filiação partidária</h2>

        <br class="clear" />
    </div>

	<fieldset>
		<legend>Dados Pessoais</legend>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Nome) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.Nome) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.DataNasc) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.DataNasc) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Naturalidade) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.Naturalidade) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.NomePai) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.NomePai) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.NomeMae) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.NomeMae) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.EstadoCivilID) %>
			</span>
            <span class="editor-field">
				<%= Html.Label(Model.ListaEstadoCivil.FirstOrDefault(l => l.EstadoCivilID == Model.EstadoCivilID).Descricao) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Profissao) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.Profissao) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.GrauInstrucaoID) %>
			</span>
            <span class="editor-field">
				<%= Html.Label(Model.ListaGrauInstrucao.FirstOrDefault(l=> l.GrauInstrucaoID == Model.GrauInstrucaoID).Descricao) %>
			</span>
		</div>
	</fieldset>

	<fieldset>
		<legend>Contato</legend>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Endereco) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.Endereco) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Cidade) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.Cidade) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Estado) %>
			</span>
            <span class="editor-field">
				<%= Html.Label(Model.ListaEstados[Model.Estado]) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.CEP) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.CEP) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Telefone) %>
			</span>
            <span class="editor-field">
				<%= Html.DisplayFor(model => model.Telefone) %>
			</span>
		</div>

	</fieldset>

	<fieldset>
		<legend>Dados Eleitorais</legend>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.TituloEleitor) %>
			</span>
			<span class="editor-field">
				<%= Html.DisplayFor(model => model.TituloEleitor) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Zona) %>
			</span>
			<span class="editor-field">
				<%= Html.DisplayFor(model => model.Zona) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Secao) %>
			</span>
			<span class="editor-field">
				<%= Html.DisplayFor(model => model.Secao) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.MunicipioUF) %>
			</span>
			<span class="editor-field">
				<%= Html.DisplayFor(model => model.MunicipioUF) %>
			</span>
		</div>

		<div class="editor-item">
			<span class="editor-label">
				<%= Html.LabelFor(model => model.OutroPartido) %>
			</span>
			<span class="editor-field">
				<%= Html.DisplayFor(model => model.OutroPartido) %>
			</span>
		</div>

        <% if (Model.OutroPartido) { %>
		<div class="editor-item">
			<span class="editor-label">
				<%= Html.LabelFor(model => model.OutroPartidoQual)%>
			</span>
			<span class="editor-field">
				<%= Html.DisplayFor(model => model.OutroPartidoQual)%>
			</span>
		</div>
        <% } %>

	</fieldset>

    <fieldset>
        <legend>Termo de compromisso do filiado</legend>

        <p>Declaro que estou de acordo com o Estatuto e o Programa do <strong>Partido Libertários</strong> (<strong>LIBER</strong>):</p>

        <p class="termo">
            <span class="data">Data:</span>
            <span class="assinatura">Assinatura do filiado:</span>
        </p>
    </fieldset>

</body>
</html>
