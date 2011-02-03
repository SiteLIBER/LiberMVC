﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<div class="panel" id="post">
		<h1>Assuntos domésticos</h1>

 	    <div id="index">
    	    <h1>Índice</h1>

            <ol>
			    <li><a href="#">Energia</a></li>
                <li><a href="#">Poluição</a></li>
                <li><a href="#">Proteção ao Consumidor</a></li>
                <li><a href="#">Educação</a></li>
                <li><a href="#">População</a></li>
                <li><a href="#">Transporte</a></li>
                <li><a href="#">Pobreza e desemprego</a></li>
                <li><a href="#">Leis Trabalhistas (CLTs)</a></li>
            <li><a href="#PrevidenciaSocial">Previd&ecirc;ncia Social</a></li>
            <li><a href="#Saude">Sa&uacute;de</a></li>
            <li><a href="#UsoDosRecursos">Uso dos recursos naturais</a></li>
            <li><a href="#Agricultura">Agricultura</a></li>
            <li><a href="#LeisEleitorais">Leis eleitorais</a></li>
            <li><a href="#Secessao">Secess&atilde;o</a>   </li>
            </ol>
    
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
 Os problemas atuais em áreas como energia, poluição, saúde, cidades em decadência e pobreza não são solucionados, mas causados pelo governo. O assistencialismo, supostamente desenvolvido para ajudar os pobres, é na verdade uma carga crescente e parasita carregada por todas as pessoas produtivas, e prejudica, ao invés de beneficiar, os pobres.
        </p>
        
        <h2><a name="Energia">1. Energia</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> O controle do governo sobre a indústria de entergia resultou em altos preços, apagões, falta de competição, falta de exploração e falta de desenvolvimento de fontes alternativas de energia, além de dar vantagem no mercado existente àqueles com acesso político.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Defendemos a criação de um livre mercado de petróleo instituindo direito de propriedade sobre petróleo subterrâneo e condenamos todos os controles pelo governo sobre a saída na indústria de petróleo. A indústria de energia nuclear deve ser testada em livre mercado. Nos opomos ao controle governamental sobre o preço da energia, alocação e produção. Nos opomos à criação de uma agência de mobilização na área de energia.
		</p>
        
        <p>
        	<strong>Soluções:</strong> Todos os recursos enérgicos possuídos pelo governo devem ser privatizados. Energia nuclear deve ser desnacionalizada e as posses na indústria transferidas para o setor privado. Fim de todas as participações diretas e indiretas na indústria de energia nuclear, incluindo subsídios, pesquisa e fundos para desenvolvimento, empréstimos garantidos, subsídios para jogar o lixo, e agências federais, civis e militares, de enriquecimento de urânio. Privatização de todas as empresas públicas de prospecção e distribuição de petróleo e derivados e qualquer tentativa de aumentar impostos sobre petróleo ou a imposição de quotas de petróleo. A abertura do mercado deverá, por si só, gerar competição para busca de novas fontes de energia, inclusive a renovável.
        </p>
        
        <h2><a name="Poluicao">2. Poluição</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> A poluição do meio-ambiente é vista hoje sob uma perspectiva socialista e estatista, onde o meio-ambiente é um bem “público” não passível de apropriação e os danos causados devem ser reparados mediante indenização ao Estado, que nunca repassa os valores para o meio-ambiente degradado.
        </p>
        
        <p>
        	<strong>O princípio:</strong> A defesa da vida, liberdade e propriedade privada é o único papel legítimo do Estado. A publicização do meio-ambiente acarreta em ineficiência na sua proteção e impede que os verdadeiros atingidos pela poluição receba a justa indenização pela violação da sua propriedade privada, tanto de seu corpo quanto de seus bens.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Desenvolver um sistema legal objetivo definindo os direitos de propriedade para o ar e a água. A defesa do meio-ambiente deve ser feita através dos proprietários que forem lesados ou possuam potencial para serem lesados por poluidores. O Governo não deve intervir na questão como parte, pois as indenizações são desviadas por burocratas e nunca chegam a seu destino. Extinção de agências e órgãos reguladores do meio-ambiente, que impedem o exercício do direito de propriedade dos cidadãos.
        </p>
        
        <h2><a name="ProtecaoAoConsumidor">3. Proteção ao Consumidor</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Regulações de proteção ao consumidor pelo governo restringem a competição do livre mercado e substituem o direito de um indivíduo fazer escolhas independentes por padrões determinados pelo governo.
        </p>
        
        <p>
        	<strong>O princípio:</strong> A demanda dos consumidores deve reger a proteção ao consumidor. Defendemos fortes e efetivas leis para que o conteúdo dos produtos esteja nos lacres e defesa contra fraudes.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Extinção de órgãos que certificam produtos para o consumidor, passando esse encargo para entidades privadas, com elaboração de leis que defendam os consumidores de fraudes. Extinção de regulações paternalistas que impõem preços, definem padrões para produtos, ou restringem a possibilidade de correr riscos e livre escolha. Extinção de leis que obrigam o consumidor a consumir o produto ou serviço de maneira determinada, tal como o uso de cinto de segurança em veículos automotores.
        </p>
        
        <h2><a name="Educacao">4. Educação</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Escolas públicas levam à doutrinação das crianças ou interferem na livre escolha dos indivíduos. Leis de educação compulsória geram escolas com muitos problemas semelhantes a prisões.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Educação, como qualquer outro serviço, pode ser melhor executado pelo livre mercado, alcançando maior qualidade e eficiência com maior diversidade de escolha.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Defesa da completa separação entre educação e estado. Posse, operação, regulação e subsídios pelo governo de escolas, colégios e universidades devem cessar. Fim das garantias da educação pública. Extinção das leis de educação compulsória. Apoio à redução imediata de ajuda fiscal para escolas e remoção de tributos que tenham finalidade de custear educação, pois cidadãos não são responsáveis pela educação de crianças que não são seus filhos. Extinção de todos os tributos que incidam no sistema educacional. Como medida transitória, defesa da privatização das escolas públicas e entrega de vales-escola para as crianças que delas necessitarem.
        </p>
        
        <h2><a name="Populacao">5. População</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Observamos que as tragédias causadas por gestações não desejadas são agravadas, se não criadas, por políticas governamentais de censura, restrição e proibição.
        </p>
        
        <p>
        	<strong>O princípio:</strong> O povo brasileiro não é um recurso nacional colecionável. Nos opomos a quaisquer medidas coercivas para controle populacional.
        </p>
        
        
        <p>
        	<strong>Soluções:</strong> Combater ações governamentais que compelem ou proíbem aborto, promovem esterilização ou quaisquer outras formas de controle de natalidade. Especificamente, condenar qualquer tentativa de elaborar leis que visem a esterilização forçada de miseráveis, deficientes mentais ou indivíduos com problemas de saúde. Revogar todas as leis que restringem a participação em trocas voluntárias de mercadorias, serviços ou informação relacionada à sexualidade humana, reprodução, controle de natalidade ou tecnologias médicas ou biológicas relacionadas ao assunto. Oposição a leis governamentais e políticas que restrinjam a oportunidade de escolher alternativas para o aborto.
        </p>
        
        <h2><a name="Transporte">6. Transporte</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> A interferência do governo no transporte é caracterizada por restrição monopolística, corrupção e ineficiência.
        </p>
        
        <p>
        	<strong>O princípio:</strong> A prestação de serviços de transportes deve ser tratada como qualquer serviço, sendo prestada através de mercados livres e mantida por responsabilidade judicial rigorosa.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Fim de todos os órgãos governamentais que promovem e regulam o transporte, e transferência de suas funções a entidades privadas competitivas. Privatização de aeroportos, ferrovias, sistemas de controle de tráfego e estradas públicas. Extinção de leis que regulam o consumo de bebidas alcoolicas no trânsito e fim de favores governamentais à indústria de automobilística. Extinção de leis restringindo a competição da área automobilística tais como monopólios de taxi e ônibus e a proibição de serviços de micro-ônibus e vans. Defesa do transporte alternativo.
        </p>
        
        <h2><a name="PobrezaEDesemprego">7. Pobreza e desemprego</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Ações fiscais e monetárias do governo que estimulam artificialmente a expansão dos negócios garantem um eventual aumento no desemprego ao invés de reduzi-lo. Programas do governo são ineficientes, paternais, humilhantes e invasivos na privacidade.
        </p>
        
        <p>
        	<strong>O princípio:</strong> A forma adequada de ajuda para os pobres é através de esforços voluntários de grupos privados e indivíduos. Nenhum trabalhador deve ser legalmente penalizado pela falta de certificação e nenhum consumidor deve ser legalmente restrito de contratar indivíduos não-licenciados.
        </p>
        
        <p>
            <strong>Soluções:</strong> Eliminação da obrigatoriedade de certificação oficial para trabalhar em qualquer área. Abolição de todas as agências governamentais e não-governamentais federais, estaduais e locais que restrinjam a entrada em qualquer profissão ou regulam sua prática. Extinção de todo auxílio-desemprego, projetos de esmola e programas de ajuda aos pobres. Extinção de todas as leis que impedem um indivíduo de encontrar um emprego, tais como salário mínimo, a chamada “legislação protetiva” para mulheres e crianças, restrições governamentais no estabelecimento de creches, e a CLT. Fim do incentivo governamental para aposentadoria forçada. Estimular a subtituição do Estado pela iniciativa privada do campo da solidariedade através de maciços abatimentos em impostos em virtude de doações para entidades de caridade privadas.</p>
        <h2><a name="LeisTrabalhistasCLTs">8. Leis Trabalhistas (CLTs)</a></h2>
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        <p> <strong>O Assunto:</strong> As ações arbitrárias da Justiça do Trabalho invadem os direitos à propriedade, elevam preços, geram desemprego e se impõem injustamente sobre os geradores de emprego. Acabam por transformar empregadores em criminosos e empregados em vítimas, prejudicando a economia. </p>
        <p> <strong>O princípio:</strong> Essas leis negam o direito à liberdade e propriedade tanto ao empregado quanto ao empregador, e interfere em sua relação contratual privada. Uma sociedade de livre-comercio é baseada em trocas voluntárias e uma troca voluntária só acontece quando ambas as partes enxergam vantagens. Qualquer ação coercitiva por parte do governo que tire o livre arbítrio dos indivíduos e decida por eles o que é ou não vantajoso é errada. </p>
        <p> <strong>Soluções:</strong> Relações trabalhistas são trocas voluntárias entre empregado e empregador e cabe apenas às partes envolvidas a resolução dos termos contratuais. Grupos ativistas de consumidores do setor privado devem ser criados para substituir agências governamentais ineficientes. Abolição de todas as leis trabalhistas.</p>
        <h2><a name="PrevidenciaSocial">9. Previdência Social</a></h2>
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        <p> <strong>A questão:</strong> O sistema previdenciário é um falido e imoral esquema piramidal com valores absurdos de endividamento e possui uma taxa de retorno abaixo na média para seus participantes. </p>
        <p> <strong>O princípio:</strong> Numa sociedade livre, o plano de aposentadoria é responsabilidade do indivíduo e não do governo. </p>
        <p> <strong>Soluções:</strong> Defendemos a substituição da atual previdência pública, fraudulenta, falida e patrocinada pelo governo, por sistemas privados voluntários. Transitoriamente, liquidação da previdência social em fatias para instituições financeiras privadas e venda de bens pertencentes ao poder público para custear as atuais aposentadorias.</p>
        <h2><a name="Saude">10. Saúde</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> O Brasil é um dos poucos países do mundo que possuem uma rede universal pública de segurança de saúde. Em virtude dos incentivos perversos típicos do poder público, uma quantia obscena de dinheiro vilipendiado da sociedade pelo governo é destinado a um falido, imoral e ineficiente Sistema Único de Saúde, onde pessoas demoram horas na fila para serem atendidas. Os poucos privilegiados que conseguem pagar um plano privado de saúde após serem acharcados pelo Estado, sofrem nas mãos de um mercado altamente regulamentado por agências governamentais corruptas.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Reconhecemos o direito dos indivíduos, livres da intervenção do governo e seus danosos efeitos colaterais, de determinar o nível de seguridade que querem, o nível de saúde que querem, os provedores de saúde que querem, os remédios e tratamentos que querem usar e todos os outros aspectos da saúde. O papel do governo em qualquer tipo de seguridade deve ser apenas o de fazer valer contratos quando necessário, não o de ditar às seguradoras e consumidores quais tipos de contrato eles devem acordar voluntariamente.        </p>
        
        <p>
        	<strong>Soluções:</strong> Restaurar e reviver um mercado livre na área de saúde. Promover uma completa separação entre medicina e Estado. Acabar com o Sistema Único de Saúde e agências, como ANS e ANVISA, que controlam o mercado de saúde e promovem monopólio de empresas corrputoras. Todos os serviços de saúde são mais eficientemente providas pelo setor privado. Transitoriamente, privatização de todos os centros médicos públicos e fornecimento de vale-saúde para a população.
        </p>
        
        <h2><a name="UsoDosRecursos">11. Uso dos recursos</a> naturais </h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> O governo controla o uso dos recursos através de despropriação, leis de zona, códigos de construção, códigos de postura, controle de aluguel, estatutos urbanos e rurais, leis florestais e ambientais, entre outras medidas legais. Tais regulações e programas violam o direito de propriedade, discriminam minorias, criam falta de moradia e tendem a inflacionar os aluguéis. Todas as restrições governamentais sobre o uso privado ou transferência voluntária de direitos de água ou controles despóticos similares podem apenas agravar a má distribuição de água. 
        </p>
        
        <p>
        	<strong>O princípio:</strong> O uso dos recursos é responsabilidade e direito dos donos legítimos da terra, água e outros recursos naturais.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Estabelecer um sistema privado eficiente e justo de direitos sobre água aplicado tanto para água na superfície quanto para água no subsolo, baseado no princípio do <em>homesteading</em> (primeiro que usar). Promover a completa separação entre o fornecimento de água e o Estado, de modo a previnir crises de falta de água no futuro. Privatização de todos os projetos e empresas de águas governamentais. Fim de todos os órgãos e agências destinadas ao controle de recursos naturais. Revogar todas as leis que controlam e regulam o uso dos recursos naturais.
        </p>
        
        <h2><a name="Agricultura">12. Agricultura</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> O mercado livre da agricultura, sistema que alimenta grande parte do mundo, foi arado por intervenções do governo. Subsídios, regulações e taxas encorajaram a centralização do agronegócio. As políticas de exportação do governo fazem com que os fazendeiros sejam reféns dos caprichos das administrações públicas.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Tanto fazendeiros quanto consumidores devem ser livres das intromissões e medidas contra-produtivas dos governos em todos os níveis. Os cidadãos devem ser livres para plantar, vender ou comprar o que quiserem, na quantidade que quiserem, quando quiserem.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Agricultores e outros fornecedores de produtos e serviços no mercado livre da agricultura devem operar sem qualquer regulação governamental, enquanto são policiadas pelas agências de proteção ao consumidor do setor privado com relação à qualidade, e devem ser punidas pelo judiciário em casos de fraude e enganação. Eliminar todos os programas de governo para fazendas, incluindo suporte de preços, subsídios diretos e toda e qualquer regulação na produção agrícola. Desregulamentar a indústria de transportes, barateando o escoamento de produtos agrícolas. Fim do envolvimento do governo no controle de pestes na agricultura, que passa a ser responsabilidade dos agricultores.</p>
        
        <h2><a name="LeisEleitorais">13. Leis Eleitorais</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> O sistema eleitoral brasileiro é completamente distorcido. A obrigatoriedade de voto faz do mesmo um dever e não um direito. Há superrepresentação de estados pouco populosos e subrepresentação de estados muito populosos. A legislação eleitoral veda a liberdade política com restrição ao lançamento de candidaturas e criação de partidos.
        </p>
        
        <p>
        	<strong>O princípio:</strong> O sufrágio é um direito e não um dever. Esse direito é amplo e irrestrito, devendo o eleitor possuir a maior quantiadade possível de opções.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Proposição de um sistema eleitoral justo, que reflita a representatividade das correntes políticas no âmbito federal, estadual e local. Fim do controle governamental dos partidos politicos, permitindo liberdade de criação, associação e expressão, com possibilidade de existência de partidos regionais e locais. Fim do subsídio público aos partidos políticos, em especial o fundo partidário. Correção da representação dos Estados na Câmara dos Deputados.
        </p>
        
        <h2><a name="Secessao">14. Secessão</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> As pessoas são forçadas a se subordinar aos governos e participar de seus programas, geralmente como provedores de financiamento, independentemente de sua vontade.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Como toda associação política deve ser voluntária, reconhecemos o direito de secessão política. Isso inclui o direito de secessão por entidades políticas, grupos privados ou indivíduos. O exercício desse direito, assim como o exercício de todos os outros direitos, não anula obrigações legais e morais de não violar o direito de outros.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Defendemos o direito de entidades políticas, grupos privados e indivíduos a renunciar sua filiação com qualquer governo, e ser dispensado das obrigações impostas por esses governos, aceitando, em contrapartida, não receber nenhum suporte do governo com o qual foi feita a secessão.
        </p>
        
</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">

	<% Html.RenderPartial("RightMenu"); %>

</asp:Content>
