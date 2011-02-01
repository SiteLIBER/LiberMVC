﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.FiliacaoModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <script type="text/javascript">
	    $(function () {
		    $("#imprimir").click(function () {
			    var url = '<%= Url.Action("FiliacaoImprimir") %>';
			    window.open(url, "filiacao_imprimir", "");
		    });

		    $("#anualidade").click(function () {
			    var url = '<%= Url.Action("Anualidade") %>';
			    window.location = url;
		    });
	    });
    </script>

	<div class="panel" id="post">
		<h1>Filiação - Confirme e Imprima</h1>
			
			<p>
                Confira seus dados e imprima a ficha de filiação. Assine
                e entregue para o representante do partido em alguma reunião, ou envie para:
            </p>

            <p>
                NOME<br />
				ENDERECO
            </p>

			<p>
				A anualidade deve ser paga, para que o filiado tenha direito a voto:
			</p>
			
<%--
		<input id="anualidade" type="button" class="button" value="Pagar Anualidade" />
		<form target="pagseguro" action="https://pagseguro.uol.com.br/v2/checkout/cart.html?action=add" method="post">
		<input type="hidden" name="receiverEmail" value="brunopaludo@hotmail.com" />
		<input type="hidden" name="currency" value="BRL" />
		<input type="hidden" name="itemId" value="1" />
		<input type="hidden" name="itemDescription" value="Anualidade Liber" />
		<input type="hidden" name="itemQuantity" value="1" />
		<input type="hidden" name="itemAmount" value="100.00" />
		<input type="image" src="https://p.simg.uol.com.br/out/pagseguro/i/botoes/pagamentos/205x30-pagar-azul.gif" name="submit" alt="Pague com PagSeguro - é rápido, grátis e seguro!" />
		</form>
--%>
		<form target="pagseguro" method="post" action="https://pagseguro.uol.com.br/checkout/checkout.jhtml">
		    <input type="hidden" name="email_cobranca" value="brunopaludo@hotmail.com" />
		    <input type="hidden" name="tipo" value="CP" />
    <%--	<input type="hidden" name="moeda" value="BRL">--%>
		    <input type="hidden" name="item_id_1" value="1" />
		    <input type="hidden" name="item_descr_1" value="Anualidade Liber" />
		    <input type="hidden" name="item_quant_1" value="1" />
		    <input type="hidden" name="item_valor_1" value="10000" />
    <%--	<input type="hidden" name="item_frete_1" value="0">
		    <input type="hidden" name="item_peso_1" value="0">
		    <input type="hidden" name="tipo_frete" value="EN">--%>
		    <input type="hidden" name="ref_transacao" value="<%= Model.UsuarioID %>" />
	
		    <input type="image" src="https://p.simg.uol.com.br/out/pagseguro/i/botoes/pagamentos/205x30-pagar-azul.gif" name="submit" alt="Pague com PagSeguro - é rápido, grátis e seguro!" />
		</form>

		<fieldset>
			<legend>Dados Pessoais</legend>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.Nome) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.Nome) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.DataNasc) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.DataNasc) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.Naturalidade) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.Naturalidade) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.NomePai) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.NomePai) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.NomeMae) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.NomeMae) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.EstadoCivilID) %>
				</span>
				<span class="editor-field">
					<%= Html.Label(Model.ListaEstadoCivil.FirstOrDefault(l => l.EstadoCivilID == Model.EstadoCivilID).Descricao) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.Profissao) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.Profissao) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
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
				<span class="editor-label">
					<%= Html.LabelFor(model => model.Endereco) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.Endereco) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.Cidade) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.Cidade) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.Estado) %>
				</span>
				<span class="editor-field">
					<%= Html.Label(Model.ListaEstados[Model.Estado]) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.CEP) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.CEP) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
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
				<span class="editor-label">
					<%= Html.LabelFor(model => model.TituloEleitor) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.TituloEleitor) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.Zona) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.Zona) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
					<%= Html.LabelFor(model => model.Secao) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.Secao) %>
				</span>
			</div>

			<div class="editor-item">
				<span class="editor-label">
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
					<%= Html.LabelFor(model => model.OutroPartidoQual) %>
				</span>
				<span class="editor-field">
					<%= Html.DisplayFor(model => model.OutroPartidoQual) %>
				</span>
			</div>
            <% } %>

        </fieldset>

        <p class="actions">
			<input id="imprimir" type="button" class="button" value="Imprimir" />
            <br class="clear" />
        </p>

	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu", null); %>
</asp:Content>