<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

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

    <div class="panel" id="post">
        <h1>Programa</h1>

        <p>
            Nós, os Libertários, defendemos:
        </p>

        <p>
            <strong>Quanto à Organização do Estado:</strong> descentralização administrativa e real
            federalismo; redução drástica da carga tributária; simplificação dos impostos;
            fim da progressividade tributária e das cobranças em cascata.
        </p>

        <p>
            <strong>Quanto aos Direitos Individuais:</strong> o direito de propriedade é o
            direito individual essencial e não pode ser relativizado em nenhuma hipótese.
            Negamos a função social da propriedade e a função social dos contratos.
            A liberdade de escolha do indivíduo não pode ser suprimida, salvo em caso de
            lesão ao direito de outrem. Defendemos, ainda, a descriminalização dos
            "crimes sem vítima"; descriminalização do uso de drogas;
            legalização de jogos de azar; união civil entre quaisquer cidadãos e
            liberdade de formas do casamento; fim do alistamento militar obrigatório;
            fim da discriminação oficial estabelecida pelas cotas raciais; garantia do
            direito à posse e porte de arma; reforma política ampla, liberdade para
            criação de partidos, inclusive regionais, correção da proporcionalidade
            na Câmara dos Deputados, fim do fundo partidário e fim do voto obrigatório;
            liberdade de imigração e emigração.
        </p>

        <p>
            <strong>Quanto aos Serviços Públicos:</strong> retirada do Estado da prestação de serviços
            públicos, tais como educação, saúde, infra-estrutura, administração
            presidiária, entre outros.
        </p>

        <p>
            <strong>Quanto ao Sistema Econômico:</strong> eliminação dos controles de salários, preços,
            aluguéis, lucros, produção e juros; fim do favorecimento público a setores
            privados da economia; fim do controle monetário com extinção do Banco Central;
            plena liberdade econômica; fim dos monopólios estatais; privatização das
            empresas públicas e sociedades de economia mista; fim da interferência
            governamental nas relações trabalhistas com total liberdade entre as partes;
            liberdade de organização sindical; livre mercado com circulação de bens,
            produtos e serviços.
        </p>

    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>