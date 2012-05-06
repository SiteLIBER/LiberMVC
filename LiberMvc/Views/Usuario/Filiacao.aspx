﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.FiliacaoModel>" %>

<asp:Content ID="Content0" ContentPlaceHolderID="HeadContent" runat="server">
	<script src="<%= Url.Content("~/Scripts/jquery-ui-1.8.5.custom.min.js") %>" type="text/javascript"></script>
	<script type="text/javascript" src="<%= Url.Content("~/Scripts/jquery.ui.datepicker-pt-BR.js") %>"></script>
	<link href="<%= Url.Content("~/Content/ui-darkness/jquery-ui-1.8.5.custom.css") %>" rel="stylesheet" type="text/css" />
	<script type="text/javascript">
		$(function () {
			var thisYear = new Date().getYear();
			if (thisYear < 1000) thisYear += 1900;
			var settings = {
				changeMonth: true,
				changeYear: true,
				yearRange: thisYear - 110 + ':' + thisYear
			};
			$(".datePicker").datepicker(settings);
		});
	</script>
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<div class="panel">
		<h1>
			Filiação</h1>
		<p>
			Os Ítens em <strong style="color: red">vermelho</strong> são obrigatórios.</p>
		<div id="display-form">
			<% Html.EnableClientValidation(); %>

			<% using (Html.BeginForm()) {%>
			<%= Html.ValidationSummary(true) %>

			<fieldset>
				<legend>Dados Pessoais</legend>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Nome) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.Nome) %>
						<%= Html.ValidationMessageFor(model => model.Nome) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.DataNasc) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.DataNasc) %>
						<%= Html.ValidationMessageFor(model => model.DataNasc) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Naturalidade) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.Naturalidade) %>
						<%= Html.ValidationMessageFor(model => model.Naturalidade) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.NomePai) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.NomePai) %>
						<%= Html.ValidationMessageFor(model => model.NomePai) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.NomeMae) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.NomeMae) %>
						<%= Html.ValidationMessageFor(model => model.NomeMae) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.EstadoCivilID) %>
					</span><span class="display-field">
						<%= Html.DropDownListFor(model => model.EstadoCivilID, 
							new SelectList(Model.ListaEstadoCivil, "EstadoCivilID", "Descricao"),
							"Selecione o Estado Civil") %>
						<%= Html.ValidationMessageFor(model => model.EstadoCivilID) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Profissao) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.Profissao) %>
						<%= Html.ValidationMessageFor(model => model.Profissao) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.GrauInstrucaoID) %>
					</span><span class="display-field">
						<%= Html.DropDownListFor(model => model.GrauInstrucaoID, 
							new SelectList(Model.ListaGrauInstrucao, "GrauInstrucaoID", "Descricao"),
							"Selecione o Grau de Instrução") %>
						<%= Html.ValidationMessageFor(model => model.GrauInstrucaoID) %>
					</span>
				</div>
			</fieldset>
			<fieldset>
				<legend>Contato</legend>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Endereco) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.Endereco) %>
						<%= Html.ValidationMessageFor(model => model.Endereco) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Cidade) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.Cidade) %>
						<%= Html.ValidationMessageFor(model => model.Cidade) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Estado) %>
					</span><span class="display-field">
						<%= Html.DropDownListFor(model => model.Estado,
							new SelectList(Model.ListaEstados, "Key", "Value"),
							" -- ") %>
						<%= Html.ValidationMessageFor(model => model.Estado) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.CEP) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.CEP) %>
						<%= Html.ValidationMessageFor(model => model.CEP) %>
					</span>
				</div>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Telefone) %>
					</span><span class="display-field">
						<%= Html.EditorFor(model => model.Telefone) %>
						<%= Html.ValidationMessageFor(model => model.Telefone) %>
					</span>
				</div>
			</fieldset>
			<fieldset>
				<legend>Dados Eleitorais</legend>
				<div class="display-item">
					<div class="display-label obr">
						<%= Html.LabelFor(model => model.TituloEleitor) %>
					</div>
					<div class="display-field">
						<%= Html.EditorFor(model => model.TituloEleitor) %>
						<%= Html.ValidationMessageFor(model => model.TituloEleitor) %>
					</div>
				</div>
				<div class="display-item">
					<div class="display-label obr">
						<%= Html.LabelFor(model => model.Zona) %>
					</div>
					<div class="display-field">
						<%= Html.EditorFor(model => model.Zona) %>
						<%= Html.ValidationMessageFor(model => model.Zona) %>
					</div>
				</div>
				<div class="display-item">
					<div class="display-label obr">
						<%= Html.LabelFor(model => model.Secao) %>
					</div>
					<div class="display-field">
						<%= Html.EditorFor(model => model.Secao) %>
						<%= Html.ValidationMessageFor(model => model.Secao) %>
					</div>
				</div>
				<div class="display-item">
					<div class="display-label obr">
						<%= Html.LabelFor(model => model.MunicipioUF) %>
					</div>
					<div class="display-field">
						<%= Html.EditorFor(model => model.MunicipioUF) %>
						<%= Html.ValidationMessageFor(model => model.MunicipioUF) %>
					</div>
				</div>
				<div class="display-item">
					<div class="display-label">
						<%= Html.LabelFor(model => model.OutroPartido) %>
					</div>
					<div class="display-field">
						<%= Html.EditorFor(model => model.OutroPartido) %>
						<%= Html.ValidationMessageFor(model => model.OutroPartido) %>
					</div>
				</div>
				<div class="display-item">
					<div class="display-label">
						<%= Html.LabelFor(model => model.OutroPartidoQual) %>
					</div>
					<div class="display-field">
						<%= Html.EditorFor(model => model.OutroPartidoQual) %>
						<%= Html.ValidationMessageFor(model => model.OutroPartidoQual) %>
					</div>
				</div>
			</fieldset>
			<br class="clear" />
			<div class="display-item">
				<input type="submit" value="Continuar" class="button" />
			</div>
		</div>
		<% } %>
	</div>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>