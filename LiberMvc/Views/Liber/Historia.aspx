﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel" id="post">
        <h1>História</h1>

        <div id="index">
            <h1>Nosso Partido</h1>
					<ul>
						<li><a href="<%= Url.Action("Historia", "Liber") %>">História</a></li>
						<li><a href="<%= Url.Action("Filosofia", "Liber") %>">Filosofia</a></li>
						<li><a href="<%= Url.Action("Programa", "Liber") %>">Programa</a></li>
						<li><a href="<%= Url.Action("Estatuto", "Liber") %>">Estatuto</a></li>
						<li><a href="<%= Url.Action("Lideranca", "Liber") %>">Lideranças Nacionais</a></li>
						<li><a href='<%= Url.Action("Contas", "Liber") %>'>Prestação de Contas</a></li>
					</ul>
         </div>

        <p>
            A ideia de criar o Libertários surgiu na rede social Orkut.
            Foi criada uma comunidade e interessados começaram a entrar.
            Por lá mesmo começamos a esboçar nossas propostas, todas advindas
            da aplicação do Libertarianismo. A primeira geração do partido
            começou a estudar a lei eleitoral e exemplos para descobrir
            como fundar um partido no Brasil. Além disso, foi criado um site,
            mas toda a movimentação ocorria ainda nessa comunidade.
        </p>

        <p>
            O segundo momento marcante na nossa história aconteceu em Belo
            Horizonte em Junho de 2009. Nessa ocasião os fundadores realizaram uma
            convenção nacional para fundar o LIBER. Nesse evento foi aprovado o
            nosso estatuto, nosso programa e também foi eleito um diretório
            nacional com o objetivo de se responsabilizar oficialmente pelo
            LIBER e perseguir os passos para sua fundação.
        </p>

        <p>
            Em 19 de janeiro de 2010 conseguimos publicar o nosso estatuto e programa no
            Diário Oficial da União, nos tornando assim oficialmente um partido,
            mas ainda nesse momento em organização.
        </p>

        <p class="image">
            <img src="<%= Url.Content("~/Content/images/fundacao.jpg") %>" alt="Fundação" /><br />
            <span class="legend">Reunião de fundação do LIBER, 20 de Junho de 2009.</span>
        </p>

        <p>
            Em Abril de 2010 realizamos nossa segunda convenção nacional e nela
            foi corrigido alguns rumos do LIBER. Desde lá passamos a tentar
            profissionalizar as atividades partidárias e nos posicionar
            de forma mais adequada.
        </p>

        <p>
            Nosso CNPJ que nos permite abrir conta e banco e fazer compras
            em nome da instituição partido Libertários foi alcançado em janeiro
            de 2011, completando assim a primeira etapa da fundação
            de um partido, que é o registro civil.
        </p>

        <p>
            Nesse exato momento estamos nos organizando para concluir a segunda etapa,
            que é recolher cerca de 500 mil assinaturas de apoio ao registro do partido
            Libertários no TSE. Se você tem disposição e quer ver a liberdade
            triunfando no Brasil, ajude-nos nessa tarefa.
        </p>

        <ul class="annexes">
            <li class="pdf_file">
                <a id="A1" href="<%= Url.Content("~/Content/download/carta_helio_beltrao.pdf") %>" target="_blank">Carta de Helio Beltrao em apoio a fundação do LIBER.</a>
            </li>
            <li class="pdf_file">
                <a href="<%= Url.Content("~/Content/download/Ata_CGNacional_2010.04.10.pdf") %>" target="_blank">
                    Ata da Convenção Geral do Diretório Nacional do
                    Libertários em Porto Alegre na data de 10 de abril de
                    2010.
                </a>
            </li>
            <li class="pdf_file">
                <a href="<%= Url.Content("~/Content/download/fundacao.pdf") %>" target="_blank">Veja a ata de fundação aqui.</a>
            </li>
        </ul>

    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
