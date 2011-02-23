<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel" id="post">
        <h1>Lideranças nacionais</h1>
        
        <ul class="formatted_list">
            <li class="highlight"><strong>Presidente Nacional</strong>
                Juliano Torres
            </li>
            <li><strong>Vice-presidente Nacional</strong>
                Bernardo Santoro Pinto Machado
            </li>
            <li><strong>Secretário Geral</strong>
                Guilherme Inojosa Fragoso Cavalcanti 
            </li>
            <li><strong>Tesoureiro</strong>
                Bruno Paludo
            </li>
            <li><strong>Relações Públicas</strong>
                Luciana Lopes Nominato Braga
            </li>
            <li><strong>Captação de Recursos</strong>
                Felipe Kirsch
            </li>
            <li><strong>Comunicação</strong>
                Odilon Candido
            </li>
            <li><strong>Marketing</strong>
                André rufino
            </li>
            <li><strong>Corregedor</strong>
                Carlo Rocha
            </li>
        </ul>

        <div style="float: left; padding-right: 10px">
            <h2>Comite Julgador</h2>

            <ul class="formatted_list">
                <li>Caio Magno Lima Campos</li>
                <li>Fernando Fiori Chiocca</li>
                <li>Filipe Rangel Celeti</li>
                <li>Pedro Henrique Ferreira González</li>
                <li>Thiago Guedes Santos</li>
            </ul>
        </div>

        <div style="float: left;  padding-right: 10px">
            <h2>Comite Fiscal</h2>

            <ul class="formatted_list">
                <li>Geraldo Boz Junior</li>
                <li>Hélio Marcos Coutinho Beltrão</li>
                <li>Thiago Pinheiro de Souza</li>
            </ul>
        </div>

        <div style="float: left">
            <h2>Comite Executivo</h2>

            <ul class="formatted_list">
                <li>André Luiz de Freitas Paranhos</li>
                <li>Antônio Mariz Sales Neto</li>
                <li>Bruno Paludo</li>
                <li>Carlo Sivieri de Assis Rocha</li>
                <li>Luciana Lopes Nominato Braga</li>
                <li>Roberto Fiori Chiocca</li>
                <li>Sara de Cerqueira</li>
                <li>Sidnei Santana</li>
            </ul>
        </div>

    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>