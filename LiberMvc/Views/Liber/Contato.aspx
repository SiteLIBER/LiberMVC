<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel" id="doacao">
		<h1>Contato</h1>

        <ul class="formatted_list">
            <li class="highlight"><strong>Presidente</strong>
                <a href="mailto:presidente@pliber.org.br">presidente@pliber.org.br</a>
            </li>
            <li><strong>Vice Presidente</strong>
                <a href="mailto:vice@pliber.org.br">vice@pliber.org.br</a>
            </li>
            <li><strong>Secretário Geral</strong>
                <a href="mailto:contato@pliber.org.br">contato@pliber.org.br</a>
            </li>
            <li><strong>Corregedor</strong>
                <a href="mailto:corregedor@pliber.org.br">corregedor@pliber.org.br</a>
            </li>
            <li><strong>Tesouraria</strong>
                <a href="mailto:tesouraria@pliber.org.br">tesouraria@pliber.org.br</a>
            </li>
            <li><strong>Captação de Recursos</strong>
                <a href="mailto:recursos@pliber.org.br">recursos@pliber.org.br</a>
            </li>
            <li><strong>Comunicação</strong>
                <a href="mailto:sejaliber@pliber.org.br">sejaliber@pliber.org.br</a>
            </li>
            <li><strong>Marketing</strong>
                <a href="mailto:mkt@pliber.org.br">mkt@pliber.org.br</a>
            </li>
            <li><strong>Relações Públicas</strong>
                <a href="mailto:rp@pliber.org.br">rp@pliber.org.br</a>
            </li>
            <li><strong>Assessoria de Imprensa</strong>
                <a href="mailto:imprensa@pliber.org.br">imprensa@pliber.org.br</a>
            </li>
            <li><strong>Webmaster</strong>
                <a href="mailto:webmaster@pliber.org.br">webmaster@pliber.org.br</a>
            </li>
        </ul>

	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">

	<% Html.RenderPartial("RightMenu"); %>

</asp:Content>

