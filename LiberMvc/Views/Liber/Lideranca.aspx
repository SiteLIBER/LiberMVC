<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel" id="post">
        <h1>Lideranças nacionais</h1>
        
        <ul class="formatted_list">
            <li class="highlight"><strong>Presidente Nacional</strong>
                <a href="http://www.facebook.com/profile.php?id=100002078219123" target="_blank">Bernardo Santoro Pinto Machado</a>
            </li>
            <li><strong>Vice-presidente Nacional</strong>
                <a href="http://www.facebook.com/carlo.rocha" target="_blank">Carlo Rocha</a> 
            </li>
            <li><strong>Secretário Geral</strong>
			    <a href="http://www.facebook.com/Julianotorres" target="_blank">Juliano Torres</a>           
            </li>
            <li><strong>Tesoureiro</strong>
                <a href="http://www.facebook.com/Bruno.Paludo" target="_blank">Bruno Paludo</a>
            </li>
            <li><strong>Relações Públicas</strong>
                <a href="http://www.facebook.com/luciana.lnb" target="_blank">Luciana Lopes Nominato Braga</a>
            </li>
            <li><strong>Captação de Recursos</strong>
                <a href="http://www.facebook.com/fkirsch" target="_blank">Felipe Kirsch</a>
            </li>
            <li><strong>Comunicação</strong>
                <a href="http://www.facebook.com/odilon.candido" target="_blank">Odilon Candido</a>
            </li>
            <li><strong>Marketing</strong>
                <a href="http://www.facebook.com/profile.php?id=800879729" target="_blank">André Rufino</a>
            </li>
            <li><strong>Corregedora</strong>
                <a href="http://www.facebook.com/luciana.lnb" target="_blank">Luciana Lopes Nominato Braga</a>            
            </li>
        </ul>

        <div style="float: left; padding-right: 15px">
            <h2>Comite Julgador</h2>

            <ul class="formatted_list" style="margin: 0px;">
                <li><a href="http://www.facebook.com/caiomagnolc" target="_blank">Caio Magno Lima Campos</a></li>
                <li><a href="http://www.facebook.com/chiocca" target="_blank">Fernando Fiori Chiocca</a></li>
                <li><a href="http://www.facebook.com/filipeceleti" target="_blank">Filipe Rangel Celeti</a></li>
                <li><a href="http://www.facebook.com/profile.php?id=100001335191421&ref=ts" target="_blank">Pedro Henrique Ferreira González</a></li>
                <li><a href="http://www.facebook.com/rchiocca" target="_blank">Roberto Fiori Chiocca</a></li>
            </ul>
        </div>

        <div style="float: left;  padding-right: 15px">
            <h2>Comite Fiscal</h2>

            <ul class="formatted_list" style="margin: 0px;">
                <li><a href="http://www.facebook.com/profile.php?id=100001878387467" target="_blank">Geraldo Boz Junior</a></li>
                <li><a href="http://www.facebook.com/heliob" target="_blank">Hélio Marcos Coutinho Beltrão</a></li>
                <li><a href="http://www.facebook.com/profile.php?id=100000921473730" target="_blank">Thiago Pinheiro de Souza</a></li>
            </ul>
        </div>

        <div style="float: left">
            <h2>Comite Executivo</h2>

            <ul class="formatted_list" style="margin: 0px;">
                <li><a href="http://www.facebook.com/profile.php?id=800879729" target="_blank">André Rufino</a></li>
                <li><a href="http://www.facebook.com/brunobca" target="_blank">Bruno Aguiar</a></li>
                <li><a href="http://www.facebook.com/Bruno.Paludo" target="_blank">Bruno Paludo</a></li>
                <li><a href="http://www.facebook.com/fcastanhola" target="_blank">Fabiano Marques</a></li>
				<li><a href="http://www.facebook.com/fkirsch" target="_blank">Felipe Kirsch</a></li>
				<li><a href="http://www.facebook.com/profile.php?id=1663780584" target="_blank">Guilherme Inojosa Fragoso Cavalcanti</a></li>
				<li><a href="http://www.facebook.com/max.salles" target="_blank">Herond Salles</a></li>
				<li>Itamar Oliveira</li>
				<li>Kaio Felipe Santos</li>
                <li><a href="http://www.facebook.com/luciana.lnb" target="_blank">Luciana Lopes Nominato Braga</a></li>
                <li><a href="http://www.facebook.com/MujoGT" target="_blank">Ney Fonseca</a></li>
                <li><a href="http://www.facebook.com/sidneisantana" target="_blank">Sidnei Santana</a></li>
				<li><a href="http://www.facebook.com/profile.php?id=100001114750010" target="_blank">Willian Adamczyk</a></li>
            </ul>
        </div>

    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>