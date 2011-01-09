<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

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
        	Os problemas atuais em áreas como energia, poluição, saúde, cidades em
            decadência e pobreza não são solucionados, mas causados, pelo governo. O assistencialismo,
            supostamente desenvolvido para ajudar os pobres, é na verdade uma carga crescente e parasita
            carregada por todas as pessoas produtivas, e prejudica, ao invés de beneficiar, os pobres.
        </p>
        
        <h2><a name="Energia">1. Energia</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> O controle do governo sobre a indústria de entergia resultou
            em altos preços, apagões, falta de competição, falta de exploração e falta de
            desenvolvimento de fontes alternativas de energia, e responsabilidade deslocada por
            dano no mercado energético, além de dar vantagem no mercado existente àqueles com acesso político.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Defendemos a criação de um livre mercado de
            petróleo instituindo direito de propriedade sobre petróleo subterrâneo e condenamos
            todos os controles pelo governo sobre a saída na indústria de petróleo. Qualquer indústria
            de energia nuclear deve ser merecedora do teste do livre mercado. Completa responsabilidade – não
            agências do governo – devem regular a força nuclear. Nos opomos ao controle governamental
            sobre o preço da energia, alocação e produção. Nos opomos à criação de uma agência de mobilização
            na area de energia, que iria ser detentora de poderes ditatoriais para substituir os processos legais.
		</p>
        
        <p>
        	<strong>Soluções:</strong> Todos os recursos enérgicos possuídos pelo governo devem ser
            privatizados. Energia nuclear deve ser desnacionalizada e as posses na indústria transferidas
            para o setor privado. Nos opomos a todos os subsídios do governo para pesquisa, desenvolvimento
            e operação na área de energia. Nos opomos a todas as participações diretas e indiretas na indústria
            de energia nuclear, incluindo subsídios, pesquisa e fundos para desenvolvimento, empréstimos garantidos,
            subsídios para jogar o lixo, e agências federais de enriquecimento de urânio.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Defendemos o fim das agências regulatórias de energia,
            sem sua transferência para qualquer outro ponto no governo. Nos opomos a todos os esquemas
            de conservação do governo através do uso de impostos, subsídios ou regulação. Nos opomos ao
            sistema estratégico de armazenamento de petróleo, ou qualquer tentativa de forçar auto-suficiência
            em petróleo, qualquer extensão de leis de preferência de carga para importação e qualquer tentativa de
            aumentar impostos sobre petróleo ou a imposição de quotas de petróleo.
        </p>
        
        <h2><a name="Poluicao">2. Poluição</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Os problemas com o depósito de lixo tóxico foram criados pelas
            políticas do governo que separam responsabilidade de propriedade. Os princípios legais atuais,
            particulamente o conceito falso e injusto de ‘propriedade pública’, bloqueiam a privatização do
            uso do meio ambiente e por consequência bloqueiam soluções de controvérsias sobre o uso de recursos.
            Condenamos políticas de taxar todas as indústrias químicas da mesma forma independentemente de sua
            conduta. Tais impostos são subsídios para empresas irresponsáveis e despesas para as responsáveis.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Poluição da propriedade alheia é uma violação dos direitos individuais.
            Responsabilidades rígidas, não agências do governo e padrões abritários do governo, devem
            regular a poluição. Acusar que uma propriedade está abandonada não absolve da
            responsabilidade pelas ações desencadeadas.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Defendemos o desenvolvimento de um sistema legal objetivo definindo
            os direitos de propriedade para o ar e a água. Ao invés de obrigar os contribuíntes a
            pagar por limpezas de lixo tóxico, os donos de propriedade privada, ou, no caso, as empresas,
            os gerentes e empregados devem ser responsáveis pelo dano material feito por sua propriedade.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Demandamos modificações nas leis que governam os
            limites e moléstias feitos por ar, água, radiação, e poluição sonora. Nos opomos a propostas
            legislativas que isentam pessoas que acusam danos causados por radiação de provar que o dano
            foi causado por radiação. Demandamos o fim de agências regulatórias do meio ambiente. Também nos
            opomos ao controle do governo sobre areas fumante/não fumante em negócios privados.
        </p>
        
        <h2><a name="ProtecaoAoConsumidor">3. Proteção ao Consumidor</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Regulações de proteção ao consumidor pelo governo restringem a
            competição do livre mercado e substituem o direito de um indivíduo fazer escolhas
            independentes por padrões determinados pelo governo.
        </p>
        
        <p>
        	<strong>O princípio:</strong> A demanda dos consumidores, ao invés de leis, deve reger a
            proteção ao consumidor. Defendemos fortes e efetivas leis contra fraude e má representação.
            Contudo, nos opomos a regulações paternalistas, que se forçam aos consumidores, impõem preços,
            definem padrões para produtos, ou restringem a possibilidade de correr riscos e livre escolha.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Encorajamos ativismo por parte dos consumidores que boicotaria e
            sancionaria economicamente negócios que contrariamente afetam a saúde humana ou danificam
            o meio ambiente, passando custos ao público geral. Defendemos entidades independentes para
            certificação de produtos para o consumidor.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Fim da interferência governamental em assuntos do
            consumidor. Condenamos leis obrigando uso de equipamento de segurança como cinto de segurança
            ou capacete, que podem ser mais efetivamente induzidos através de ação dos consumidores no mercado.
        </p>
        
        <h2><a name="Educacao">4. Educação</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Escolas públicas levam à doutrinação das crianças ou interferem na
            livre escolha dos indivíduos. Leis de educação compulsória geram escolas com muitos
            problemas semelhantes a prisões.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Educação, como qualquer outro serviço, pode ser melhor executado
            pelo livre mercado, alcançando maior qualidade e eficiência com maior diversidade de escolha.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Defendemos a completa separação entre educação e estado.
            Posse, operação, regulação e subsídios pelo governo de escolas, colégios e universidade
            devem cessar. Condenamos as garantias da educação pública, que são encontradas na maioria das constituições.
            Condenamos as leis de educação compulsória. Até que o envolvimento do governo na educação acabe,
            apoiamos a eliminação, dentro do sistema de educação público, de transporte forçado e punição corpórea.
            Também apoiamos a redução imediata de ajuda fiscal para escolas, e a remoção de taxas para educação
            sobre aqueles que não são responsáveis pela educação de crianças.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Como medida interina para incentivar o aumento de escolas privadas
            e variedade na educação, incluindo educação em casa, defendemos crédito em impostos para tutela e outras
            despesas relacionadas à educação de um indivíduo. Também apoiamos crédito em impostos para creches e nos
            opomos à nacionalização da indústria de creches. Nos opomos à negação ao status de isento de impostos a escolas
            devido às políticas privadas da escola para contratações, admissões e ao comportamento dos estudantes.
            Defendemos o fim de todos os impostos no rendimento de escolas privadas, tanto com ou sem fim lucrativos.
        </p>
        
        <h2><a name="Populacao">5. População</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Observamos que as tragédias causadas por gestações não desejadas
            são agravadas, se não criadas, por políticas governamentais de censura, restrição e proibição.
        </p>
        
        <p>
        	<strong>O princípio:</strong> O povo brasileiro não é um recurso nacional colecionável.
            Nos opomos a quaisquer medidas coercivas para controle populacional.
        </p>
        
        
        <p>
        	<strong>Soluções:</strong> Nos opomos a ações governamentais que compelem ou proíbem aborto,
            esterilização, ou quaisquer outras formas de controle de natalidade. Especificamente, condenamos
            a prática de esterilização forçada de miseráveis, deficientes mentais ou
            indivíduos “geneticamente defeituosos”. Condenamos todas as leis que restringem qualquer um, incluindo
            crianças, de participar em trocas voluntárias de mercadorias, serviços ou informação relacionada
            à sexualidade humana, reprodução, controle de natalidade ou tecnologias médicas ou biológicas
            relacionadas ao assunto. Também nos opomos a leis governamentais e políticas que restrinjam a
            oportunidade de escolher alternativas para o aborto.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Defendemos o fim de todos os subsídios para etapas
            da gestação presentes atualmente, incluindo planos de pensão e provisão de serviços
            para crianças através de dinheiro público.
        </p>
        
        <h2><a name="Transporte">6. Transporte</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> A interferência do governo no transporte é caracterizada
            por restrição monopolística, corrupção e ineficiência.
        </p>
        
        <p>
        	<strong>O princípio:</strong> A indústria de transportes não deve ser tratada
            diferentemente de qualquer indústria, e deve ser governada por mercados livres e
            mantida por responsabilidade judicial rigorosa.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Defendemos a dissolução de todas as agências governamentais
            relativas ao transporte, e transferir suas funções a entidades privadas competitivas.
            Defendemos a privatização de aeroportos, ferrovias, sistemas de controle de tráfego e estradas públicas.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Como medidas interinas, defendemos um fim imediato
            à regulação governamental de organizações relativas ao trânsito e fim de favores governamentais
            à indústria de automobilística. Em particular, defendemos o fim de todas as leis restringindo
            a competição da área automobilística tais como monopólios de taxi e ônibus e a proibição de
            serviços de micro-ônibus. Defendemos a desregulação imediata da indústria de caminhões.
        </p>
        
        <h2><a name="PobrezaEDesemprego">7. Pobreza e desemprego</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Ações fiscais e monetárias do governo que estimulam artificialmente a
            expansão dos negócios garantem um eventual aumento no desemprego ao invés de reduzi-lo.
            Programas do governo são ineficientes, paternais, humilhantes e invasivos na privacidade.
        </p>
        
        <p>
        	<strong>O princípio:</strong> A forma adequada de ajuda para os pobres é através de
            esforços voluntários de grupos privados e indivíduos. Nenhum trabalhador deve ser
            legalmente penalizado pela falta de certificação, e nenhum consumidor deve ser legalmente
            restrito de contratar indivíduos não-licensiados.
        </p>
        
        <p>
            <strong>Soluções:</strong> Buscamos a eliminação da autorização ocupacional, que impede
            seres humanos de trabalharem no que quiserem. Buscamos a abolição de todas as agências governamentais
            federais, estaduais e locais que restringem a entrada em qualquer profissão, como educação ou
            advocacia, ou regulam sua prática. Nos opomos a todo auxílio-desemprego, projetos
            de esmola e programas de ‘ajuda aos pobres’.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Buscamos a trégua imediata de tais políticas
            fiscais e monetárias, assim como qualquer tentativa do governo que afete os níveis de
            desemprego. Condenamos todas as leis que impedem um indivíduo a encontrar um emprego,
            como salário mínimo, a chamada legislação “protetiva” para mulheres e crianças, restrições
            governamentais no estabelecimento de creches, e a CLT. Condenamos o incentivo governamental
            para aposentadoria forçada. Para acelerar o momento em que os programas governamentais são
            substituídos por instituições privadas defendemos créditos em impostos por todas
            suas contribuições para a caridade.
        </p>
        
        <h2><a name="Saude">8. Saúde</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Nas recentes décadas testemunhamos o crescimento do envolvimento
            do governo com o sistema de saúde. Tal envolvimento conduziu a uma administração burocrática vertical,
            rapidamente escalando preços, regulações custosas,  a criminalização da prática de medicina
            por aqueles que não possuem diploma e uma série de outros problemas. Nenhum desses problemas
            prevalecia antes de o governo aumentar seu envolvimento. Acreditamos que o envolvimento do governo
            é a principal causa de muitos dos problemas que enfrentamos no sistema de saúde hoje em dia.
            O alto custo da seguridade de saúde é em parte culpa do excesso de
            regulação governamental na atividade.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Reconhecemos o direito dos indivíduos, livres da intervenção do
            governo e seus danosos efeitos colaterais, de determinar o nível de seguridade que querem, o nível
            de saúde que querem, os provedores de saúde que querem, os remédios e tratamentos que querem usar
            e todos os outros aspectos da saúde. O papel do governo em qualquer tipo de seguridade deve ser
            apenas o de fazer valer contratos quando necessário, não o de ditar às seguradoras e consumidores
            quais tipos de contrato eles devem acordar voluntariamente
        </p>
        
        <p>
        	<strong>Soluções:</strong> Restaurar e reviver um mercado livre na área de saúde.
            Defendemos uma completa separação de medicina do estado. Defendemos o fim da saúde provida
            pelo governo. Defendemos que todas as funções relativas à saúde podem ser mais
            efetivamente providas pelo setor privado.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Nos opomos a qualquer restrição ou financiamento
            pelo governo de qualquer pesquisa médica ou científica.
        </p>
        
        <h2><a name="UsoDosRecursos">9. Uso dos recursos</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> Nos opomos ao controle pelo governo do uso dos recursos através
            de despropriação, leis de zona, códigos de construção, controle de aluguel, planos regionais,
            renovação urbana, ou compra de direitos de desenvolvimento com dinheiro público. Tais regulações
            e programas violam o direito de propriedade, discriminam minorias, criam falta de moradia,
            e tendem a inflacionar os aluguéis. Todas as restrições governamentais sobre o uso privado
            ou transferência voluntária de direitos de água ou controles despóticos similares podem
            apenas agravar a má distribuição de água. 
        </p>
        
        <p>
        	<strong>O princípio:</strong> O uso dos recursos é responsabilidade e direito dos donos
            legítimos da terra, água e outros recursos naturais. Reconhecemos a legitmidade de planejamento
            de recursos para fins de contratos privados voluntários.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Defendemos o estabelecimento de um sistema privado eficiente e
            justo de direitos sobre água aplicado tanto para água na superfície quanto para água no subsolo.
            Tal sistema deve ser construído através da doutrina do primeiro que declarar/usar. A alocação de
            água deve ser  governada pela competição irrestrita e preços não regulados. Também defendemos a
            privatização dos sistemas de água. Apenas a completa separação da água do Estado pode previnir crises
            de falta de água no futuro. Defendemos seção ao vizinho ou outro para transferir para propriedade privada as terras federais.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong>  A construção pelo governo de cisternas e outros projetos de água
            deve cessar e projetos de água do governo existentes devem ser transferidos para a propriedade privada.
            Nós apoiamos a abolição das funções civis da Companhia de Desenvolvimento dos Vales do São Francisco e
            do Parnaíba  (CODEVASF) e das companhias elétricas  Nós também apoiamos a abolição de todos os distritos
            locais de água e seu poder para taxar . Nos opomos a qualquer uso de ordens executivas invocando
            Patrimônio Histórico  para reservar terras públicas. Nós pedimos pela abolição doInstituto Brasileiro
            do Meio Ambiente e dos Recursos Naturais Renováveis. Nos opomos à criação de novos parques, selvas e áreas
            de recreação covernamentais. Tais parques e áreas já existentes devem ser transferidos à propriedade
            não governamental. Pendentes tais transferências, sua operação deve ser custeada pelos seus usuários
            em vez dos pagadores de impostos.
        </p>
        
        <h2><a name="Agricultura">10. Agricultura</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> O mercado livre da agricultura, sistema que alimenta grande parte
            do mundo, foi arado por intervenções do governo. Subsídios, regulações e taxas encorajaram a
            centralização do agro negócio. As políticas de exportação do governo fazem com que os fazendeiros
            sejam reféns dos caprichos das administrações públicas.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Tanto fazendeiros quanto consumidores devem ser livres das
            intromissões e medidas contra-produtivas do governo federal – livres para plantar, vender ou comprar o
            que quiserem, na quantidade que quiserem, quando quiserem.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Fazendeiros e outros fornecedores de produtos e serviços no mercado livre
            da agricultura devem operar desimpedidos por qualquer regulação governamental, enquanto são policiadas
            pelas agências de proteção ao consumidor do setor privado com relação à qualidade, e creditadas pelo
            governo apenas contra fraude e enganação.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Os problemas da agricultura atuais não são insolúveis.
            As políticas do governo podem ser reversas. Alguns passos podem ser tomados imediatamente:
        </p>
        
        <p>
        	a) abolição do departamento de agricultura; 
        </p>
        
        <p>
        	b) eliminação de todos os programas de governo para fazendas, incluindo suporte de preços,
            subsídios diretos e toda e qualquer regulação na produção agrícola;
        </p>
        
        <p>
        	c) desregulação da indústria de transporte 
        </p>
        
        <p>
        	d) fim do envolvimento do governo no controle de pestes na agricultura. Uma política de
            controle de pestes onde os próprios indivíduos ou corporações tomem completa responsabilidade
            por danos inflingidos em seus vizinhos deve ser implementado.
        </p>
        
        <h2><a name="LeisTrabalhistasCLTs">11. Leis Trabalhistas (CLTs)</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>O Assunto:</strong> As ações arbitrárias da Justiça do Trabalho invadem os direitos à propriedade,
            elevam preços, geram desemprego e se impõem injustamente sobre a comunidade de negócios. Acabam por
            transformar empregadores em criminosos e empregados em vítimas, prejudicando a economia.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Essas leis negam o direito à liberdade e propriedade tanto ao
            empregado quanto ao empregador, e interfere em sua relação contratual privada. Uma sociedade
            de livre-comercio é baseada em trocas voluntárias e uma troca voluntária só acontece quando ambas
            as partes enxergam vantagens. Somos contra qualquer ação coercitiva por parte do governo que tire
            o livre arbítrio dos indivíduos e decida por eles oque é ou não vantajoso.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Relações trabalhistas são trocas voluntárias entre empregado e
            empregador e cabe apenas às partes envolvidas a resolução dos termos contratuais. Grupos ativistas
            de consumidores do setor privado devem ser criados para substituir agências governamentais ineficientes.
        </p>
        
        <p>
        	<strong>Ação transitória:</strong> Nós demandamos a abolição de todas as leis trabalhistas.
        </p>
        
        <h2><a name="PrevidenciaSocial">12. Previdência Social</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> O sistema previdenciário é um falido e imoral esquema piramidal
            com valores absurdos de endividamento e possui uma taxa de retorno abaixo na
            média para seus participantes.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Numa sociedade livre, o plano de aposentadoria é
            responsabilidade do indivíduo e não do governo.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Defendoemos a substituição da atual previdência pública, fraudulenta,
            falida e patrocinada pelo governo, por sistemas privados voluntários.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Pendendo essa substituição, a participação
            na previdência social deve ser voluntária. 
        </p>
        
        <h2><a name="LeisEleitorais">13. Leis Eleitorais</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> O sistema eleitoral é muito importante. Muitas constituições estabeleceram
            distritos distorcidos e leis proibitivas de restrição que efetivamente excluem candidatos alternativos
            e grupos de candidaturas que são seu direito. Tais leis erroneamente negam candidatura a candidatos e
            grupos politicos, assim negando a seus eleitores o direito a considerar todas as alternativas legítimas.
            Muitas leis permitem governos federais e estaduais controlar a eleição de seus próprios administradores
            e beneficiários, assim reduzindo a responsabilidade dos cidadãos.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Eleições em todos os níveis devem estar sob o controle daqueles que
            querem participar ou ajudar voluntariamente. Como grupos voluntários privados, grupos politicos devem ser
            permitidos a estabelecer suas próprias regras para procedimentos de nomeclatura, eleições preliminares
            e convenções. Nenhum estado tem interesse em proteger essa área exceto para garantir uma condução
            justa e eficiente das eleições.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Propomos sistemas eleitorais que são mais representativos do eleitorado
            no âmbito federal, estadual e local. Não deve haver restrição federal ou estadual para candidatura.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Fim do controle governamental dos partidos politicos,
            permitindo liberdade de criação, associação e expressão. Reprimimos ações que suprimam apoio voluntário
            a candidatos e grupos. Eleições preliminaries devem ser feitas em uma convenção do partido político e não
            ser um evento público subsidiado. Permitir sempre a anulação do voto. Em uma eventual maioria de votos nulos
            em qualquer eleição, ou o cargo deve permanecer não preenchido e não utilizar de verbas, ou deve haver
            uma nova eleição na qual nenhum dos candidatos derrotados deve ser elegível. Visando garantir aos eleitores
            alternativas diversas nas eleições federais, estaduais e locais, propomos um sistema eleitoral distrital para
            eleições legislativas. Defendemos o fim do fundo partidário.
        </p>
        
        <h2><a name="Secessao">14. Secessão</a></h2>
        
        <p class="top"><a href="#Topo">Ir para o topo</a></p>
        
        <p>
        	<strong>A questão:</strong> As pessoas são forçadas a se subordinar aos governos e participar de seus
            programas, geralmente como provedores de financiamento, independentemente de sua vontade ser contrária ou não.
        </p>
        
        <p>
        	<strong>O princípio:</strong> Como toda associação política deve ser voluntária, reconhecemos o direito
            de secessão política. Isso inclui o direito de secessão por entidades políticas, grupos privados ou indivíduos.
            O exercício desse direito, assim como o exercício de todos os outros direitos, não anula obrigações legais e morais,
            para não violar o direito de outros.
        </p>
        
        <p>
        	<strong>Soluções:</strong> Defendemos o direito de entidades políticas, grupos privados e indivíduos
            a renunciar sua filiação com qualquer governo, e ser dispensado das obrigações impostas por esses governos,
            enquanto em contrapartida aceitando nenhum suporte do governo com o qual foi feita a secessão.
        </p>
        
        <p>
        	<strong>Ações transitórias:</strong> Como passo na transação, defendemos o direito de entidades
            políticas, grupos privados e indivíduos a renunciar sua participação em qualquer programa governamental,
            e a ser dispensado das obrigações impostas por esse programa, enquanto em contrapartida aceitando
            nenhum benefício do programa com o qual foi feita a secessão.
        </p>
	</div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">

	<% Html.RenderPartial("RightMenu"); %>

</asp:Content>
