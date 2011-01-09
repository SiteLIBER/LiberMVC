<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel" id="post">
        <h1>Direitos Individuais</h1>

        <div id="index">
            <h1>Índice</h1>

            <ol>
			    <li><a href="#LiberdadeEResponsabilidade">Liberdade e responsabilidade</a></li>
			    <li><a href="#Crime">Crime</a></li>
			    <li><a href="#CrimesSemVitima">Crimes sem vítima</a></li>
			    <li><a href="#GuerraContraAsDrogas">Guerra contra as drogas</a></li>
                <li><a href="#ProtecaoAosAcusadosCriminalmente">Proteção aos acusados criminalmente</a></li>
                <li><a href="#JusticaParaOIndividuo">Justiça para o indivíduo</a></li>
                <li><a href="#Juris">Júris</a></li>
                <li><a href="#SoberaniaIndividual">Soberania Individual</a></li>
                <li><a href="#GovernoESaudeMental">Governo e Saúde Mental</a></li>
                <li><a href="#LiberdadeDeComunicacao">Liberdade de comunicação</a></li>
                <li><a href="#LiberdadeDeReligiao">Liberdade de Religião</a></li>
                <li><a href="#ODireitoDePropriedade">O Direito de Propriedade</a></li>
                <li><a href="#ODireitoDePrivacidade">O Direito de Privacidade</a></li>
                <li><a href="#ODireitoDePossuirEPortarArmas">O Direito de possuir e portar armas</a></li>
                <li><a href="#AlistamentoEAsForcasArmadas">Alistamento e as Forças Armadas</a></li>
                <li><a href="#Imigracao">Imigração</a></li>
                <li><a href="#DireitosDasMulheresEAborto">Direitos das Mulheres e Aborto</a></li>
                <li><a href="#FamiliasECriancas">Famílias e Crianças</a></li>
                <li><a href="#DireitosSexuais">Direitos sexuais</a></li>
                <li><a href="#DireitosDosIndios">Direitos dos Índios</a></li>
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
            Não existe conflito entre a ordem pública e os direitos individuais.
            Ambos os conceitos são baseados no mesmo princípio fundamental:
            que nenhum indivíduo, grupo ou governo pode iniciar força contra
            qualquer outro indivíduo, grupo ou governo.
        </p>

        <h2><a name="LiberdadeEResponsabilidade">1. Liberdade e responsabilidade</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>questão:</strong> A responsabilidade pessoal é desencorajada pelo governo
            quando nega aos indivíduos a oportunidade de exercê-la. De fato,
            a negação da liberdade promove a irresponsabilidade.
        </p>

        <p>
            <strong>princípio:</strong> Os indivíduos devem ser livres para fazerem suas próprias escolhas,
            e devem aceitar a responsabilidade pelas consequências.
            Nós devemos aceitar o direito dos outros de escolherem por si próprios se
            quisermos ter o mesmo direito. Nossa defesa de tal direito não significa
            que necessariamente aprovemos ou desaprovemos essas escolhas. Acreditamos
            que as pessoas devem aceitar a responsabilidade individual pelas conseqüências de suas ações.
        </p>

        <p>
            <strong>Soluções:</strong> Políticas libertárias promoverão uma sociedade onde as pessoas serão
            livres para fazer suas próprias decisões e aprender com elas.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Revogação de todas as leis que presumem que o Governo sabe
            melhor que o indivíduo como viver sua própria vida. Encorajar a disseminação de
            informações pelo setor privado para ajudar os consumidores fazerem decisões informadas
            sobre produtos e serviços. Aplicação de leis contra fraude e falsificação.
        </p>

        <h2><a name="Crime">2. Crime</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> O alto índice de crimes violentos - e a inabilidade demonstrada
            pelo Governo de lidar com o problema - ameaça a vida, felicidade e
            pertences dos brasileiros. Ao mesmo tempo, violações dos direitos por
            parte do Governo debilitam o senso de justiça das pessoas em relação ao crime.
            Leis sobre crimes sem vítimas violam os direitos individuais e também aumentam
            as incidências de crimes propriamente ditos.
        </p>

        <p>
            <strong>princípio:</strong> A única função justificada do Governo é proteger as vidas,
            direitos e propriedade dos cidadãos.
        </p>

        <p>
            <strong>Soluções:</strong> O modo apropriado para reprimir o crime é através da aplicação constante
            e imparcial de leis que protegem os direitos individuais.
            Apoiamos serviços privados de proteção e grupos comunitários
            e voluntários de combate ao crime.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Queremos o fim de leis de "crimes de ódio",
            que punem pessoas pelos seus pensamentos e discursos, distraem-nos dos crimes reais,
            e promovem ressentimento, dando a alguns indivíduos status especial sob a lei.
            Leis sobre crimes sem vítimas devem ser revogadas. Apoiamos mudanças
            institucionais, consistentes com o respeito total aos direitos do acusado,
            as quais permitiriam vítimas a iniciar ações judiciais em caso de lesão ou ofensa.
        </p>

        <h2><a name="CrimesSemVitima">3. Crimes sem vítima</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> Atividades que afetam apenas o autor e mais ninguém tem sido
            criminalizadas pelo governo por meio da codificação na lei de uma moralidade particular.
        </p>

        <p>
            <strong>O princípio:</strong> Somente ações que infringem direitos ou danificam
            a propriedade de outros podem ser tratadas como crimes.
        </p>

        <p>
            <strong>Soluções:</strong> Somos a favor da revogação de todas as leis federais,
            estaduais e locais que criam "crimes" sem vítimas.
        </p>

        <p>
            <strong>Ações transitórias:</strong> em particular, apoiamos:
        </p>

        <p>
            a) Revogação de todas as leis que proíbam a produção, venda, posse,
            ou uso de drogas, e de todas as requisições de prescrição médica para a
            compra de vitaminas, drogas, e substâncias similares;
            a revogação de todas as leis restringindo ou proibindo o
            uso ou venda de álcool, requerendo sinais e tarjas de avisos sobre saúde,
            fazendo garçons ou anfitriões responsáveis pelo comportamento de clientes e convidados,
            fazendo empresas de bebidas alcoólicas responsáveis por doenças e
            deficiências de recém-nascidos, e fazendo casas de jogos responsáveis pelas
            perdas de jogadores intoxicados; a revogação de todas as leis ou políticas
            autorizando a parada de motoristas sem causa provável para o
            teste de álcool ou uso de drogas; a revogação de todas as leis
            com respeito a relações sexuais em consenso, incluindo prostituição e lenocínio,
            e o fim da opressão estatal de homossexuais homens e mulheres, e que eles
            tenham respeitados todos seus direitos como indivíduos; a revogação
            de todas as leis regulando ou proibindo a posse, uso, venda, produção,
            ou distribuição de material de sexo explícito, independente de seu "valor social"
            ou conformidade com os "padrões da comunidade";
        </p>

        <p>
            b) Revogação de todas as leis regulando ou proibindo o jogo;
        </p>

        <p>
            c) Revogação de todos os estatutos que criminalizam pessoas ou empresas que trabalham com
            jogos de azar ou comércio de material explícito, o que se iguala a
            punir comportamento pacífico - incluindo também o comércio restrito
            ações restrito a membros, a venda de material de sexo explícito e
            protestos não-violentos antiaborto - congelando e/ou confiscando
            bens dos acusados ou condenados; e
        </p>

        <p>
            d) Revogação de todas as leis interferindo no direito de cometer suicídio,
            infringindo o direito de um indivíduo sobre sua própria vida.
            Exigimos remissão de pena para os atualmente encarcerados ou condenados por
            esses "crimes". Condenamos o confisco de propriedade antes de condenação
            pelo estado que tão freqüentemente também acompanha batidas policiais,
            buscas e ações judiciais para crimes sem vítima. Ademais, reconhecemos que,
            freqüentemente, o Governo Federal chantageia os estados que se recusam a
            cooperar com essas leis, não liberando verbas. Damos total apoio aos
            estados que se recusam a ser coagidos.
        </p>

        <h2><a name="GuerraContraAsDrogas">4. Guerra contra as drogas</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> O sofrimento que o abuso de certas drogas traz é deplorável;
            entretanto, a proibição de drogas causa mais danos que as próprias drogas.
            A chamada "guerra contra as drogas" é na realidade uma guerra contra o povo brasileiro.
            A guerra contra as drogas é uma grave ameaça à liberdade individual,
            à ordem pública, e à paz mundial.
        </p>

        <p>
            <strong>O princípio:</strong> Os indivíduos devem ter o direito de usar drogas,
            seja por propósito medicinal ou recreativo, sem medo de represália legal,
            e devem ser legalmente responsáveis pelas conseqüências de suas ações
            se elas violarem os direitos de outros.
        </p>

        <p>
            <strong>Soluções:</strong> O envolvimento social dos indivíduos é essencial para resolver
            o problema de mau uso e abuso das substâncias. Educação popular e grupos
            de assistência são abordagens melhores que a proibição, e apoiamos as atividades
            de organizações privadas como a melhor forma de avançar na questão.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Revogação de todas as leis estabelecendo penalidades
            civis e criminais pelo uso de drogas. Acabar com as medidas de "prevenção ao crime"
            tais como traçar perfis psicológicos ou confisco de bens. Não processar meros
            usuários de drogas e perdoar aqueles já condenados.
        </p>

        <h2><a name="ProtecaoAosAcusadosCriminalmente">5. Proteção aos acusados criminalmente</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> Políticas de punição instantânea retiram dos acusados importantes
            defesas contra abuso de poder governamental - júris e o processo judicial.
        </p>

        <p>
            <strong>O princípio:</strong> Até que as pessoas sejam provadas culpadas, todos seus direitos
            individuais devem ser respeitados. Somos contrários a qualquer concepção
            de que alguns indivíduos são por natureza cidadãos de segunda-classe
            que somente entendem punição instantânea, e qualquer alegação que a polícia
            possui um insight especial em reconhecer pessoas que precisam de punição.
            Opomos-nos à redução de salvaguardas constitucionais
            nos direitos dos acusados criminalmente.
        </p>

        <p>
            <strong>Soluções:</strong> As ações não devem mais ser tratadas como "civis", estritamente
            para evitar o processo de proteções da lei criminal. O Governo não deve mais
            ter permissão de confiscar propriedades antes dos procedimentos civis ou
            criminais adequados. Restituição total para todas as perdas sofridas por
            pessoas presas, indiciadas, julgadas, detidas ou de qualquer outra forma
            prejudicadas no curso dos procedimentos criminais contra elas, que não
            resultem em sua condenação. Quando forem considerados responsáveis, policiais e
            outros agentes do governo devem arcar com o custo dessa restituição.
        </p>

        <p>
            <strong>Ações transitórias:</strong> A polícia deve ser proibida de usar força excessiva sobre o
            desordeiro ou acusado criminalmente, lançando mão do que eles consideram
            ser punição instantânea nas ruas, ou usar de prisão preventiva.
            O sistema judicial deve ser reformado para permitir que réus em processos
            criminais e ambas as partes em processos civis possam apresentar um
            número razoável de recursos aos juízes, similares aos recursos
            possíveis de serem apresentados a um júri.
        </p>

        <h2><a name="JusticaParaOIndividuo">6. Justiça para o indivíduo</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> O sistema atual de leis criminais é baseado quase
            somente na punição e com pouco enfoque na vítima.
        </p>

        <p>
            <strong>O princípio:</strong> O propósito de um sistema de justiça é prover a
            restituição a quem sofreu a perda à custa daqueles que causaram a perda.
            Nos casos de crimes violentos, um propósito adicional é defender a
            sociedade da ameaça contínua da violência.
        </p>

        <p>
            <strong>Soluções:</strong> Apoiamos:
        </p>

        <p>
            a) a maior restituição possível para a vítima à custa do criminoso ou malfeitor.
        </p>

        <p>
            b) o fim do processo criminal de indivíduos por exercer seu direito de defesa pessoal; e
        </p>

        <p>
            c) afirmar o direito da vítima de perdoar o criminoso ou malfeitor, impedindo,
            contudo, ameaças à vítima para esse propósito.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Término de todas as leis de "culpa exclusiva"
            do segurado, que retiram da vítima o direito de ser ressarcidos pelos responsáveis
            em caso de lesão. Garantir o direito da vítima de perdoar o criminoso ou malfeitor,
            impedindo, contudo, ameaças à vítima para esse propósito.
            Mudar as leis anti-estupro para que a convivência não seja mais
            considerada uma defesa contra uma acusação de estupro.
        </p>

        <h2><a name="Juris">7. Júris</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> O direito de ser julgado por um júri popular é uma restrição
            importante para que nossos direitos não sejam infringidos pelo Governo.
            Práticas atuais têm desgastado enormemente essa proteção.
        </p>

        <p>
            <strong>O Princípio:</strong> Júris populares devem ser compostos de voluntários,
            não de jurados forçados. Ademais, o direito dos jurados de julgar
            não apenas conforme os fatos, mas de julgar a própria lei deve ser
            reconhecido e encorajado.
        </p>

        <p>
            <strong>Soluções:</strong> Em todos os casos no qual o Estado é parte, o juiz deve ser obrigado a informar
            os jurados de sua prerrogativa de julgar a lei, assim como os fatos, e de absolver
            um réu em processo criminal ou julgar em desfavor do Estado em processos cíveis,
            sempre que considerarem a lei injusta ou opressiva.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Acabar com a prática de excluir jurados contrários
            à pena de morte do julgamento de tais casos, o que nega ao réu o direito de
            ser julgado por um júri que represente verdadeiramente os valores da comunidade.
        </p>

        <h2><a name="SoberaniaIndividual">8. Soberania Individual</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> O Governo tem se colocado em uma posição de superioridade
            perante seus cidadãos, negando seus direitos sob o argumento do
            "interesse nacional" (tornando-se assim a principal ameaça aos nossos direitos, em vez de seu principal protetor),
            e tem negado aos seus cidadãos o direito de processar
            o Governo para reparação de danos causados,
            tomando para si uma posição de imunidade.
        </p>

        <p>
            <strong>Princípio:</strong> A única situação de uso legítimo de força é na defesa dos
            direitos individuais - vida, liberdade, e a propriedade
            legalmente adquirida - contra agressão, seja por força ou por fraude.
            Esse direito é inerente ao indivíduo, o qual - com seu
            consentimento - pode ser ajudado por qualquer outro indivíduo ou grupo.
            O direito a se defender se estende à defesa contra atos
            agressivos do próprio Governo.
        </p>

        <p>
            <strong>Soluções:</strong> O Governo deve se ater ao seu papel de protetor de direitos,
            e voltar a ser novamente responsável por suas ações contra cidadãos individualmente.
            Governantes eleitos e burocratas devem ser igualmente responsáveis por tais ações.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Nós defendemos o fim imediato das imunidades inerentes aos
            poderes do Estado, que ignoram a primazia do indivíduo sobre a abstração do Estado,
            e que sustenta que este, contrário à tradição de ressarcimento pelos danos, não possa
            ser processado sem sua própria permissão ou ser responsabilizado por
            suas próprias ações, conforme a lei civil.
        </p>

        <h2><a name="GovernoESaudeMental">9. Governo e Saúde Mental</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> Indivíduos são medicados à força ou tem sua medicação negada,
            baseado não na necessidade médica, mas em um
            programa social imposto pelo Governo.
        </p>

        <p>
            <strong>O Princípio:</strong> O uso ou abstenção de medicação deve ser voluntária.
        </p>

        <p>
            <strong>Soluções:</strong> Nos opomos ao tratamento forçado de qualquer pessoa ou internação
            em instituição de tratamento mental. Condenamos veementemente que
            um paciente seja obrigado a aceitar tratamento ou enfrente internação
            numa instituição de tratamento mental onde ele será tratado contra sua vontade.
            Somos contra qualquer pressão por parte do Governo, aconselhando pais para
            que administrem remédios para seus filhos. Também somos contra o tratamento
            forçado dos idosos, das pessoas com lesões na cabeça ou daqueles com capacidade reduzida.
            Somos contra a invasão do lar e da privacidade das pessoas por
            agentes de saúde ou quaisquer outros agentes do governo para
            requerer ou negar medicação.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Defendemos o fim do gasto de dinheiro dos contribuintes
            para qualquer programa de tratamento psiquiátrico, psicológico ou de pesquisa de
            comportamento. Desejamos o fim das defesas criminais baseadas em "insanidade temporária"
            ou "capacidade reduzida", o que tira do culpado sua responsabilidade.
        </p>

        <h2><a name="LiberdadeDeComunicacao">10. Liberdade de comunicação</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> Somos contra qualquer cerceamento da liberdade de
            expressão por meio da censura, regulação ou controle das mídias de
            comunicação, incluindo, mas não se limitando a leis que regulam:
        </p>

        <p>
            a) Obscenidade, incluindo a "pornografia", que entendemos como cerceamento
            da liberdade de expressão, a despeito de das opiniões de que
            isso instigaria o estupro, ou que rebaixaria e difamaria as mulheres;
        </p>

        <p>
            b) Equipamentos de recepção e armazenamento, tais como gravadores de fita digitais
            e dispositivos de radar, e a fabricação de terminais de vídeo
            por companhias telefônicas;
        </p>

        <p>
            c) Quadros de avisos eletrônicos, redes de comunicação, e outras midas interativas,
            pois as entendemos como sendo os equivalentes eletrônicos dos salões de
            convenções e mídias impressas na era das comunicações eletrônicas, e como tais,
            merecendo total liberdade;
        </p>

        <p>
            d) Jornais eletrônicos, "páginas amarelas" eletrônicas, arquivos de bibliotecas,
            sites da Internet e qualquer outra nova mídia de informação,
            que merecem total liberdade; ou
        </p>

        <p>
            e) Comunicação ou propaganda comercial. Somos contra qualquer tipo de restrição
            da linguagem em todas as escolas que recebam verbas públicas. Linguagem que for
            considerada ofensiva a certos grupos não deve ser causa para ação legal.
        </p>

        <p>
            Somos veementemente contra a prática do Governo de invadir salas de notícias
            eletrônicas ou locais de terceiros não envolvidos, em nome da lei.
            Somos contra as ordens judiciais que limitam a cobertura jornalística dos
            procedimentos criminais - o direito de publicar e transmitir não deve ser
            cerceado meramente pela conveniência do sistema judicial. Deploramos quaisquer
            esforços no sentido de impor controle de opiniões à mídia,
            seja pelo uso de leis antitruste, seja por qualquer outra ação governamental
            que vise eliminar o "preconceito" da mídia.
        </p>

        <p>
            <strong>O Princípio:</strong> Defendemos os direitos individuais à liberdade irrestrita de expressão,
            liberdade de imprensa e o direito dos indivíduos de discordar do próprio Governo.
            Reconhecemos que a liberdade total de expressão é possível apenas como parte de um
            sistema de direitos totais de propriedade. A liberdade de usar sua própria voz;
            a liberdade; a liberdade de alugar um salão de convenções;
            a liberdade de ser proprietário de um jornal ou de uma estação de televisão
            aberto ou cabo de transmissão; a liberdade de hospedar e publicar informação
            na Internet; a liberdade de agitar ou de queimar sua própria bandeira;
            e liberdades similares baseadas na propriedade são precisamente o que constitui a
            liberdade de comunicação. Ao mesmo tempo, reconhecemos que a liberdade de
            comunicação não se estende ao uso de propriedades de outrem para promover
            idéias sem o consentimento de seus respectivos donos.
        </p>

        <p>
            <strong>Soluções:</strong> Devemos deixar ao critério do livre-mercado a propriedade de freqüências de ondas.
            Somos contra a posse estatal, subsídio ou financiamento público de qualquer
            organização de comunicação. A remoção de todos esses regulamentos e práticas
            de toda a mídia de comunicação abriria o caminho para a diversidade e inovação.
            Não ficaremos satisfeitos até que tenhamos proteção total e incondicional da comunicação.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Propomos a extinção de agências reguladoras de comunicação, tais como a Anatel.
        </p>

        <h2><a name="LiberdadeDeReligiao">11. Liberdade de Religião</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> O Governo rotineiramente invade os direitos de privacidade pessoal
            baseado somente nas crenças religiosas dos indivíduos.
            Impostos arbitrários são projetados para ajudar certas religiões
            e negar essa mesma ajuda a outras.
        </p>

        <p>
            <strong>O Princípio:</strong> Defendemos o direito dos indivíduos de participar
            (ou se abster de participar) de qualquer atividade religiosa
            que não viole os direitos de outras pessoas.
        </p>

        <p>
             <strong>A Solução:</strong> Para defender a liberdade, advogamos uma perfeita separação entre Igreja e Estado.
             Somos contra quaisquer ações do Governo que favoreçam ou prejudiquem qualquer
             religião. Repelimos a taxação das propriedades da Igreja da mesma forma
             que nos opomos a qualquer taxação de propriedades. Condenamos as
             tentativas dos pais ou de quaisquer outros - via seqüestros
             ou internatos - de forçar crianças a adotar qualquer visão religiosa.
             Perseguição governamental ou proibição de grupos religiosos
             pelas suas crenças ou atividades não violentas deve acabar.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Desejamos o fim da perseguição, negando a concessão
            de benefícios tributários para aquelas igrejas que não disponibilizarem
            toda a informação exigida pelo Governo.
        </p>

        <h2><a name="ODireitoDePropriedade">12. O Direito de Propriedade</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> Somos veementemente contra todas as violações ao direito de propriedade,
            liberdade de contratar, e livre comércio, especialmente aquelas violações
            perpetradas em nome da segurança nacional. Também condenamos os esforços do
            Governo para regular ou banir o uso da propriedade em nome de valores estéticos,
            risco, padrões morais, estimativas de custo-benefício, promoção ou restrição de
            crescimento econômico. Condenamos especialmente toda interferência governamental
            na operação de negócios privados, tais como restaurantes e linhas aéreas,
            seja designando ou proibindo áreas para fumantes e não-fumantes para seus
            empregados ou clientes. A taxação de imóveis privados, na prática, torna o
            Estado possuidor de todas as terras, forçando os indivíduos a pagar pelo
            uso de suas próprias casas e pontos comerciais.
        </p>

        <p>
            <strong>O Princípio:</strong> Não há conflito entre o direito de propriedade e os direitos individuais.
            Com efeito, os direitos de propriedade são os direitos dos humanos em relação à propriedade,
            e como tais, devem receber a mesmo respeito e proteção como todos os
            outros direitos humanos. Todos os direitos são intrinsecamente ligados ao
            direito de propriedade. Tais direitos como a liberdade de não servir a
            alguém involuntariamente bem como a liberdade de expressão e liberdade de
            imprensa são baseados na auto-propriedade. Nossos corpos são nossas propriedades
            tanto quanto o são as terras e objetos materiais legalmente adquiridos.
            Aquele que possui uma propriedade tem total direito de controlar, usar,
            dispor dela - ou de qualquer maneira usufruir de sua propriedade sem interferência,
            até que e a não ser que, o exercício desse controle
            infrinja direitos válidos de outras pessoas.
        </p>

        <p>
            <strong>Soluções:</strong> Exigimos o fim da taxação de propriedades imobiliárias privadas.
            A propriedade tem sido tomada de seus verdadeiros donos pelo Governo ou por
            ação privada em violação dos direitos individuais; deste modo, apoiamos
            sua restituição a seus legítimos donos.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Somos contra o uso de bloqueios policiais sem razão e sem
            causa provável, parando motoristas para exigir o teste alcoólico,
            e vasculhando passageiros de transportes coletivos sem causa provável.
            Enquanto existir o censo nacional e todas as outras agências federais,
            estaduais ou municipais que compilem dados sobre os cidadãos, essas compilações
            só podem ser feitas com o consentimento das pessoas cujos dados estão
            sendo coletados e analisados. Reprovamos qualquer regulamentação do
            Governo exigindo que um empregador forneça algum plano ou seguro
            saúde aos seus empregados, o que acaba induzindo intrusões desnecessárias
            pelo empregador na vida e privacidade de seus empregados.
        </p>

        <h2><a name="ODireitoDePrivacidade">13. O Direito de Privacidade</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> As proteções à privacidade têm sido lentamente desgastadas ao longo dos anos.
            O número do CPF se tornou praticamente um identificador universal,
            facilitando enormemente os casos de roubo de identidade. O Governo pode acessar
            contas bancárias, bilhetes de viagens aéreas e conhecer todos os hábitos de consumo
            de cidadãos respeitadores da lei, apenas com a fraca justificativa de que
            é preciso evitar crimes ou sonegações.
        </p>

        <p>
            <strong>O Princípio:</strong> O direito do indivíduo à privacidade, propriedade e o direito de falar
            ou não falar não deve ser infringido pelo Governo.
            O Governo não deve usar meios eletrônicos ou de outra natureza para
            espionar as ações de um indivíduo ou sua propriedade sem o consentimento
            do proprietário ou ocupante. Correspondências, transações bancárias ou
            financeiras, registros médicos, comunicações com advogados,
            registros de emprego outros tantos não devem estar abertos para o
            conhecimento do Governo sem o consentimento de todas as
            partes envolvidas nestas ações.
        </p>

        <p>
            Arranjos contratuais privados, incluindo contratos de trabalho,
            devem ser fundados no consentimento mútuo e aceitação em uma sociedade
            que promove a liberdade de associação. Por outro lado, nos opomos
            a qualquer forma de investigação da vida pregressa pelo Governo ou
            regulamentações que forcem empresas prestadoras de serviço para o
            Governo a impor tais investigações.
        </p>

        <p>
            <strong>Soluções:</strong> Apoiamos as proteções contra a arbitrariedade investigatória ou policial
            do Governo e nos opomos ao uso de mandados de busca para examinar
            ou apreender materiais pertencentes a pessoas inocentes. Somos contra
            todas as restrições e regulamentações ao desenvolvimento privado,
            venda e uso de tecnologia de encriptação. Somos contra, especificamente, qualquer
            requerimento de abertura ou violação dos métodos de encriptação ou chaves,
            e qualquer outro requerimento forçando o uso de dispositivos ou protocolos
            de comunicação especificados pelo Governo. Nós também somos contra a classificação
            governamental da pesquisa civil sobre os métodos de encriptação. Se um empregador
            privado selecionar atuais ou futuros empregados por meio de questionários, testes
            de polígrafo ou de urina para detectar drogas, testes de sangue para AIDS
            ou outros métodos, essa é uma condição do contrato de trabalho do empregador.
            Tais métodos não violam os direitos dos candidatos, que têm o direito
            de boicotar tais empregadores se quiserem. Rejeitamos propostas do
            uso de um cartão de identidade universal, a ser requerido em qualquer
            situação, como em uma entrevista de emprego, para votar ou atravessar
            fronteira de outro estado. Também queremos acabar com o uso do
            número de CPF/RG como um código de identificação pessoal, seja por agências governamentais,
            seja por empresas privadas intimidadas pelo Governo.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Somos contra o uso de bloqueios policiais sem razão e
            sem causa provável, parando motoristas para exigir o teste alcoólico,
            e vasculhando passageiros de transportes coletivos sem causa provável.
            Enquanto existir o censo nacional e todas as outras agências federais,
            estaduais ou municipais que compilem dados sobre os cidadãos,
            essas compilações só podem ser feitas com o consentimento das pessoas cujos
            dados estão sendo coletados e analisados. Reprovamos qualquer regulamentação
            do Governo exigindo que um empregador forneça algum plano ou seguro
            saúde aos seus empregados, o que acaba induzindo intrusões desnecessárias
            pelo empregador na vida e privacidade de seus empregados.
        </p>

        <h2><a name="ODireitoDePossuirEPortarArmas">16. O Direito de possuir e portar armas</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> Todos os níveis de governo freqüentemente violam os direitos
            dos cidadãos a sua autodefesa com leis que restringem, limitam ou
            simplesmente proíbem a propriedade e uso de armas de fogo. Essas "leis de desarmamento"
            são sempre justificadas pela falsa premissa de que elas levarão a
            uma redução no nível de violência em nossa sociedade.
        </p>

        <p>
            <strong>O Princípio:</strong> A Constituição assegura o direito à autodefesa do cidadão.
            Nós somos a favor do direito de possuir e portar armas.
        </p>

        <p>
            <strong>Soluções:</strong> Queremos o fim de todo tipo de restrição, regulamentação para a posse,
            manufatura, transferência ou venda de armas de fogo ou munição.
            Rejeitamos todas as leis que exijam o registro de armas de fogo ou munição.
            Queremos o fim de todas as leis de controle de armas. Exigimos o
            fim dos departamentos, secretarias ou outras entidades criadas com
            o específico fim de controlar o uso de tabaco ou de armas de fogo.
        </p>

        <p>
            <strong>Transição:</strong> Condenamos todo e qualquer esforço do Governo para banir
            ou restringir o uso de spray lacrimogêneo, ou quaisquer outros
            dispositivos de autodefesa. Somos contra todas as tentativas de
            banir as armas ou munição sob a alegação de que elas são perigosas.
            Queremos a abolição das leis que proíbam a ocultação de armas ou
            que proíbam "armas de bolso". Queremos a revogação de todas as leis
            que proíbam as "pistolas compactas" ou de baixo custo e suas munições.
        </p>

        <h2><a name="AlistamentoEAsForcasArmadas">17. Alistamento e as Forças Armadas</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> Somos contra qualquer forma de serviço militar obrigatório,
            incluindo a conscrição, programa de trabalho compulsório
            para os jovens ou qualquer outra forma de programa social coercitivo.
        </p>

        <p>
            <strong>O Princípio:</strong> Forçar indivíduos a servir as Forças Armadas não é nada menos que escravidão.
        </p>

        <p>
            <strong>Soluções:</strong> Reconhecer que o registro é a primeira etapa para o alistamento
            ou conscrição total; somos contra qualquer tentativa de registro dos
            indivíduos para fins de alistamento ou conscrição e contra qualquer
            invasão da privacidade de alguém por meio de registros escolares,
            de habilitação para dirigir e outros, para esse mesmo fim. Queremos a
            abolição de qualquer tipo de serviço de seleção de recrutas.
            Queremos a destruição de todos os arquivos em mídia magnética, óptica, mista,
            ou impressa que contenham informações que possam ser usadas para selecionar
            pessoas ao alistamento. Não queremos que as mulheres possam ser
            alistadas, não porque elas não estejam aptas a combater, e sim
            porque queremos reduzir o número de pessoas sujeitas à tirania do Governo.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Pedimos o fim imediato e exoneração incondicional
            de todos aqueles que foram acusados de tentar escapar ao serviço militar,
            que tenham desertado em serviço, ou empreendido qualquer ato de resistência
            em caso de guerras imperialistas ou agressivas por parte
            da nossa nação. Os membros das Forças Armadas devem ter o
            direito de deixar seu trabalho como qualquer outra pessoa.
        </p>

        <p>
            Queremos que ninguém mais seja excluído das Forças Armadas por
            conduta homossexual. Queremos todas as dispensas por essa
            razão sejam anuladas e que tais informações sejam apagadas dos
            registros das Forças Armadas. Recomendamos que seja
            anulado qualquer código de Justiça Militar, e o reconhecimento dos
            direitos civis dos membros das Forças Armadas. Isto irá promover o moral,
            a dignidade e o senso de Justiça dentre os militares.
        </p>

        <h2><a name="Imigracao">18. Imigração</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
             <strong>A questão:</strong> Aceitamos todos os refugiados em nosso país e condenamos os
             esforços impedir que essas pessoas fujam à opressão de seus países ou
             tentem melhorar suas condições econômicas; assim como nenhum cidadão
             deve ser impedido de ajudar pessoas que queiram entrar no país.
        </p>

        <p>
            <strong>O Princípio:</strong> Sustentamos que os direitos humanos não devem ser negados ou restringidos
            com base na nacionalidade. Estrangeiros sem documentação não devem ser impedidos de exercer
            seu direito fundamental de trabalhar e de ir e vir sem serem importunados. Ademais,
            a imigração não deve ser restringida por motivos de raça, religião, crença política,
            idade ou preferência sexual. Somos contra qualquer programa de seguridade social
            ou incentivos para retornar a seus países assim como somos contra todo programa
            de seguridade social para todas os outros cidadãos.
        </p>

        <p>
            <strong>Soluções:</strong> Condenamos a deportação de cidadãos pelo Governo Federal com base na
            falta de documentação para estar no país. Rejeitamos todas as medidas que
            punem empregadores que contratem trabalhadores sem documentos de imigração.
            Tais medidas oprimem o livre empreendimento, hostilizam os trabalhadores e
            sistematicamente desencorajam a contratação de imigrantes, legais ou não.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Queremos a eliminação de todas as restrições à imigração,
            a abolição de todos os serviços de patrulha de fronteiras,
            e a declaração de anistia total àqueles que entraram no país ilegalmente.
        </p>

        <h2><a name="DireitosDasMulheresEAborto">20. Direitos das Mulheres e Aborto</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> Reconhecemos que o aborto é um tema muito sensível e que as pessoas,
            incluindo os libertários, podem ter opiniões de boa-fé nos dois lados da questão.
            Acreditamos que o Governo não deve interferir nesta questão. Somos contra
            abortos pagos ou ordenados pelo Governo. É extremamente duro forçar alguém
            que acredita que o aborto é assassinato a pagar pelo aborto de
            outras pessoas por meio de impostos.
        </p>

        <p>
            <strong>O Princípio:</strong> Sustentamos que os direitos individuais não devem ser negados
            ou restringidos com base no sexo da pessoa. É direito e obrigação da
            mulher grávida, não do Estado, de decidir sobre alguém intervenção
            pré-natal, escolha ou não da cesariana, cirurgia fetal, casos
            de barriga de aluguel e partos ocorridos em casa.
        </p>

        <p>
            <strong>Soluções:</strong> Somos contra todas as leis que imponham restrições à
            livre escolha e propriedade de alguém sobre seu próprio corpo
            ou que expandam a tirania por meio de discriminação reversa.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Queremos o fim de todas as leis que
            discriminem as mulheres, tais como as leis trabalhistas "protetoras" e
            leis de casamento e divórcio que negam os direitos totais de homens e mulheres.
        </p>

        <h2><a name="FamiliasECriancas">21. Famílias e Crianças</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> O envolvimento do Governo nas responsabilidades
            dos pais tem enfraquecido as famílias e substituído os valores familiares
            pelos valores ensinados pelo Governo.
        </p>

        <p>
            <strong>O Princípio:</strong> Famílias e lares são instituições privadas, que devem ser
            livres da intrusão ou interferência por parte do Governo. Pais ou outros guardiões
            têm o direito de educar seus filhos de acordo com seus valores e crenças,
            sem interferência do Governo - a não ser que estes filhos estejam sendo
            molestados física, sexual ou psicologicamente. Devido a esses direitos dos
            pais, um jovem pode não ser capaz de exercer todos os seus direitos dentro
            do contexto familiar. Entretanto, os jovens têm o direito de reivindicar
            sua emancipação assumindo a administração e a proteção de seus próprios
            direitos, encerrando a dependência em relação a seus pais ou guardiões,
            e assumindo todas as responsabilidades da vida adulta. Uma criança, um
            jovem, é um ser humano e, como tal, deve ser tratado com Justiça. Os pais
            não têm o direito de abandonar ou pôr em perigo seus filhos de maneira
            inconseqüente. Sempre que os pais não puderem ou não quiserem criar
            seus filhos, eles devem encontrar outra pessoa para assumir a guarda deles.
        </p>

        <p>
            <strong>Soluções:</strong> Reconhecemos que determinar quando o abuso infantil ocorre
            é difícil. Apenas as cortes locais devem ter o poder de remover uma
            criança de seu lar, com o consentimento da comunidade. Essa medida
            não é a única a ser tomada quando uma criança estiver em perigo físico imediato.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Abolir todas as leis que impedem esses processos, notadamente aquelas
            que restringem os serviços privados de adoção. Somos contra as leis
            que impedem a criança de exercer seu direito de trabalhar ou aprender,
            tais como as leis proibindo o trabalho infantil e as leis que prevêem educação
            compulsória. Queremos o fim da prática de se deter crianças e
            jovens que não foram acusados de nenhum crime. Que sejam extintos os
            estatutos que impedem que as crianças e jovens tenham o
            mesmo tratamento e proteções processuais dos adultos.
        </p>

        <h2><a name="DireitosSexuais">22. Direitos sexuais</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>A questão:</strong> O Governo presumiu que deve decidir sobre o que é ou não aceitável
            em práticas sexuais dentro dos relacionamentos pessoais,
            impondo um código particular de moral e de valores morais,
            retirando a escolha pessoal nesses assuntos.
        </p>

        <p>
            <strong>O Princípio:</strong> Adultos têm o direito a fazer
            sua escolha privativa em atividades
            sexuais consensuais.
        </p>

        <p>
            <strong>Soluções:</strong> Propomos o fim a todas as tentativas do Governo de ditar,
            proibir, controlar ou encorajar qualquer estilo particular de vida,
            de união de pessoas ou qualquer relação contratual.
        </p>

        <p>
            <strong>Ações transitórias:</strong> Repelir leis e políticas existentes que visam condenar,
            afirmar, encorajar ou negar estilos de vida sexual, ou quaisquer conjuntos de
            atitudes com relação a esses estilos de vida.
        </p>

        <h2><a name="DireitosDosIndios">23. Direitos dos Índios</a></h2>

        <p class="top"><a href="#Topo">Ir para o topo</a></p>

        <p>
            <strong>O Tema:</strong> Os direitos dos índios têm sido usurpados ao longo dos anos.
        </p>

        <p>
            <strong>O Princípio:</strong> Os indivíduos devem ser livres para decidir e escolher
            sua própria cidadania, e as tribos devem ser livres para escolher
            o nível de autonomia que desejam.
        </p>

        <p>
            <strong>Soluções:</strong> Os índios devem ter seus direitos de propriedade
            restaurados, inclusive direitos de livre trânsito, acesso, caça e pesca.
        </p>

        <p>
            <strong>Transição:</strong> Os órgãos regulamentadores dos índios devem ser abolidos,
            deixando que as próprias tribos e seus membros determinem seu sistema de
            governo. Devem ser entabuladas negociações para solucionar
            todas as questões entre as tribos e o Governo.
        </p>

    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
