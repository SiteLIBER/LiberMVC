<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel" id="post">
        <h1>Filosofia</h1>

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
            A premissa básica dessa filosofia diz que é ilegítimo praticar agressão
            contra não agressores. O que se quer dizer com agressão não é assertividade,
            argumentatividade, competitividade, ousadia, disputabilidade ou antagonismo.
            O que se quer dizer com agressão é o emprego da violência, como a que tem
            lugar no assassinato, estupro, assalto ou sequestro. O Libertarianismo não
            implica em pacifismo; não proíbe o uso da violência em legítima defesa ou mesmo
            retaliação à violência. A filosofia libertária condena apenas iniciar a violência
            o uso de violência contra uma pessoa não violenta ou sua propriedade.
        </p>

        <p>
            Nada há de impróprio ou controverso nesta visão. A maioria das pessoas a apóia
            de todo o coração. E, sem dúvida, esse sentimento é parte e parcela da nossa
            civilização ocidental, guardada no relicário do direito natural.
        </p>

        <p>
            A singularidade do Libertarianismo é encontrada, não na declaração de seu princípio
            básico, mas na maneira rigorosamente consistente a qual o princípio é aplicado.
            Por exemplo, a maioria das pessoas não vê qualquer contradição entre este
            princípio e nosso sistema tributário. O Libertarianismo vê.
        </p>

        <p>
            A tributação é contrária ao princípio básico, porque envolve agressão contra
            cidadãos não agressivos que se recusam a pagar impostos. Não faz a menor
            diferença que o governo ofereça bens e serviços em troca da arrecadação.
            O importante é que o chamado comércio (dinheiro em impostos por serviços do governo)
            é coagido. O indivíduo não é livre para rejeitar a oferta. Tampouco o fato de que
            a maioria dos cidadãos apóie essa tributação coercitiva faz qualquer diferença.
            Mesmo quando endossada pela maioria, a iniciação de agressão física não é legítima.
            O Libertarianismo condena-a nessa área, como a condena onde quer que ocorra.
        </p>

        <p>
            Outra diferença entre as crenças dos liberais e as de outros membros da sociedade
            é o anverso da visão de que a violência iniciatória é maligna. Os
            libertários defendem que, no que se refere à teoria política, qualquer
            coisa que não envolve a iniciação de agressão não é maligna, e que, no que
            respeita a teoria política, qualquer coisa que não envolve a iniciação de
            violência não é um mal punível e não deveria ser considerada ilegal.
        </p>

    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>