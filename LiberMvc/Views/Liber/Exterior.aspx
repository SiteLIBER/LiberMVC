<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel" id="post">
        <h1>Relações Exteriores</h1>

	    <div id="index">
            <h1>Índice</h1>

		    <ul>
        	    <li style="border:none"><a href="#PoliticaDiplomatica"><strong>A. Politica diplomática</strong></a>
            	    <ul>
            		    <li><a href="#Negociacoes">1. Negociações</a></li>
                        <li><a href="#BrasileirosNoExteriorEDireitosHumanos">2. Brasileiros no exterior e Direitos Humanos</a></li>
                    </ul>
                </li>
            
                <li style="border:none"><a href="#ForcasArmadas"><strong>B. Forças Armadas</strong></a>
            	    <ul>
            		    <li><a href="#PoliticaMilitar">1. Política Militar</a></li>
                    </ul>
                </li>
            
                <li style="border:none"><a href="#PolticaEconomica"><strong>C. Política econômica</strong></a>
            	    <ul>
            		    <li><a href="#AjudaInternacional">1. Ajuda internacional</a></li>
                        <li><a href="#MoedasEstrangeiras">2. Moedas estrangeiras</a></li>
                        <li><a href="#RecursosSemDono">3. Recursos sem Dono</a></li>
                    </ul>
                </li>
            </ul>
    
		    <h1>Ideias</h1>
		    <ul>
			    <li><a href="<%= Url.Action("Direitos", "Liber") %>">Direitos Individuais</a></li>
			    <li><a href="<%= Url.Action("Economia", "Liber") %>">Comércio e Economia</a></li>
			    <li><a href="<%= Url.Action("Domestico", "Liber") %>">Assuntos Domésticos</a></li>
			    <li><a href="<%= Url.Action("Exterior", "Liber") %>">Relações Exteriores</a></li>
			    <%--<li><a href="<%= Url.Action("FAQ", "Liber") %>">Perguntas Frequentes</a></li>--%>
		    </ul>
	    </div>

        <p>
            A política externa do Brasil deve ser pautada pela manutenção da paz e pela
            defesa contra qualquer forma de ataque à vida, à propriedade ou à liberdade dos
            cidadãos brasileiros ou em território nacional. É imperativo à qualquer ação de defesa
            respeitar os direitos individuais de todas as pessoas. As relações entre os Estados
            devem ser pautadas pelo princípio da não-intervenção. O governo brasileiro deve evitar
            a formação de alinhamentos automáticos e se abster de realizar ou de participar de
            qualquer ação imperialista, reconhecendo o direito ao livre comércio, viagens e imigração.
        </p>
        
        <h2><a name="PoliticaDiplomatica">A. Política diplomática</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <h2><a name="Negociacoes">1. Negociações</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
            <strong>A questão:</strong> A intervenção do governo brasileiro nos assuntos de outros
            Estados é uma tentativa de impor nossos valores a outras nações através
            da força, mesmo quando em ação conjunta com outros governos.
        </p>
        
        <p>
            <strong>O princípio:</strong> O mais importante princípio de política externa
            deve ser a eliminação da intervenção do governo brasileiro nos assuntos de outros
            Estados. Não precisamos participar de nenhuma espécie de governo mundial
            para mantermos relações diplomáticas com outras nações
        </p>
        
        <p>
            <strong>Soluções:</strong> Nós somos a favor de uma drástica redução no custo e no tamanho
            de nosso corpo diplomático. Podemos negociar com qualquer governo estrangeiro sem conceder,
            necessariamente, legitimidade moral a esse governo. Apoiamos a retirada do Brasil das Nações
            Unidas e o fim do auxílio financeiro a essa organização. Somos contrários a assinar
            qualquer tratado que possibilite a violação dos direitos individuais.
        </p>
        
        <p>
            <strong>Ações transitórias:</strong> Especificamente, nos opomos a qualquer política
            que designe as Nações Unidas como força policial do mundo, comprometendo as tropas
            nacionais a participarem de guerras sob o comando da ONU.
        </p>
        
        <h2><a name="BrasileirosNoExteriorEDireitosHumanos">2. Brasileiros no exterior e direitos humanos</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
            <strong>A questão:</strong> Nós condenamos as violações aos direitos humanos ocorridas
            em qualquer parte do mundo. Reconhecemos que governos estrangeiros podem violar os
            direitos dos brasileiros que se encontram ou possuem propriedades no exterior, assim como
            esses governos violam os negócios de seus próprios cidadãos. Entretanto, qualquer esforço
            para estender a proteção do governo do Brasil aos cidadãos brasileiros que se encontram ou
            possuem propriedades sob jurisdição de outros Estados envolve risco de intervenção militar,
            da mesma forma que a tentativa de estender esta proteção aos estrangeiros em geral. Em particular,
            a proteção de investimentos de cidadãos ou negócios brasileiros no estrangeiro é uma forma
            injusta de auxílio, pois implica em custos que serão financiados por todos os cidadãos brasileiros.
        </p>
        
        <p>
            <strong>O princípio:</strong> Nós condenamos toda violação dos direitos de propriedade, tanto
            de cidadãos brasileiros como de estrangeiros. Nós solicitamos ao governo brasileiro a plena adesão
            ao princípio de que os cidadãos de nosso país assumam por conta própria os riscos de viajar,
            viver e possuir negócios no exterior, seguindo o princípio de não intervir nos assuntos
            internos de outros países.
        </p>
        
        <p>
            <strong>Soluções:</strong> Nós estamos ansiosos pela era em que todas as pessoas poderão viajar
            pelo mundo sem a necessidade de passaporte. Objetivamos a eliminação de todo e qualquer passaporte,
            visto ou outros papéis exigidos para atravessar fronteiras.	
        </p>
        
        <p>
            <strong>Ações transitórias:</strong> As embaixadas brasileiras devem informar nossos cidadãos que
            eles estão sujeitos a leis estrangeiras quando eles viajam ou investem em outro país.
            O governo brasileiro não pode isolar nossos cidadãos das leis estrangeiras quando eles se encontram
            fora do país; nossas embaixadas não podem assumir a responsabilidade de proteger cidadãos das
            conseqüências de suas próprias condutas enquanto eles se encontram em outros Estados, da mesma
            forma que não o podem fazer com estrangeiros em geral
        </p>

        <h2><a name="ForcasArmadas">B. Forças Armadas</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <h2><a name="PoliticaMilitar">1. Política Militar</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>	
            <strong>A questão:</strong> O uso potencial de armas nucleares é a maior ameaça a todos os povos
            do mundo. Logo, devemos buscar reduzir ao mínimo o risco de uma guerra nuclear.
        </p>
        
        <p>
            <strong>O princípio:</strong> Qualquer política militar brasileira deve ter como objetivo aumentar
            a segurança para as vidas, a liberdade e a propriedade de seus cidadãos, que vivem em território
            nacional, contra o risco de um ataque externo. Esse objetivo deve ser alcançado ao menor
            custo financeiro possível e sem prejuízo às liberdades que o mesmo busca proteger.
        </p>
        
        <p>
            <strong>Soluções:</strong> As armas de destruição em massa das forças brasileiras devem ser
            substituídas por armamentos menores, feitos para atingir alvos militares e não para
            matar milhões de civis. Incentivamos a substituição das políticas de corrida nuclear por uma
            política de implantação de sistemas defensivos com melhor relação custo-benefício.
            Conforme essa idéia, somos contrários a qualquer acordo futuro que impeça a instalação de
            sistemas de defesa no território brasileiro ou na órbita da Terra.
        </p>
        
        <p>
            <strong>Ações transitórias:</strong> Pedimos a retirada das tropas brasileiras que se encontram no
            exterior,participando das missões de paz da ONU. Não há qualquer prognóstico que indique que
            o povo brasileiro corra risco de sofrer um ataque militar convencional, particularmente de longas distâncias.
            Solicitamos a retirada do Brasil de qualquer acordo que o comprometa a participar de guerras por
            causa de outros governos e também o abandono de doutrinas que pregam a
            liderança do Brasil sobre os outros países da América do Sul.
        </p>

        <h2><a name="PoliticaEconomica">C. Política econômica</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <h2><a name="AjudaInternacional">1. Ajuda internacional</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
            <strong>A questão:</strong> O governo federal utiliza a ajuda internacional como um meio
            para influenciar a política de outras nações soberanas ao prestar auxílio às pessoas necessitadas
            nesses países. Isso obriga os cidadãos brasileiros a subsidiar governos e
            políticas com as quais eles podem não concordar.
        </p>
        
        <p>	
            <strong>O princípio:</strong> Os indivíduos não devem ser obrigados, através do
            pagamento de impostos, a financiar uma nação ou grupo estrangeiro.
        </p>	
            
        <p>		
            <strong>Ações transitórias:</strong> Eliminar toda forma de auxílio militar, econômico,
            técnico e científico, sustentada através dos impostos, a governos ou organizações estrangeiras.
            Abolir o subsídio do governo à venda de armas. Abolir todos os órgãos federais que tornam o
            cidadão brasileiro que paga impostos um fiador das operações de empréstimo relacionadas à exportação.
            Encerrar a participação do governo brasileiro nos círculos internacionais de commodities que
            restringem a produção, limitam a inovação tecnológica e aumentam os preços. Acabar com todas
            as proibições a indivíduos ou empresas que desejam manter negócios com qualquer país
            ou organização estrangeira, a menos que o negócio se constitua em uma
            ameaça direta ao povo brasileiro.
        </p>
	
        <h2><a name="MoedasEstrangeiras">2. Moedas estrangeiras</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>		
            <strong>A questão:</strong> O envolvimento do governo federal no mercado internacional de câmbio
            solapa estabilidade do Real, cuja cotação é modificada artificialmente, o que prejudica a
            liberdade dos mercados.	
        </p>
        
        <p>		
            <strong>O princípio:</strong> Os cidadãos, através da liberdade de comércio nos mercados,
            devem constituir o único fator determinante do valor de bens e serviços.
        </p>
        
        <p>	
            <strong>Soluções:</strong> O envolvimento do governo nos mercados de câmbio internacionais, juntamente com 
            as reservas financeiras do Banco Central deveriam ser extintos, e o comércio realizado
            pelos setores privados deve ser o único fator a influenciar a cotação da moeda.
        </p>
        
        <p>			
            <strong>Ações transitórias:</strong> O Brasil deve liquidar as reservas em moeda estrangeira,
            bem como outras formas de crédito que gerem inflação. O país deve se retirar do Banco Mundial e
            do Fundo Monetário Internacional. Opomos-nos com veemência ao papel de fiador de
            governos estrangeiros exercidos pelo Brasil ou pelos bancos brasileiros, ou mesmo através
            do Fundo Monetário Internacional ou outro meio governamental.		
        </p>
        
        <h2><a name="RecursosSemDono">3. Recursos sem Dono</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
            <strong>A questão:</strong> Governos e grupos internacionais reivindicam o direito aos recursos sem
            dono, apesar de não possuírem jurisdição sobre esses, impondo tais reivindicações
            contra indivíduos através da força.		
        </p>
        
        <p>			
            <strong>O princípio:</strong> Indivíduos têm o direito de usufruir, junto com os governos nacionais,
            dos recursos sem dono e também de territórios internacionais como o oceano, a Antártida e o espaço cósmico.
        </p>
        
        <p>			
            <strong>Soluções:</strong> Somos contrários ao reconhecimento de qualquer reivindicação de
            governos nacionais ou organizações internacionais sobre territórios internacionais.
            É fundamental o desenvolvimento de um padrão internacional para o reconhecimento de
            reivindicações a propriedade feitas por particulares como no caso das pistas de transportes,
            faixas de transmissão, direito à exploração de minérios, à pesca e ao cultivo em oceanos.		
        </p>
        
        <p>			
            <strong>Ações transitórias:</strong> Todas as leis, tratados e acordos internacionais que
            restringem ou impedem o usufruto de recursos sem dono devem ser abolidos. Nós propomos,
            especificamente, que o Brasil recuse em aceitar o proposto Tratado sobre Direito do Mar
            porque ele exclui o princípio da propriedade privada. Logo, somos contrários
            a uma futura ratificação desse tratado.
        </p>
	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">

	<% Html.RenderPartial("RightMenu"); %>

</asp:Content>
