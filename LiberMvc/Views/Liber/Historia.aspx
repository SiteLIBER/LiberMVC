<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

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
                <%-- <li><a href='<%= Url.Action("Contas", "Partido") %>'>Prestação de Contas</a></li> --%>
            </ul>
         </div>


        <p>
            O Libertários (LIBER) surgiu a partir de questionamentos e
            discussões numa comunidade da rede de relacionamentos,
            o Orkut, sobre quando iria ser criado um partido defensor da
            Liberdade no Brasil. Após este questionamento, Fernando Fiori
            Chiocca resolveu criar uma comunidade específica, no final
            de 2005, para reunir pessoas com este objetivo.
        </p>

        <p>
            Passado cerca de 3 anos de muitos debates,
            discussões e de várias mudanças entre os membros, o Libertários
            teve finalmente sua primeira reunião nacional que aconteceu dia
            20 de junho de 2009 na cidade de Belo Horizonte, em Minas Gerais.
            Nesta data foi aprovado o estatuto, o programa e elegeu-se o
            diretório nacional com o objetivo de estruturar o LIBER e
            prepará-lo para futuramente participar das discussões políticas
            em nível nacional.
        </p>

        <ul class="annexes">
            <li class="pdf_file">
                <a runat="server" href="~/Content/download/Ata_CGNacional_2010.04.10.pdf" target="_blank">
                    Ata da Convenção Geral do Diretório Nacional do
                    Libertários em Porto Alegre na data de 10 de abril de
                    2010.
                </a>
            </li>
            <li class="pdf_file">
                <a runat="server" href="~/Content/download/fundacao.pdf" target="_blank">Veja a ata de fundação aqui.</a>
            </li>
        </ul>

    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
