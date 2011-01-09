<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel" id="post">
        <h1>Lideranças nacionais</h1>

        <div id="index">
            <h1>Nosso Partido</h1>

            <ul>
                <li><a href="<%= Url.Action("Historia", "Liber") %>">História</a></li>
		        <li><a href="<%= Url.Action("Filosofia", "Liber") %>">Filosofia</a></li>
		        <li><a href="<%= Url.Action("Programa", "Liber") %>">Programa</a></li>
			    <li><a href="<%= Url.Action("Estatuto", "Liber") %>">Estatuto</a></li>
			    <li><a href="<%= Url.Action("Lideranca", "Liber") %>">Lideranças Nacionais</a></li>
                <%-- <li><a href='<%= Url.Action("Contas", "Partido") %>'>Prestação de Contas</a></li> --%>
            </ul>
        </div>

        <h2>Presidente Nacional</h2>
        <ul>
            <li>Juliano Torres</li>
        </ul>

        <h2>Vice-presidente Nacional</h2>
        <ul>
            <li>Bernardo Santoro Pinto Machado</li>
        </ul>

        <h2>Secretário Geral</h2>
        <ul>
            <li>Guilherme Inojosa Fragoso Cavalcanti</li>
        </ul>

        <h2>Tesoureiro</h2>
        <ul>
            <li>Bruno Paludo</li>
        </ul>

        <h2>Comite Julgador</h2>
        <ul>
            <li>Caio Magno Lima Campos</li>
            <li>Fernando Fiori Chiocca</li>
            <li>Filipe Rangel Celeti</li>
            <li>Pedro Henrique Ferreira González</li>
            <li>Thiago Guedes Santos</li>
        </ul>

        <h2>Comite Fiscal</h2>
        <ul>
            <li>Geraldo Boz Junior</li>
            <li>Hélio Marcos Coutinho Beltrão</li>
            <li>Thiago Pinheiro de Souza</li>
        </ul>

        <h2>Comite Executivo</h2>
        <ul>
            <li>André Luiz de Freitas Paranhos</li>
            <li>Antônio Mariz Sales Neto</li>
            <li>Bruno Paludo</li>
            <li>Carlo Sivieri de Assis Rocha</li>
            <li>Luciana Lopes Nominato Braga</li>
            <li>Roberto Fiori Chiocca</li>
            <li>Sidnei Santana</li>
        </ul>

    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>