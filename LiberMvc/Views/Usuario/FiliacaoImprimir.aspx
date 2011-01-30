﻿<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.FiliacaoModel>" %>

<script type="text/javascript">

	function imprimir() {
		window.print();
		window.close();
	}
	setTimeout(imprimir, 800);
</script>
<div class="panel">
	<h1>Filiação - Confirme e Imprima</h1>
	<fieldset>
		<legend>Dados Pessoais</legend>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Nome) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.Nome) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.DataNasc) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.DataNasc) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Naturalidade) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.Naturalidade) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.NomePai) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.NomePai) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.NomeMae) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.NomeMae) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.EstadoCivilID) %>
			</span><span class="editor-field">
				<%= Html.Label(Model.ListaEstadoCivil.FirstOrDefault(l => l.EstadoCivilID == Model.EstadoCivilID).Descricao) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Profissao) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.Profissao) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.GrauInstrucaoID) %>
			</span><span class="editor-field">
				<%= Html.Label(Model.ListaGrauInstrucao.FirstOrDefault(l=> l.GrauInstrucaoID == Model.GrauInstrucaoID).Descricao) %>
			</span>
		</div>
	</fieldset>
	<fieldset>
		<legend>Contato</legend>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Endereco) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.Endereco) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Cidade) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.Cidade) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Estado) %>
			</span><span class="editor-field">
				<%= Html.Label(Model.ListaEstados[Model.Estado]) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.CEP) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.CEP) %>
			</span>
		</div>
		<div class="editor-item">
			<span class="editor-label obr">
				<%= Html.LabelFor(model => model.Telefone) %>
			</span><span class="editor-field">
				<%= Html.DisplayFor(model => model.Telefone) %>
			</span>
		</div>
	</fieldset>
	<fieldset>
		<legend>Dados Eleitorais</legend>
		<div class="editor-item">
			<div class="editor-label obr">
				<%= Html.LabelFor(model => model.TituloEleitor) %>
			</div>
			<div class="editor-field">
				<%= Html.DisplayFor(model => model.TituloEleitor) %>
			</div>
		</div>
		<div class="editor-item">
			<div class="editor-label obr">
				<%= Html.LabelFor(model => model.Zona) %>
			</div>
			<div class="editor-field">
				<%= Html.DisplayFor(model => model.Zona) %>
			</div>
		</div>
		<div class="editor-item">
			<div class="editor-label obr">
				<%= Html.LabelFor(model => model.Secao) %>
			</div>
			<div class="editor-field">
				<%= Html.DisplayFor(model => model.Secao) %>
			</div>
		</div>
		<div class="editor-item">
			<div class="editor-label obr">
				<%= Html.LabelFor(model => model.MunicipioUF) %>
			</div>
			<div class="editor-field">
				<%= Html.DisplayFor(model => model.MunicipioUF) %>
			</div>
		</div>
		<div class="editor-item">
			<div class="editor-label">
				<%= Html.LabelFor(model => model.OutroPartido) %>
			</div>
			<div class="editor-field">
				<%= Html.DisplayFor(model => model.OutroPartido) %>
			</div>
		</div>
		<div class="editor-item">
			<div class="editor-label">
				<%= Html.LabelFor(model => model.OutroPartidoQual) %>
			</div>
			<div class="editor-field">
				<%= Html.DisplayFor(model => model.OutroPartidoQual) %>
			</div>
		</div>
	</fieldset>
</div>
