using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace LiberMvc.Models
{
#if DEBUG
	public class LiberDBInitializer : DropCreateDatabaseIfModelChanges<LiberDB>
#else
	public class LiberDBInitializer : CreateDatabaseIfNotExists<LiberDB>
#endif
	{
		protected override void Seed(LiberDB context)
		{

			base.Seed(context);

			#region GrauInstrucao

			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Selecione o Grau de Instrução" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Fundamental (1ª a 8ª) [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Fundamental (1ª a 8ª)" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Médio (Colegial) [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Médio (Colegial)" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Médio (Magistério) [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Ensino Médio (Magistério)" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Superior - Técnica [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Superior - Técnica" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Superior - Graduação [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Superior - Graduação" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Especialização e extensão [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Especialização e extensão" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Pós-graduação [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Pós-graduação" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "MBA [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "MBA" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Mestrado [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Mestrado" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Doutorado [Incompleto]" });
			context.GrauInstrucao.Add(new GrauInstrucao { Descricao = "Doutorado" });

			#endregion

			#region EstadoCivil
			
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Selecione o Estado Civil" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Solteiro (a)" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Casado (a)" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Divorciado (a)" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Viúvo (a)" });
			context.EstadoCivil.Add(new EstadoCivil { Descricao = "Outros" });

			#endregion

			#region TipoPostagem

			context.TiposPostagem.Add(new TipoPostagem { TipoPostagemID = 1, Descricao = "Blog" });
			context.TiposPostagem.Add(new TipoPostagem { TipoPostagemID = 2, Descricao = "Artigo" });
			context.TiposPostagem.Add(new TipoPostagem { TipoPostagemID = 3, Descricao = "Video" });

			#endregion

			#region Titulos

			context.Titulos.Add(new Titulo { TituloID = 1, Nome = "Usuário", Codigo = "Usuario" });
			context.Titulos.Add(new Titulo { TituloID = 2, Nome = "Filiado", Codigo = "Filiado" });
			context.Titulos.Add(new Titulo { TituloID = 3, Nome = "Administrador", Codigo = "Admin" });
			context.Titulos.Add(new Titulo { TituloID = 4, Nome = "Editor", Codigo = "Editor" });
			
			#endregion

			#region Paginas

			#region submenu: nossoPartido
			var nossoPartido = @"
 <div id=""index"">
            <h1>Nosso Partido</h1>
					<ul>
						<li><a href=""/Liber/Historia"">História</a></li>
						<li><a href=""/Liber/Filosofia"">Filosofia</a></li>
						<li><a href=""/Liber/Programa"">Programa</a></li>
						<li><a href=""/Liber/Estatuto"">Estatuto</a></li>
						<li><a href=""/Liber/Lideranca"">Lideranças Nacionais</a></li>
						<li><a href='/Liber/Contas'>Prestação de Contas</a></li>
					</ul>
         </div>
";
			#endregion

			context.Paginas.Add(new Pagina
			{
				PaginaID = 1,
				Titulo = "História",
				Link = "Historia",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = nossoPartido + @"
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



        <p class=""image"">

            <img src=""/Content/images/fundacao.jpg"" alt=""Fundação"" /><br />

            <span class=""legend"">Reunião de fundação do LIBER, 20 de Junho de 2009.</span>

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



        <ul class=""annexes"">

            <li class=""pdf_file"">

                <a id=""A1"" href=""/Content/download/carta_helio_beltrao.pdf"" target=""_blank"">Carta de Helio Beltrao em apoio a fundação do LIBER.</a>

            </li>

            <li class=""pdf_file"">

                <a href=""/Content/download/Ata_CGNacional_2010.04.10.pdf"" target=""_blank"">

                    Ata da Convenção Geral do Diretório Nacional do

                    Libertários em Porto Alegre na data de 10 de abril de

                    2010.

                </a>

            </li>

            <li class=""pdf_file"">

                <a href=""/Content/download/fundacao.pdf"" target=""_blank"">Veja a ata de fundação aqui.</a>

            </li>

        </ul>
"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 2,
				Titulo = "Filosofia",
				Link = "Filosofia",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = nossoPartido + @"
		<p>

			O LIBER é uma instituição de atuação política, sem fins lucrativos, 

			que visa difundir os preceitos do Libertarianismo, doutrina filosófica 

			baseada nos princípios da não agressão e da auto-propriedade.

		</p>



		<p>

			O Libertarianismo defende a maximização das liberdades individuais, 

			devolvendo às pessoas o direito de determinar a condução de suas vidas 

			e de realizar suas escolhas de acordo com suas próprias consciências, 

			desde que sem iniciar agressão contra terceiros, possibilitando, assim, 

			o pleno desenvolvimento de suas capacidades e felicidade.

		</p>



		<p>

			O Libertarianismo abomina qualquer intervenção violenta na vida e nas 

			escolhas das pessoas, seja ela promovida por outros indivíduos ou por grupos. 

			Ademais, sempre que o estado viola o direito dos indivíduos de dispor 

			do próprio tempo e de seus bens, o resultado é desastroso - miséria, 

			escassez e guerras. Assim, o LIBER acredita que em um Livre Mercado 

			de bens e ideias, todos os indivíduos são beneficiados, independentemente 

			de sua aptidão física, classe social ou grau de instrução.

		</p>



		<p>

			O LIBER acredita que uma sociedade baseada na cooperação voluntária 

			é uma sociedade mais justa, solidária, coesa e próspera. Da mesma forma, 

			o LIBER entende que qualquer tentativa de criar justiça, solidariedade, 

			coesão ou prosperidade baseada na imposição, no uso de força, em ameaças 

			ou em sanções é absurda, imoral e sempre resultará no exato oposto - na 

			sociedade em que vivemos hoje, uma sociedade dividida, onde reina 

			a pobreza, a indiferença e a injustiça.

		</p>



		<p>

			O LIBER movimenta-se para tornar-se um partido político, ampliando, assim, 

			seu leque de atuação, de forma a permitir a difusão do Libertarianismo 

			dentro da própria ""máquina estatal"".

		</p>
"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 3,
				Titulo = "Programa",
				Link = "Programa",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = nossoPartido + @"
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

            ""crimes sem vítima""; descriminalização do uso de drogas;

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


"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 4,
				Titulo = "Estatuto",
				Link = "Estatuto",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = nossoPartido + @"
        <h2>O Partido e Seus Objetivos.</h2>



        <p>

		    Artigo 1º. O Libertários, cuja sigla é; LIBER, é um

		    partido político, com sede e foro na Capital Federal, duração

		    indeterminada, ação em todo o território nacional e é

		    regido por este Estatuto e pela legislação aplicável.

	    </p>



	    <p>

		    Artigo 2º. O LIBER visa defender e propagar os princípios do Libertarianismo,

		    conforme detalhados em seu Programa, segundo os quais:

	    </p>



	    <p>

		    I. Todo indivíduo tem direito (a) à vida, origem de todos os outros

		    direitos; (b) à liberdade de agir e buscar sua felicidade como lhe convier;

		    e (c) à propriedade, fruto legítimo de sua vida e sua liberdade; e

	    </p>



		<p>

			II. Para que esses direitos sejam respeitados, é essencial que nenhum

			indivíduo ou grupo inicie o uso de forçaa ou fraude contra outrem.

		</p>



		<p>

			Parágrafo ùnico. Alterações neste artigo necessitam

			aprovação de 90% (noventa por cento) dos filiados com direito a voto

			em convenção exclusiva para este fim.

		</p>



		<h2>Os Filiados, Seus Direitos e Deveres.</h2>



        <p>

	        Artigo 3º. Pode se filiar ao LIBER qualquer brasileiro, no pleno gozo de seus

	        direitos políticos, que concorde com o Programa e o Estatuto do LIBER. &sect;

	        1º. O filiado fica vinculado ao DI Nacional e aos outros

	        cujas áreas incluam o seu domicílio eleitoral. &sect;

            2º. O DI da menor subdivisão fará o controle das filiações

	        e disponibilizará as informações aos DIs que o englobem.

        </p>



	    <p>

		    Artigo 4º. Os filiados têm direito a:

	    </p>



		<p>

			I. Votar nas convenções diretas;

		</p>



		<p>

			II. Concorrer a cargos dos DIs que participe;

		</p>



		<p>

			III. Concorrer pelo LIBER a cargos públicos, respeitadas as normas de

			escolha de candidatos;

		</p>



		<p>

			IV. Ser informado sobre as decisões e finanças do LIBER em todos

			os níveis da federação; e

		</p>



		<p>

			V. Ter seus dados mantidos em sigilo, exceto conforme exigido por lei e para

			as finalidades intrínsecas do LIBER.

            &sect; 1º. O direito indicado no inciso I acima, apenas poderá ser exercido por indivíduos

			em dia com suas anuidades e filiados há mais de 12 (doze) meses.

            &sect; 2º. Os direitos indicados nos incisos II a III acima, apenas

			poderão ser exercidos por indivíduos em dia com suas anuidades e filiados

			há mais de 24 (vinte e quatro) meses.

		</p>



	    <p>

		    Artigo 5º. É dever dos filiados:

	    </p>



		<p>

			I. Manter conduta ética;

		</p>



		<p>

			II. Manter atitude respeitosa com outros filiados;

		</p>



		<p>

			III. Abster-se de defender posições contrárias aos princípios

			libertários; e

		</p>



		<p>

			IV. Pagar a anuidade dos DIs.

		</p>



		<p>

			Artigo 6º. A filiação será cancelada nas hipóteses

			previstas em lei e por decisão do CJ competente, da qual mais recurso.

		</p>



		<h2>Organização e Funcionamento.</h2>



		<p>

			Artigo 7º. O LIBER se organiza em Diretórios (DI) que podem existir

			nos níveis nacional, estadual, municipal e, quando for o caso, zonal.

		</p>



		<p>

			&sect; 1º. Cada DI terá programa e estatuto complementar aos dos

			DIs superiores;

		</p>



		<p>

			&sect; 2º. Respeitados os limites aqui previstos, cada DI terá

			autonomia para definir sua estrutura e decidir as questões pertinentes ao

			seu âmbito de atuação.

		</p>



		<p>

			Artigo º. Cada DI deverá possuir os seguintes órgãos:

		</p>



		<p>

			I. Convenção Geral (CG);

		</p>



		<p>

			II. Comitê Executivo (CE);

		</p>



		<p>

			III. Comitê Fiscal (CF); e

		</p>



		<p>

			IV. Comitê Julgador (CJ).

		</p>



	    <p>

		    &sect; 1º. É vedado o acúmulo de cargos em quaisquer órgãos

		    de um mesmo DI. Em DIs de diferentes níveis da federação apenas

		    é permitido o acúmulo de um ou mais cargos no CE (exceto se na Executiva)

		    com outro cargo qualquer.

	    </p>



		<p>

			&sect; 2º. Os membros destes órgãos não receberão

			remuneração ou isenção de anuidades, exceto pelo ressarcimento

			de despesas previamente autorizadas e comprovadamente incorridas no exercício

			de sua função.

		</p>



		<p>

			&sect; 3º. Os DIs zonais poderão optar, em seus estatutos, por

			substituir os órgãos previstos acima, por uma Executiva e um corpo

			de delegados.

		</p>



		<p>

			Artigo 9º. A criação de um DI depende da aprovação

			deste pela CG do DI imediatamente superior.

		</p>



		<p>

			Artigo 10. Pelo voto favorável de 75% (setenta e cinco por cento) de

			sua CG, o DI imediatamente superior poderá dissolver o DI abaixo. A convocação

			desta CG deverá ser fundamentada e poderá ser questionada pelo DI

			prejudicado no CJ Nacional.

		</p>



		<h2>As Convenções Gerais.</h2>



		<p>

			Artigo 11. Periodicamente os DIs deverão reunir seus filiados em CGs na forma

			estabelecida neste Estatuto, as quais deverão ser diretas nos DIs da menor

			subdivisão do LIBER e indiretas, por meio de delegados, nos demais DIs.

		</p>



		<p>

			&sect; 1º. Não obstante o &sect; 1º do Artigo 4º, todo filiado

			poderá comparecer e se manifestar nas CGs.

		</p>



		<p>

			&sect; 2º. Nas CGs indiretas, os DIs imediatamente inferiores poderão

			enviar (a) 01 (um) delegado para cada 01% (um por cento) da arrecadação

			com anuidades obtida pelo DI em questão, paga por filiados ao DI inferior;

			e (b) 01 (um) delegado para cada 01% (um por cento) dos votos obtidos por candidatos

			do LIBER em eleições proporcionais da unidade da federação

			do DI em questão, na área correspondente àquele DI inferior;

			sempre arredondado para baixo. Se for o caso, pelo menos 02 (dois) dias úteis

			antes da CG, o DI realizará uma reunião prévia na qual votarão

			os filiados não vinculados a DIs inferiores, esta reunião terá

			efeitos de um DI inferior. Caso algum DI imediatamente inferior não totalize

			01% (um por cento) da arrecadação e dos votos ele terá direito

			a 01 (um) delegado.

		</p>



		<p>

			&sect; 3º. O estatuto de cada DI inferior determinará como serão

			escolhidos seus delegados.

		</p>



		<p>

			&sect; 4º. Os delegados poderão outorgar procurações

			a outro delegado de seu DI ou enviar seu voto por escrito ao presidente da CG.

		</p>



		<p>

			Artigo 12. Compete exclusivamente às CGs:

		</p>



		<p>

			I. Ordinariamente, nos 04 (quatro) primeiros meses de cada ano, deliberar sobre

			as demonstrações financeiras, eleger os membros dos seus órgãos

			e indicar os respectivos membros do CE do DI acima, nos termos do Artigo 13, &sect; 2º;

		</p>



		<p>

			II. Sempre que houver uma eleição, definir os candidatos do respectivo

			ente federativo e, se for o caso, definir o voto dos delegados do DI na CG correspondente

			do DI acima;

		</p>



		<p>

			III. Alterar o estatuto e programa do DI;

		</p>



		<p>

			IV. Tornar definitiva a suspensão e substituir o Presidente do CE e

			sua Executiva;

		</p>



		<p>

			V. Autorizar a criação ou dissolver o DI abaixo ou o respectivo

			DI e definir a destinação de seu patrimônio; e

		</p>



		<p>

			VI. Deliberar sobre qualquer assunto relevante, conforme decidido pelo CE.

		</p>



		<p>

			&sect; 1º. Alterações nos programa requerem aprovação

			de 75% (setenta e cinco por cento) dos respectivos filiados com direito a voto;

		</p>



		<p>

			&sect; 2º. As CGs serão convocadas pelo Presidente do CE, com pelo

			menos 30 (trinta) dias de antecedência nas Nacionais, explicitando-se, na

			convocação, a pauta, local, data, horários de início

			e fim e, quando for o caso, a data e horários da reunião prévia

			e a quantidade de delegados de cada DI. As CGs serão instaladas, em primeira

			convocação, com a presençaa de 25% (vinte e cinco por cento)

			dos membros com direito a voto. Salvo previsto em contrário, as votações

			da CG serão decididas por maioria simples, desconsiderados os votos brancos

			e nulos.

		</p>



		<h2>Comitê Executivo.</h2>



		<p>

			Artigo 13. Cada CE possuirá atá 53 (cinquenta e três)

			membros, com mandato de 02 (dois) anos, com inicio no dia seguinte à confirmação

			de sua eleição, e terá competência para:

		</p>



		<p>

			I. Aprovar regras gerais para a organização do DI, incluindo

			procedimentos para as CGs e escolha de candidatos;

		</p>



		<p>

			II. Ratificar ou rejeitar integralmente as regras propostas pelo CF e CJ;

		</p>



		<p>

			III. Suspender por qualquer motivo o Presidente do CE;

		</p>



		<p>

			IV. Ouvido o CJ, decidir sobre aliança eleitoral;

		</p>



		<p>

			V. Propor alterações no estatuto e no programa do DI; e

		</p>



		<p>

			VI. Requisitar, motivadamente, a convocação da CG para deliberar

			sobre quaisquer assuntos.

		</p>



		<p>

			&sect; 1º. O Presidente, o Vice-Presidente e o Secretário do CE

			são eleitos concorrendo na mesma chapa e não poderão ser reeleitos;

			já os demais membros serão eleitos individualmente pela CG. Em até

			05 (cinco) dias da posse o Presidente indicará, dentre os demais membros

			do CE, o Tesoureiro e o Corregedor, que deverão receber o aval, respectivamente,

			do CF e do CJ. Presidente, Vice-Presidente, Secretário, Tesoureiro e Corregedor

			do CE constituirão a Executiva do DI.

		</p>



		<p>

			&sect; 2º. Nas CGs indiretas, os DIs imediatamente abaixo poderão

			eleger (a) 01 (um) membro do CE para cada 04% (quatro por cento) da arrecadação

			obtida com anuidades pelo DI em questão, paga por filiados ao DI inferior;

			e (b) 01 (um) membro para cada 04% (quatro por cento) dos votos obtidos por candidatos

			do LIBER em eleições proporcionais da unidade da federação

			do DI em questão, na área correspondente àquele DI inferior;

			sempre arredondado para baixo. Os DIs poderão se compor para aproveitar as

			sobras de seus votos.

		</p>



		<p>

			&sect; 3º. As reuniões do CE serão convocadas pelo Presidente

			da CE, com pelo menos 10 (dez) dias de antecedência e serão instaladas

			com a presençaa da maioria dos seus membros. Salvo previsão em contrário,

			as votações dos CEs serão decididas por maioria simples, desconsiderados

			os votos brancos e nulos. Os membros da CE poderão outorgar procurações

			a outro membro ou enviar seu voto por escrito ao presidente da CE.

        </p>



        <p>

            &sect; 4º. Os membros da CE permanente impedidos serão repostos na próxima CG

			Ordinária e os novos membros completarão o mandato vacante. Caberá

			ao DI que indicou o membro impedido indicar seu substituto.

		</p>



		<p>

			&sect; 5º. As reuniões do CE poderão ser assistidas por

			qualquer filiado.

		</p>



		<p>

			Artigo 14. Compete ao Presidente:

		</p>



		<p>

			I. A administração ordinária do DI;

		</p>



		<p>

			II. Convocar e presidir as CGs e as reuniões do CE;

		</p>



		<p>

			III. Com o aval da CF ou CJ, respectivamente, nomear e substituir o Tesoureiro

			e o Corregedor;

		</p>



		<p>

			IV. Representar o DI, ativa ou passivamente, em juízo ou fora dele,

			pessoalmente ou por procuradores, conforme aqui previsto.

		</p>



		<p>

			Parágrafo Único. O Presidente será responsabilizado sempre

			que, por dolo ou culpa, ações ou omissões no exercício

			de sua função trouxerem prejuízo ao LIBER ou à; sua imagem.

		</p>



		<p>

			Artigo 15. Compete ao Vice-Presidente:

		</p>



		<p>

			I. Substituir o Presidente em casos de impedimentos;

		</p>



		<p>

			II. Realizar as obrigações do Presidente no caso de inércia

			deste; e

		</p>



		<p>

			III. Exercer as demais atribuições que lhes sejam conferidas

			pelo Presidente.

		</p>



		<p>

			&sect; 1º. No caso do inciso II acima, o Vice-Presidente iniciará

			uma representação contra o Presidente no CJ para que se avaliem os

			motivos da inércia.

		</p>



		<p>

			&sect; 2º. O Vice-Presidente será responsabilizado sempre que,

			por dolo ou culpa, não cumprir suas funções, especialmente

			no que trata o inciso II acima.

		</p>



		<p>

			Artigo 16. Compete ao Secretário:

		</p>



		<p>

			I. Participar de e registrar todas as reuniões do CE e CGs;

		</p>



		<p>

			II. Manter as informações sobre filiados vinculados ao seu DI

			e, quando for o caso, repassá-las ao DI superior, resguardando o sigilo sobre

			informações privadas;

		</p>



		<p>

			III. Supervisionar os demais registros do DI e exercer as atribuições

			inerentes; e

		</p>



		<p>

			IV. Salvo no caso de documentos sigilosos ou privados, zelar pela ampla divulgação

			de seus registros e fornecer cópias destes sempre que solicitado por qualquer

			filiado, exigindo apenas o necessário para cobrir os custos.

		</p>



		<p>

			&sect; 1º. No caso de impedimento temporário do Secretário

			o Vice-Presidente assumira suas funções. No caso de impedimento permanente

			o Presidente indicará o novo Secretário dentre os membros da CE, o

			qual deverá receber o aval da CF e do CJ.

		</p>



		<p>

			&sect; 2º. O Secretário será responsabilizado sempre que,

			por dolo ou culpa, houver informações incorretas em seus registros

			ou ocorrer a divulgação de dados sigilosos ou privados.

		</p>



		<p>

			Artigo 17. Compete ao Tesoureiro:

		</p>



		<p>

			I. Manter a contabilidade e elaborar as demonstrações financeiras

			do exercício encerrado, conforme os princípios de contabilidade geralmente

			aceitos no Brasil e a legislação aplicável;

		</p>



		<p>

			II. Controlar o pagamento e inadimplência dos filiados;

		</p>



		<p>

			III. Assinar, com o Presidente, quaisquer documentos que impliquem responsabilidade

			financeira do DI; e

		</p>



		<p>

			IV. Informar o CF periodicamente e sempre que solicitado sobre a situação

			financeira e os gastos DI e auxiliar o CF em suas atribuições.

		</p>



		<p>

			&sect; 1º. As demonstrações financeiras anuais deverão

			indicar com clareza a participação de cada DI inferior na arrecadação

			com anuidades obtida pelo DI em questão. Esta participação

			será utilizada para a os cálculos indicados no item (a) do Artigo

			11º, &sect; 2º e do Artigo 13, &sect; 2º.

		</p>



		<p>

			&sect; 2º. O Tesoureiro será responsabilizado sempre que, por dolo

			ou culpa, deixar de prestar informações relevantes ao CF, houver informações

			incorretas em seus registros ou o DI sofrer prejuízo financeiro.

		</p>



		<p>

			Artigo 18. Compete ao Corregedor:

		</p>



		<p>

			I. Supervisionar o andamento das atividades relevantes da Executiva;

		</p>



		<p>

			II. Aconselhar a Executiva em questões que envolvam a ética e

			disciplina partidária;

		</p>



		<p>

			III. Exercer a presidência do DI no impedimento do Presidente e do Vice-Presidente;

		</p>



		<p>

			IV. Assinar, com o Presidente, quaisquer documentos que impliquem vinculação

			política do LIBER com outros partidos; e

		</p>



		<p>

			V. Informar o CJ periodicamente e sempre que solicitado sobre as atividades

			exercidas pelo CE e auxiliar o CJ em suas atribuições.

		</p>



		<p>

			Parágrafo Único. O Corregedor será responsabilizado sempre

			que, por dolo ou culpa, deixar de prestar informações relevantes ao

			CJ ou o DI sofrer dano à sua imagem.

		</p>



		<h2>Comitê Fiscal.</h2>



		<p>

			Artigo 19. O CF terá 03 (três) membros, com mandato de 03 (três)

			anos eleitos, um a cada ano, pela CG, e terá competência para:

		</p>



		<p>

			I. Acompanhar a movimentação financeira do DI;

		</p>



		<p>

			II. Auditar e opinar sobre as demonstrações financeiras anuais;

		</p>



		<p>

			III. Auditar, organizar e enviar ao órgão estatal competente

			e ao DI superior, toda a prestação de contas do DI;

		</p>



		<p>

			IV. Acompanhar e orientar a atuação dos candidatos, parlamentares

			e executivos do âmbito do DI sobre o uso de recursos e provocar o CJ no caso

			de irregularidades; e

		</p>



		<p>

			V. Elaborar e propor à CE regras sobre assuntos de sua competência,

			como o uso de recursos, prestação de contas e sua estrutura interna.

		</p>



		<p>

			&sect; 1º. O presidente do CF será escolhido por seus pares, para

			o mandato de 01 (um) ano.

		</p>



		<p>

			&sect; 2º. Em impedimento permanente de membro do CF, os demais indicarão

			substituto provisório, que ocupará o cargo até a próxima

			CG Ordinária, a qual elegerá o substituto para completar o mandato

			vacante. Caso a maioria dos membros esteja permanentemente impedida (com ou sem

			substitutos provisórios) será convocada imediatamente uma CG para

			eleger os substitutos permanentes.

		</p>



		<p>

			&sect; 3º. As decisões do CF são tomadas por maioria dos

			votos, cabendo ao seu presidente o voto de desempate. As demais regras para reunião

			serão definidas da forma prevista neste Estatuto.

		</p>



		<h2>Comitê Julgador.</h2>



		<p>

			Artigo 20. O CJ terá 05 (cinco) membros, com mandato de 05 (cinco)

			anos eleitos, um a cada ano, pela CG, e terá competência para:

		</p>



		<p>

			I. Sempre que provocado por qualquer interessado, julgar conflitos internos

			do DI e aplicar sanções;

		</p>



		<p>

			II. Analisar previamente candidaturas a cargos públicos, com o objetivo

			de impedir o aparelhamento do partido ou seu uso para obter cargos públicos

			independentemente do compromisso com as ideias libertárias.

		</p>



		<p>

			III. Analisar e opinar sobre as propostas de aliançaa partidária;

		</p>



		<p>

			IV. Acompanhar e orientar a atuação dos filiados ao DI no tocante

			à coerência com o Programa e os princípios libertários; e

		</p>



		<p>

			V. Elaborar e propor à CE regras sobre assuntos de sua competência,

			como a organização de julgamentos, aplicação de sanções

			e sua estrutura interna.

		</p>



		<p>

			&sect; 1º. O presidente do CJ será escolhido por seus pares, para

			o mandato de 01 (um) ano.

		</p>



		<p>

			&sect; 2º. Em impedimento permanente de membro do CJ, os demais indicarão

			substituto provisório, que ocupará o cargo até a próxima

			CG Ordinária, a qual elegerá o substituto para completar o mandato

			vacante. Caso a maioria dos membros esteja permanentemente impedida (com ou sem

			substitutos provisórios) será convocada imediatamente uma CG para

			eleger os substitutos permanentes.

		</p>



		<p>

			&sect; 3º. No caso de impedimento permanente do Presidente e do Vice-Presidente

			do CE o presidente do CJ imediatamente convocará uma CG para a eleição

			da nova Executiva.

		</p>



		<p>

			&sect; 4º. As decisões do CJ são tomadas por maioria dos votos,

			cabendo ao seu presidente o voto de desempate. As demais regras para reunião

			serão definidas da forma prevista neste Estatuto.

		</p>



		<h2>Disciplina e Fidelidade Partidária</h2>



		<p>

			Artigo 21. Observadas os estatutos dos demais DIs, as normas e demais disposições

			propostas pelo CJ e aprovadas pelo CE, os processos disciplinares do LIBER serão

			regidos pelo disposto neste capítulo.

		</p>



		<p>

			Artigo 22. Quando provado, em processo conduzido pelo CJ, garantida ampla defesa,

			que um filiado praticou qualquer das atividades indicadas abaixo, o filiado sofrerá

			a medida disciplinar cabível.

		</p>



		<p>

			I. Desrespeito à ética libertária, às diretrizes

			programáticas, exercício de atividade política contrária

			ao Programa ou qualquer forma de promoção do Estado e de suas competências;

		</p>



		<p>

			II. Descumprimento do Estatuto ou desobediência à orientação

			fixada por árgão competente;

		</p>



		<p>

			III. Promoção de filiações em bloco que objetivem

			o predomínio de pessoas ou grupos estranhos ou sem afinidade com o LIBER;

		</p>



		<p>

			IV. Pagamento coletivo da contribuição de filiados;

		</p>



		<p>

			V. Desrespeito, agressão ou formulação de denúncias

			infundadas contra outros filiados;

		</p>



		<p>

			VI. Obstrução ao funcionamento de qualquer órgão

			do LIBER;

		</p>



		<p>

			VII. Abandono, sem motivo justificado por escrito, dos cargos e funções

			partidárias;

		</p>



		<p>

			VIII. Improbidade no exercício de cargo público, função

			administrativa ou em órgão partidário;

		</p>



		<p>

			IX. Infidelidade partidária, nos termos da lei e deste Estatuto; e

		</p>



		<p>

			X. Salvo autorização expressa do CE correspondente, apoiar governos

			que contrariem os princípios do LIBER, principalmente através do exercício

			de cargo políticos.

		</p>



		<p>

			Parágrafo Único. A infidelidade não será punível,

			sempre que for motivada, de forma fundamentada, por violação ao inciso

			I acima realizada por órgão do LIBER de um DI igual ou superior àquele

			prejudicado pela infidelidade.

		</p>



		<p>

			Artigo 23. O CJ definirá a medida disciplinar cabível, dentre

			as listadas abaixo, conforme a severidade da infração, os danos causados

			ao LIBER e a primariedade do réu.

		</p>



		<p>

			&sect; 1º. São medidas disciplinares:&nbsp;

		</p>



		<p>

			I. Advertência pública;

		</p>



		<p>

			II. Suspensão de 01 (um) a 12 (doze) meses, a qual suspende os direitos

			do filiado indicados nos incisos I a III do Artigo 4º;

		</p>



		<p>

			III. Destituição de função em órgão partidário;

		</p>



		<p>

			IV. Perda das prerrogativas, cargos ou funções que exerça

			em decorrência da representação e da proporção

			partidária, na respectiva Casa Legislativa;

		</p>



		<p>

			V. Perda de mandato; e

		</p>



		<p>

			VI. Desligamento, que acarretará no afastamento definitivo do filiado ao LIBER.

		</p>



		<p>

			&sect; 2º. O CJ poderá cumular as medidas disciplinares.

		</p>



		<p>

			&sect; 3º. As decisões do CJ serão fundamentadas e, quando for

			o caso, deverão explicitar seu prazo e/ou condição de revogação.

		</p>



		<p>

			Artigo 24. Qualquer filiado prejudicado poderá ou, sempre que tiver

			ciência, o corregedor deverá iniciar o processo disciplinar mediante

			representação contra o infrator na CJ da menor subdivisão competente.

		</p>



		<p>

			Artigo 25. Salvo quando a punição se limitar a advertência pública,

			o prejudicado, dentro de 15 (quinze) dias, poderá recorrer ao CJ imediatamente

			superior, o qual deverá decidir nos limites do questionamento.

		</p>



		<p>

			&sect; 1º. Se a sentença for confirmada não caberá novo

			recurso; do contrário, o prejudicado ou o corregedor do DI contrariado poderá

			recorrer ao CJ acima do que proferiu a segunda decisão e este decidirá

			definitivamente.

		</p>



		<p>

			&sect; 2º. A decisão deste último CJ será limitada pelas

			anteriores, de forma que não será possível aplicar novas penas,

			ou proferir sentenças mais gravosas ou mais brandas que as aplicadas pelas

			CJs inferiores.

		</p>



		<p>

			&sect; 3º. Caso não haja CJ acima disponível, caberá pedido

			de reconsideraçã;o ao último CJ.

		</p>



		<h2>Fontes de Recursos</h2>



		<p>

			Artigo 26. As fontes de recursos do LIBER são:

		</p>



		<p>

			I. Anuidades pagas pelos filiados;

		</p>



		<p>

			II. Doações, observada a legislação;

		</p>



		<p>

			III. Rendimentos decorrentes de sua atividade ou da aplicação

			de seus recursos; e

		</p>



		<p>

			IV. Repasses públicos que o LIBER seja obrigado a receber.

        </p>



        <p>           

            Parágrafo Único. As doações serão feitas diretamente

			ao DI favorecido e não contarão para fins item (a) do Artigo 11º,

	        &sect; 2º e do Artigo 13, &sect; 2º.

		</p>



		<p>

			Artigo 27. O valor das anuidades será definido pela CG de cada DI da

			menor subdivisão possível e será igual para todos os filiados

			ao DI em questão, permitido apenas abatimentos para menores de 24 (vinte

			e quatro) anos.

        </p>



        <p>

            Parágrafo Único. O não pagamento

			da anuidade não será motivo para inicio de procedimento administrativo

			e seus efeitos não serão considerados para fins de reincidência.

		</p>



		<p>

			Artigo 28. A CG de cada DI que englobe outros DIs deverá definir o percentual

			da arrecadação com anuidades dos filiados dos DIs englobados que esse

			receberá e, quando houver filiados não vinculados a DIs inferiores,

			também deverá definir o valor da anuidade a ser paga por estes filiados.

		</p>



	    <p>

		    &sect; 1º. O percentual definido deverá ser igual para todos os DIs

		    englobados e não poderá ser superior a 50% (cinquenta por cento)

		    da arrecadação total com anuidades dos DIs imediatamente inferiores.

	    </p>



		<p>

			&sect; 2º. Quando for o caso, a anuidade cobrada por um DI superior, não

			poderá ser mais gravosa que a maior anuidade dos DIs imediatamente inferiores.

			Caso a maior anuidade de um DI imediatamente inferior seja reduzida, a anuidade

			do DI superior será reduzida sem necessidade uma CG.

		</p>



		<p>

			Artigo 29. As anuidades sempre serão pagas ao DI da menor subdivisão

			possível e este repassará a porcentagem correspondente de sua arrecadação

			com filiados ao DI imediatamente superior.

		</p>



		<p>

			Artigo 30. Os repasses públicos que o LIBER é obrigado a receber,

			serão divididos em duas partes, uma incorporada ao patrimônio do DI

			em questão e outra distribuída entre os DIs imediatamente inferiores,

			na proporção dos votos obtidos por eles na última eleição

			proporcional do DI em questão.

		</p>



		<p>

			&sect; 1º. Nos termos da legislação vigente o DI Nacional deverá

			direcionar o valor correspondente para a criação e manutenção

			de instituto ou fundação de pesquisa e de doutrinação

			e educação política.

		</p>



		<p>

			&sect; 2º. A parcela repassada aos DIs inferiores será maior do que

			a retida e será definida em CG do DI correspondente.

		</p>



		<p>

			Artigo 31. Toda a contabilidade do LIBER seá realizada conforme os termos

			definidos pelo CF, os princípios de contabilidade geralmente aceitos no Brasil,

			a legislação aplicável e as recomendações dos órgãos estatais competentes.

		</p>



		<p>

			Artigo 32. O presidente do CF submeterá aos órgãos estatais

			competentes, nos prazos determinados em lei, o balanço contábil, a

			prestação de contas e toda a documentos exigida por lei.

		</p>



		<h2>Disposições Transitórias.</h2>



		<p>

			Artigo 33. As exigências de 12 (doze) e 24 (vinte e quatro) meses de

			filiação, previstos, respectivamente nos &sect; 1º e &sect; 2º,

			Artigo 4 acima, não se aplicam para indivíduos filiados até

			06 (seis) meses antes da obtenção do registro do partido no Tribunal

			Superior Eleitoral.

		</p>



		<p>

			Artigo 34. Até a primeira eleição proporcional do DI correspondente

			em que participem candidatos do LIBER:

		</p>



		<p>

			I. Não serão indicados delegados ou membros do CE em decorrência

			do item (b) do Artigo 11º, &sect; º e do Artigo 13, &sect; 2º, de

			forma que estes órgãos terão a metade de seus membros; e

		</p>



		<p>

			II. Os recursos de que trata o Artigo 28 seão distribuídos conforme

			a proporção de filiados em dia com suas anuidades.

        </p>
"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 5,
				Titulo = "Lideranças Nacionais",
				Link = "Lideranca",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
	<ul class=""formatted_list"">

		<li class=""highlight""><strong>Presidente Nacional</strong> <a href=""http://www.facebook.com/profile.php?id=100002078219123"" target=""_blank"">Bernardo Santoro Pinto Machado</a> </li>

		<li><strong>Vice-presidente Nacional</strong> <a href=""http://www.facebook.com/carlo.rocha"" target=""_blank"">Carlo Rocha</a> </li>

		<li><strong>Secretário Geral</strong> <a href=""http://www.facebook.com/fkirsch"" target=""_blank"">Felipe Kirsch</a> </li>

		<li><strong>Tesoureiro</strong> <a href=""http://www.facebook.com/Bruno.Paludo"" target=""_blank"">Bruno Paludo</a> </li>

		<li><strong>Relações Públicas</strong> <a href=""http://www.facebook.com/luciana.lnb"" target=""_blank"">Luciana Lopes Nominato Braga</a> </li>

		<li><strong>Captação de Recursos</strong> <a href=""http://www.facebook.com/fkirsch"" target=""_blank"">Felipe Kirsch</a> </li>

		<li><strong>Comunicação</strong> <a href=""http://www.facebook.com/odilon.candido"" target=""_blank"">Odilon Candido</a> </li>

		<li><strong>Marketing</strong> <a href=""http://www.facebook.com/profile.php?id=800879729"" target=""_blank"">André Rufino</a> </li>

		<li><strong>Corregedora</strong> <a href=""http://www.facebook.com/luciana.lnb"" target=""_blank"">Luciana Lopes Nominato Braga</a> </li>

	</ul>

	<div style=""float: left; padding-right: 15px"">

		<h2>

			Comite Julgador</h2>

		<ul class=""formatted_list"" style=""margin: 0px;"">

			<li><a href=""http://www.facebook.com/caiomagnolc"" target=""_blank"">Caio Magno Lima Campos</a></li>

			<li><a href=""http://www.facebook.com/chiocca"" target=""_blank"">Fernando Fiori Chiocca</a></li>

			<li><a href=""http://www.facebook.com/filipeceleti"" target=""_blank"">Filipe Rangel Celeti</a></li>

			<li><a href=""http://www.facebook.com/profile.php?id=100001335191421&ref=ts"" target=""_blank"">Pedro Henrique Ferreira González</a></li>

			<li><a href=""http://www.facebook.com/rchiocca"" target=""_blank"">Roberto Fiori Chiocca</a></li>

		</ul>

	</div>

	<div style=""float: left; padding-right: 15px"">

		<h2>

			Comite Fiscal</h2>

		<ul class=""formatted_list"" style=""margin: 0px;"">

			<li><a href=""http://www.facebook.com/profile.php?id=100001878387467"" target=""_blank"">Geraldo Boz Junior</a></li>

			<li><a href=""http://www.facebook.com/heliob"" target=""_blank"">Hélio Marcos Coutinho Beltrão</a></li>

			<li><a href=""http://www.facebook.com/profile.php?id=100000921473730"" target=""_blank"">Thiago Pinheiro de Souza</a></li>

		</ul>

	</div>

	<div style=""float: left"">

		<h2>

			Comite Executivo</h2>

		<ul class=""formatted_list"" style=""margin: 0px;"">

			<li><a href=""http://www.facebook.com/profile.php?id=800879729"" target=""_blank"">André Rufino</a></li>

			<li><a href=""http://www.facebook.com/brunobca"" target=""_blank"">Bruno Aguiar</a></li>

			<li><a href=""http://www.facebook.com/Bruno.Paludo"" target=""_blank"">Bruno Paludo</a></li>

			<li><a href=""http://www.facebook.com/fcastanhola"" target=""_blank"">Fabiano Marques</a></li>

			<li><a href=""http://www.facebook.com/fkirsch"" target=""_blank"">Felipe Kirsch</a></li>

			<li><a href=""http://www.facebook.com/profile.php?id=1663780584"" target=""_blank"">Guilherme Inojosa Fragoso Cavalcanti</a></li>

			<li><a href=""http://www.facebook.com/max.salles"" target=""_blank"">Herond Salles</a></li>

			<li>Itamar Oliveira</li>

			<li><a href=""http://www.facebook.com/felipe.kaio"" target=""_blank"">Kaio Felipe Santos</a></li>

			<li><a href=""http://www.facebook.com/luciana.lnb"" target=""_blank"">Luciana Lopes Nominato Braga</a></li>

			<li><a href=""http://www.facebook.com/MujoGT"" target=""_blank"">Ney Fonseca</a></li>

			<li><a href=""http://www.facebook.com/sidneisantana"" target=""_blank"">Sidnei Santana</a></li>

			<li><a href=""http://www.facebook.com/profile.php?id=100001114750010"" target=""_blank"">Willian Adamczyk</a></li>

		</ul>

	</div>
"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 6,
				Titulo = "Prestação de Contas",
				Link = "Contas",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
		<iframe id=""ifr_contas"" style=""width: 100%; height: 752px;"" src=""https://spreadsheets.google.com/pub?key=0AgpZiPcMXN9wdExCSVBYRld1N2VQN3JMNUNiU2NOQ3c&hl=en&single=true&gid=0&output=html""></iframe>
"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 7,
				Titulo = "Direitos Individuais",
				Link = "Direitos",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
         <div id=""index"">

            <h1>Índice</h1>



            <ol>

			    <li><a href=""#LiberdadeEResponsabilidade"">Liberdade e responsabilidade</a></li>

			    <li><a href=""#Crime"">Crime</a></li>

			    <li><a href=""#CrimesSemVitima"">Crimes sem vítima</a></li>

			    <li><a href=""#GuerraContraAsDrogas"">Guerra contra as drogas</a></li>

                <li><a href=""#ODireitodepossuireportararmas"">O Direito de possuir e portar armas</a></li>

                <li><a href=""#ProtecaoAosAcusadosCriminalmente"">Proteção aos acusados criminalmente</a></li>

                <li><a href=""#JusticaParaOIndividuo"">Justiça para o indivíduo</a></li>

                <li><a href=""#Juris"">Júris</a></li>

                <li><a href=""#SoberaniaIndividual"">Soberania Individual</a></li>

                <li><a href=""#GovernoESaudeMental"">Governo e Saúde Mental</a></li>

                <li><a href=""#LiberdadeDeComunicacao"">Liberdade de comunicação</a></li>

                <li><a href=""#LiberdadeDeReligiao"">Liberdade de Religião</a></li>

                <li><a href=""#ODireitoDePropriedade"">O Direito de Propriedade</a></li>

                <li><a href=""#ODireitoDePrivacidade"">O Direito de Privacidade</a></li>

                <li><a href=""#AlistamentoEAsForcasArmadas"">Alistamento e as Forças Armadas</a></li>

                <li><a href=""#Imigracao"">Imigração</a></li>

                <li><a href=""#DireitosDasMulheresEAborto"">Direitos das Mulheres e Aborto</a></li>

                <li><a href=""#FamiliasECriancas"">Famílias e Crianças</a></li>

                <li><a href=""#DireitosSexuais"">Direitos sexuais</a></li>

                <li><a href=""#DireitosDosIndios"">Direitos dos Índios</a></li>

            </ol>



            <h1>Ideias</h1>



            <ul>

			    <li><a href=""/Liber/Direitos"">Direitos Individuais</a></li>

			    <li><a href=""/Liber/Economia"">Comércio e Economia</a></li>

			    <li><a href=""/Liber/Domestico"">Assuntos Domésticos</a></li>

			    <li><a href=""/Liber/Exterior"">Relações Exteriores</a></li>

			    

            </ul>

        </div>



        <p>

            Não existe conflito entre a ordem pública e os direitos individuais. Ambos os conceitos são baseados no mesmo princípio fundamental: que nenhum indivíduo, grupo ou governo pode iniciar agressão contra qualquer outro indivíduo, grupo ou governo.</p>



        <h2><a name=""LiberdadeEResponsabilidade"">1. Liberdade e responsabilidade</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> A responsabilidade pessoal é desencorajada pelo governo quando nega aos indivíduos a oportunidade de exercê-la. De fato, a negação da liberdade promove a irresponsabilidade.</p>



        <p>

            <strong>O princípio:</strong> Os indivíduos devem ser livres para fazerem suas próprias escolhas, e devem aceitar a responsabilidade pelas consequências das mesmas. Para que os indivíduos possam fazer suas escolhas pessoais na própria vida, devem aceitar que esse direito deve ser estendido a outros individuos em suas respectivas vidas. Nossa defesa de tal direito não significa que necessariamente aprovamos ou desaprovamos essas escolhas. Acreditamos que as pessoas devem aceitar a responsabilidade individual pelas conseqüências de suas ações.</p>



        <p>

            <strong>Soluções:</strong> Políticas libertárias promoverão uma sociedade onde as pessoas serão livres para fazer suas próprias decisões e aprender com elas. Revogação de todas as leis que presumem que o Governo sabe melhor que o indivíduo como viver sua própria vida. Encorajar a disseminação de informações pelo setor privado para ajudar os consumidores a fazerem decisões informadas sobre produtos e serviços. Aplicação de leis contra fraude e falsificação.</p>



        <h2><a name=""Crime"">2. Crime</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O alto índice de crimes violentos - e a inabilidade demonstrada pelo Governo de lidar com o problema - ameaça a vida, felicidade e pertences dos brasileiros. Ao mesmo tempo, violações dos direitos por parte do Governo debilitam o senso de justiça das pessoas em relação ao crime. Leis sobre crimes sem vítimas violam os direitos individuais e também aumentam as incidências de crimes propriamente ditos.</p>



        <p>

            <strong>O princípio:</strong> A única função justificada do Governo é proteger as vidas, direitos e propriedade dos cidadãos.</p>



        <p>

            <strong>Soluções:</strong> O modo apropriado para reprimir o crime é através da aplicação constante e imparcial de leis que protegem os direitos individuais. Apoiamos serviços privados de proteção e grupos comunitários e voluntários de combate ao crime, desde que tais serviços não sejam compulsórios. Luta pelo fim de leis de &quot;crimes de ódio&quot;, que punem pessoas pelos seus pensamentos e discursos, distraem dos crimes reais e promovem ressentimento, dando a alguns indivíduos status especial sob a lei. Leis sobre crimes sem vítimas devem ser revogadas. Apoiamos mudanças institucionais, consistentes com o respeito total aos direitos do acusado, as quais permitiriam vítimas a iniciar ações judiciais em caso de lesão ou ofensa.</p>



        <h2><a name=""CrimesSemVitima"">3. Crimes sem vítima</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> Atividades que afetam apenas o autor e mais ninguém tem sido criminalizadas pelo governo por meio da codificação na lei de uma moralidade particular.</p>



        <p>

            <strong>O princípio:</strong> Somente ações que infringem direitos ou danificam a propriedade de outros podem ser tratadas como crimes.</p>



        <p>

            <strong>Soluções:</strong> Defesa da revogação de todas as leis federais, estaduais e locais que criam &quot;crimes sem vítimas?.</p>



        <p>

            Em particular, apoiamos:

        </p>



        <p>

            a) Revogação de todas as leis que proíbam a produção, venda, posse, ou uso de drogas, e de todas as requisições de prescrição médica para a compra de vitaminas, drogas, e substâncias similares; a revogação de todas as leis restringindo ou proibindo o uso ou venda de álcool, requerendo sinais e tarjas de avisos sobre saúde, fazendo garçons ou anfitriões responsáveis pelo comportamento de clientes e convidados, fazendo empresas de bebidas alcoólicas responsáveis por doenças e deficiências de recém-nascidos, e fazendo casas de jogos responsáveis pelas perdas de jogadores intoxicados; a revogação de todas as leis ou políticas autorizando a parada de motoristas sem causa provável para o teste de álcool ou uso de drogas; a revogação de todas as leis que proíbam relações sexuais em consenso, incluindo prostituição e lenocínio, e o fim da opressão estatal de homossexuais homens e mulheres, e que sejam respeitados todos seus direitos como indivíduos; a revogação de todas as leis regulando ou proibindo a posse, uso, venda, produção, ou distribuição de material de sexo explícito, independente de seu &quot;valor social&quot; ou conformidade com os &quot;padrões da comunidade&quot;, revogação de todas as leis que proíbam a comercialização de armas, bem como que restrinjam seu porte e posse;

        </p>



        <p>

            b) Revogação de todas as leis regulando ou proibindo o jogo;

        </p>



        <p>

        c) Revogação de todos os estatutos que criminalizam pessoas ou empresas que trabalham com jogos de azar ou comércio de material explícito, o que se iguala a punir comportamento pacífico - incluindo também o comércio de material de sexo explícito;</p>



        <p>

        d) Revogação de todas as leis interferindo no direito de cometer suicídio e auxílio ao suicídio, infringindo o direito de um indivíduo sobre sua própria vida, com remissão de pena para os atualmente encarcerados ou condenados por esses &quot;crimes&quot;; e </p>

        <p>e) Revogação de todas as leis interferindo no direito da família de optar pelo desligamento ou não de aparelhos que mantenham artificialmente a vida de indivíduos em estado de morte cerebral. </p>

        <h2><a name=""GuerraContraAsDrogas"">4. Guerra contra as drogas</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O sofrimento que o abuso de certas drogas traz é deplorável; entretanto, a proibição de drogas causa mais danos que as próprias drogas. A chamada &quot;guerra contra as drogas&quot; é na realidade uma guerra contra o povo brasileiro. A guerra contra as drogas é uma grave ameaça à liberdade individual, à ordem pública, e à paz mundial.</p>



        <p>

            <strong>O princípio:</strong> Os indivíduos devem ter o direito de usar drogas, seja por propósito medicinal ou recreativo, sem medo de represália legal, e devem ser legalmente responsáveis pelas conseqüências de suas ações se elas violarem os direitos de outros.</p>



        <p>

            <strong>Soluções:</strong> O envolvimento social dos indivíduos é essencial para resolver o problema de mau uso e abuso das substâncias. Educação popular e grupos de assistência são abordagens melhores que a proibição, e apoiamos as atividades de organizações privadas como a melhor forma de avançar na questão. Revogação de todas as leis estabelecendo penalidades civis e criminais pelo uso de drogas, legalizando o mesmo.</p>

        <h2><a name=""ODireitodepossuireportararmas"" id=""ODireitodepossuireportararmas"">5. O Direito de possuir e portar armas</a></h2>

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        <p> <strong>A questão:</strong> Todos os níveis de governo freqüentemente violam os direitos dos cidadãos a sua autodefesa com leis que restringem, limitam ou simplesmente proíbem a propriedade e uso de armas de fogo. Essas &quot;leis de desarmamento&quot; são sempre justificadas pela falsa premissa de que elas levarão a uma redução no nível de violência em nossa sociedade.</p>

        <p> <strong>O princípio:</strong> Nós somos a favor do direito de possuir e portar armas, em respeito ao direito de autodefesa do cidadão contra criminosos e contra o Governo.</p>

        <p> <strong>Soluções:</strong> Defesa do fim de todo tipo de restrição, regulamentação para a posse, manufatura, transferência ou venda de armas de fogo ou munição. Rejeitar todas as leis que exijam o registro de armas de fogo ou munição. Fim de todas as leis de controle de armas. Fim dos departamentos, secretarias ou outras entidades criadas com o específico fim de controlar o uso de armas de fogo. Condenar todo e qualquer esforço do Governo para banir ou restringir o uso de spray lacrimogêneo, ou quaisquer outros dispositivos de autodefesa.</p>

        <h2><a name=""ProtecaoAosAcusadosCriminalmente"">6. Proteção aos acusados criminalmente</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> Políticas de punição instantânea retiram dos acusados importantes defesas contra abuso de poder governamental: júris e o processo judicial.</p>



        <p>

            <strong>O princípio:</strong> Até que as pessoas sejam provadas culpadas, todos seus direitos individuais devem ser respeitados. Somos contrários a qualquer concepção de que grupos de indivíduos são por natureza cidadãos de segunda-classe e a qualquer alegação que a polícia possui possui competência para reconhecer pessoas que precisam de punição. Opomos-nos à redução de salvaguardas constitucionais nos direitos dos acusados criminalmente.</p>



        <p>

            <strong>Soluções:</strong> Abolir a permissão do Governo de confiscar propriedades antes dos procedimentos civis ou criminais adequados. Restituição total para todas as perdas sofridas por pessoas presas, indiciadas, julgadas, detidas ou de qualquer outra forma prejudicadas no curso dos procedimentos criminais contra elas, quando não resultarm em sua condenação. Quando forem considerados responsáveis, policiais e outros agentes do governo devem arcar com o custo dessa restituição. A polícia deve ser proibida de usar força excessiva sobre o desordeiro ou acusado criminalmente, lançando mão do que eles consideram ser punição instantânea nas ruas, ou usar de prisão preventiva, salvo em flagrante delito. Estimulo a outras formas de restrição cautelar diversas da prisão preventiva O sistema judicial deve ser reformado para permitir que réus em processos criminais e ambas as partes em processos civis possam apresentar um número razoável de recursos aos juízes, sendo o atual número excessivo.</p>



        <h2><a name=""JusticaParaOIndividuo"">7. Justiça para o indivíduo</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O sistema atual de leis criminais é baseado quase somente na punição e com pouco enfoque na vítima. A vítima, em regra, é duplamente penalizada: no momento em que é lesada pelo criminoso e quando o Governo o obriga a custear as despesas daquele através de tributos. O sistema de julgamento civil é fortemente controlado por um Estado ineficiente.</p>



        <p>

            <strong>O princípio:</strong> O propósito de um sistema de justiça é prover a restituição a quem sofreu a perda à custa daqueles que causaram a perda. Nos casos de crimes violentos, um propósito adicional é defender a sociedade da ameaça contínua da violência.</p>



        <p>

            <strong>Soluções:</strong> Apoiamos:

        </p>



        <p>

            a) a maior restituição possível para a vítima à custa do criminoso ou malfeitor. Priorizar o ressarcimento da vítima com pesada indenização contra o criminoso, em detrimento da prisão do mesmo, em casos de crimes não-violentos. Conjugar o ressarcimento da vítima com a prisão do criminoso em casos de crimes violentos;</p>



        <p>

            b) afirmar o direito da vítima de perdoar o criminoso ou malfeitor, impedindo, contudo, ameaças à vítima para esse propósito; e

        </p>



        <p>

        c) estimulo a autocomposição e a heterocomposição via arbitragem.</p>



        <h2><a name=""Juris"">8. Júris</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O direito de ser julgado por um júri popular é uma essencial para que os direitos individuais não sejam infringidos pelo Governo.</p>



        <p>

            <strong>O Princípio:</strong> Júris populares devem ser compostos de voluntários, não de jurados forçados. Ademais, o direito dos jurados de julgar não apenas conforme os fatos, mas de julgar a própria lei deve ser reconhecido e encorajado.</p>



        <p>

            <strong>Soluções:</strong> Em todos os casos no qual o Estado é parte, o juiz deve ser obrigado a informar os jurados de sua prerrogativa de julgar a lei, assim como os fatos, e de absolver um réu em processo criminal ou julgar em desfavor do Estado em processos cíveis, sempre que considerarem a lei injusta ou opressiva.</p>



        <h2><a name=""SoberaniaIndividual"">9. Soberania Individual</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O Governo tem se colocado em uma posição de superioridade perante seus cidadãos, negando seus direitos sob o argumento do &quot;interesse público&quot;, tornando-se assim a principal ameaça aos nossos direitos, em vez de seu principal protetor.</p>



        <p>

            <strong>Princípio:</strong> A única situação de uso legítimo de força é na defesa dos direitos individuais - vida, liberdade, e a propriedade legalmente adquirida - contra agressão, seja por força ou por fraude. Esse direito é inerente ao indivíduo, o qual - com seu consentimento - pode ser ajudado por qualquer outro indivíduo ou grupo. O direito a se defender se estende à defesa contra atos agressivos do próprio Governo.</p>



        <p>

            <strong>Soluções:</strong> O Governo deve se ater ao seu papel de protetor de direitos, e ser responsável por suas ações contra indivíduos. Defesa do fim imediato de todos os institutos jurídicos que concedem primazia do &quot;interesse público&quot; civil sobre o interesse privado. Governantes eleitos e burocratas devem ser igualmente responsáveis por tais ações, com prioridade em responsabilizar civilmente governantes e burocratas pelos danos causados pelo Governo contra os cidadãos.</p>



        <h2><a name=""GovernoESaudeMental"">10. Governo e Saúde Mental</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> Indivíduos são medicados à força ou tem sua medicação negada, baseado não na necessidade médica, mas em um programa social imposto pelo Governo.</p>



        <p>

            <strong>O Princípio:</strong> O uso ou abstenção de medicação deve ser voluntária.

        </p>



        <p>

            <strong>Soluções:</strong> Oposição ao tratamento forçado de qualquer pessoa ou internação forçada em instituição de tratamento mental. Oposição ao tratamento forçado dos idosos, das pessoas com lesões na cabeça ou daqueles com capacidade reduzida. Oposição à invasão do lar e da privacidade das pessoas por agentes de saúde ou quaisquer outros agentes do Governo. Defesa do fim do gasto de dinheiro dos pagadores de tributos para qualquer programa de tratamento psiquiátrico, psicológico ou de pesquisa de comportamento.</p>



        <h2><a name=""LiberdadeDeComunicacao"">11. Liberdade de comunicação</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> A liberdade de expressão decorre diretamente do direito de autopropriedade do indivíduo sobre seu corpo e pensamento. Somos contra qualquer cerceamento da liberdade de expressão, constantemente atacada pelo Governo.

        </p>



        <p>

            <strong>O Princípio:</strong> Defendemos os direitos individuais à liberdade irrestrita de expressão, liberdade de imprensa e o direito dos indivíduos de discordar do próprio Governo. Reconhecemos que a liberdade total de expressão é possível apenas como parte de um sistema de direitos totais de propriedade. A liberdade de usar sua própria voz; a liberdade de alugar um salão de convenções; a liberdade de ser proprietário de um jornal ou de uma estação de televisão aberto ou cabo de transmissão; a liberdade de hospedar e publicar informação na Internet; a liberdade de agitar ou de queimar sua própria bandeira; e liberdades similares baseadas na propriedade são precisamente o que constitui a liberdade de comunicação. Ao mesmo tempo, reconhecemos que a liberdade de comunicação não se estende ao uso de propriedades de outrem para promover ideias sem o consentimento de seus respectivos donos.

        </p>



        <p>

        <strong>Soluções:</strong> Deixar ao critério do livre-mercado a propriedade de frequências de ondas. Somos contra a posse estatal, subsídio ou financiamento público de qualquer organização de comunicação. A remoção de todos esses regulamentos e práticas de toda a mídia de comunicação abre caminho para a diversidade e inovação. Revogação de qualquer lei que promova censura, regulação ou controle de mídias de comunicação, tais como:</p>

        <p>a) Equipamentos de recepção e armazenamento, tais como gravadores de fita digitais e dispositivos de radar, e a fabricação de terminais de vídeo por companhias telefônicas;</p>

        <p>b) Quadros de avisos eletrônicos, redes de comunicação, e outras midas interativas;</p>

        <p>c) Jornais eletrônicos, classificados eletrônicos, arquivos de bibliotecas, sites da Internet e qualquer outra nova mídia de informação, que merecem total liberdade; ou</p>

        <p>d) Comunicação e propaganda comercial.</p>

        <p>          Fim de restrição da linguagem em todas as escolas que recebam verbas públicas. Linguagem que for considerada ofensiva a certos grupos não deve ser causa para ação legal.</p>

        <p>          Fim da censura prévia via ordens judiciais que limitam a cobertura e divulgação jornalística de crimes ou procedimentos criminais - o direito de publicar e transmitir não deve ser cerceado meramente pela conveniência do sistema judicial. Deploramos quaisquer esforços no sentido de impor controle de opiniões à mídia, seja pelo uso de leis antitruste, seja por qualquer outra ação governamental que vise eliminar o &quot;preconceito&quot; da mídia. Rechaçamos controle estatal sobre pornografia.</p>

        <p>Extinção de órgãos governamentais que regulam os meios de comunicação e o conteúdo jornalístico.</p>

        <p>Defesa da responsabilidade civil e penal a posteriori do conteúdo divulgado pela mídia e por seus representantes. </p>

        <h2><a name=""LiberdadeDeReligiao"">12. Liberdade de Religião</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O Governo rotineiramente invade os direitos de privacidade pessoal baseado somente nas crenças religiosas dos indivíduos.</p>



        <p>

            <strong>O Princípio:</strong> Defendemos o direito dos indivíduos de participar (ou se abster de participar) de qualquer atividade religiosa que não viole os direitos de outras pessoas.</p>



        <p>

             <strong>A Solução:</strong> Perfeita separação entre Igreja e Estado. Fim de quaisquer ações do Governo que favoreçam ou prejudiquem qualquer religião.</p>



        <h2><a name=""ODireitoDePropriedade"">13. O Direito de Propriedade</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O direito de propriedade privada tem sido constantemente atacado pelo Estado, distorcendo seu conceito e relativizando seu alcance, especialmente em nome do interesse público, bem com também em nome de valores estéticos, risco, padrões morais, estimativas de custo-benefício, promoção ou restrição de crescimento econômico. O Estado rotineiramente interfere na operação de negócios privados. A taxação de imóveis privados, na prática, torna o Estado possuidor de todas as terras, forçando os indivíduos a pagar pelo uso de suas próprias casas e pontos comerciais.

        </p>



        <p>

            <strong>O Princípio:</strong> Todos os direitos são intrinsecamente ligados ao direito de propriedade. Tais direitos como a liberdade de não servir a alguém involuntariamente bem como a liberdade de expressão e liberdade de imprensa são baseados na auto-propriedade. O direito de propriedade é um axioma inerente a existência do ser humano, em especial a auto-propriedade de seu corpo e pensamento. Nossos corpos são nossas propriedades tanto quanto o são as terras e objetos materiais legalmente adquiridos. Aquele que possui uma propriedade tem total direito de controlar, usar, dispor dela - ou de qualquer maneira usufruir de sua propriedade sem interferência, até que e a não ser que, o exercício desse controle infrinja direitos válidos de outras pessoas.

        </p>



        <p>

            <strong>Soluções:</strong> Exigir o fim da taxação de propriedades imobiliárias privadas. A propriedade tem sido tomada de seus verdadeiros donos pelo Governo ou por ação privada em violação dos direitos individuais; deste modo, apoiamos sua restituição a seus legítimos donos. Revogação de quaisquer leis que relativizem o direito de propriedade, bem como regulem o  uso, fruição e disposição de propriedades privadas. Revogação das leis que declarem preponderância do ?interesse público? sobre o interesse privado, principalmente quando restringem o uso da propriedade privada em nome de valores estéticos, risco, padrões morais, estimativas de custo-benefício, promoção ou restrição de crescimento econômico.

        </p>



        <h2><a name=""ODireitoDePrivacidade"">14. O Direito de Privacidade</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> As proteções à privacidade têm sido lentamente desgastadas ao longo dos anos. O número do CPF se tornou praticamente um identificador universal, facilitando enormemente os casos de roubo de identidade. O Governo pode acessar contas bancárias, bilhetes de viagens aéreas e conhecer todos os hábitos de consumo de cidadãos respeitadores da lei, apenas com a fraca justificativa de que é preciso evitar crimes ou sonegações.

        </p>



        <p>

            <strong>O Princípio:</strong> O direito do indivíduo à privacidade, propriedade e o direito de falar ou não falar não deve ser infringido pelo Governo. O Governo não deve usar meios eletrônicos ou de outra natureza para espionar as ações de um indivíduo ou sua propriedade sem o consentimento do proprietário ou ocupante. Correspondências, transações bancárias ou financeiras, registros médicos, comunicações com advogados, registros de emprego outros tantos não devem estar abertos para o conhecimento do Governo sem o consentimento de todas as partes envolvidas nestas ações.</p>

        <p>Arranjos contratuais privados, incluindo contratos de trabalho, devem ser fundados no consentimento mútuo e aceitação em uma sociedade que promove a liberdade de associação. Proibição de qualquer forma de investigação da vida pregressa do indivíduo pelo Governo para fins civis, bem como de regulamentações que forcem empresas prestadoras de serviço ao Governo a impor tais investigações.</p>

        <p>

            <strong>Soluções:</strong> Apoio às proteções contra a arbitrariedade investigatória ou policial do Governo e oposição ao uso de mandados de busca para examinar ou apreender materiais pertencentes a pessoas inocentes. Fim de restrições e regulamentações ao desenvolvimento privado, venda e uso de tecnologia de encriptação. Fim de qualquer requerimento de abertura ou violação dos métodos de encriptação ou chaves, e qualquer outro requerimento forçando o uso de dispositivos ou protocolos de comunicação especificados pelo Governo. Fim da classificação governamental da pesquisa civil sobre os métodos de encriptação. Rejeitar propostas de aplicação de um cartão de identidade universal. Defesa do direito do cidadão em não cooperar com o censo nacional.</p>



        <h2><a name=""AlistamentoEAsForcasArmadas"">15. Alistamento e as Forças Armadas</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O Governo promove serviço militar obrigatório, um programa de trabalho compulsório e coercitivo para os jovens.</p>



        <p>

            <strong>O Princípio:</strong> Forçar indivíduos a servir as Forças Armadas não é nada menos que escravidão.

        </p>



        <p>

            <strong>Soluções:</strong> Fim de qualquer tentativa de registro dos indivíduos para fins de alistamento ou conscrição e qualquer invasão da privacidade de alguém por meio de registros escolares, de habilitação para dirigir e outros, para esse mesmo fim. Abolição de qualquer tipo de serviço de seleção de recrutas. Destruição de todos os arquivos em mídia magnética, óptica, mista, ou impressa que contenham informações que possam ser usadas para selecionar pessoas ao alistamento. Revogação de leis que punem a deserção. Os membros das Forças Armadas devem ter o direito de deixar seu trabalho como qualquer outra pessoa. Cessação de guerras imperialistas promovida pela nossa nação. Fim da exclusão das Forças Armadas por conduta homossexual. Reconhecimento dos direitos civis dos membros das Forças Armadas. Promover o moral, a dignidade e o senso de justiça entre os militares.

        </p>



        <h2><a name=""Imigracao"">16. Imigração</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

             <strong>A questão:</strong> Estrangeiros que fogem da opressão de seus países e buscam melhorar de vida tentam migrar e viver no Brasil.

        </p>



        <p>

            <strong>O Princípio:</strong> Sustentamos que os direitos humanos não devem ser negados ou restringidos com base na nacionalidade. Estrangeiros sem documentação não devem ser impedidos de exercer seu direito fundamental de trabalhar e de ir e vir sem serem importunados. Ademais, a imigração não deve ser restringida por motivos de raça, religião, crença política, idade ou preferência sexual. É injusta a promoção de incentivos para retornarem a seus países.</p>



        <p>

            <strong>Soluções:</strong> Acabar com a deportação de cidadãos pelo Governo Federal com base na falta de documentação para estar no país. Rejeitar todas as medidas que punem empregadores que contratem trabalhadores sem documentos de imigração, pois tais medidas oprimem o livre empreendimento, hostilizam os trabalhadores e sistematicamente desencorajam a contratação de imigrantes, legais ou não. Eliminar todas as restrições à imigração, e anistiar totalmente aqueles que entraram no país ilegalmente.</p>



        <h2><a name=""DireitosDasMulheresEAborto"">17. Direitos das Mulheres e Aborto</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> Reconhecemos que o aborto é um tema muito sensível e que as pessoas, incluindo os libertários, podem ter opiniões de boa-fé nos dois lados da questão. Acreditamos que o Governo não deve interferir nesta questão. Somos contra abortos pagos ou ordenados pelo Governo. É extremamente duro forçar alguém que acredita que o aborto é assassinato a pagar pelo aborto de outras pessoas por meio de impostos. Mulheres têm recebido favorecimento estatal através de cotas e outros mecanismos.</p>



        <p>

            <strong>O Princípio:</strong> O princípio da não-iniciação da agressão contra outros indivíduos é basilar na doutrina libertária. Como nem mesmo a ciência pode afirmar se o nascituro já é um indivíduo autônomo, temos opiniões de boa-fé dos dois lados.

        </p>



        <p>

            <strong>Soluções:</strong> Revogar todas as leis que promovam a tirania por meio de discriminação reversa.</p>



        <h2><a name=""FamiliasECriancas"">18. Famílias e Crianças</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O envolvimento do Governo nas responsabilidades dos pais tem enfraquecido as famílias e substituído os valores familiares pelos valores ensinados pelo Governo.

        </p>



        <p>

            <strong>O Princípio:</strong> Famílias e lares são instituições privadas, que devem ser livres da intrusão ou interferência por parte do Governo. Pais ou outros guardiões têm o direito de educar seus filhos de acordo com seus valores e crenças, sem interferência do Governo - a não ser que estes filhos estejam sendo molestados física, sexual ou psicologicamente. Devido a esses direitos dos pais, um jovem pode não ser capaz de exercer todos os seus direitos dentro do contexto familiar. Entretanto, os jovens têm o direito de reivindicar sua emancipação assumindo a administração e a proteção de seus próprios direitos, encerrando a dependência em relação a seus pais ou guardiões, e assumindo todas as responsabilidades da vida adulta. Uma criança, um jovem, é um ser humano e, como tal, deve ser tratado com Justiça. Os pais não têm o direito de abandonar ou pôr em perigo seus filhos de maneira inconseqüente. Sempre que os pais não puderem ou não quiserem criar seus filhos, eles devem encontrar outra pessoa para assumir a guarda deles.

        </p>



        <p>

            <strong>Soluções:</strong> Reconhecemos que determinar quando o abuso infantil ocorre é difícil. Apenas as cortes locais devem ter o poder de remover uma criança de seu lar, com o consentimento da comunidade. Essa medida não é a única a ser tomada quando uma criança estiver em perigo físico imediato. Abolir todas as leis que impedem esses processos, notadamente aquelas que restringem os serviços privados de adoção. Revogar as leis que impedem a criança de exercer seu direito de trabalhar ou aprender. Fim da prática de se deter crianças e jovens que não foram acusados de nenhum crime. Extinção dos estatutos que impedem que as crianças e jovens tenham o mesmo tratamento e proteções processuais dos adultos.

        </p>



        <h2><a name=""DireitosSexuais"">19. Direitos sexuais</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A questão:</strong> O Governo presumiu que deve decidir sobre o que é ou não aceitável em práticas sexuais dentro dos relacionamentos pessoais, impondo um código particular de moral e de valores morais, retirando a escolha pessoal nesses assuntos.</p>



        <p>

            <strong>O Princípio:</strong> Adultos têm o direito a fazer

            sua escolha privativa em atividades

            sexuais consensuais.

        </p>



        <p>

            <strong>Soluções:</strong> Abolir todas as tentativas do Governo de ditar, proibir, controlar ou encorajar qualquer estilo particular de vida, de união de pessoas ou qualquer relação contratual. Repelir leis e políticas existentes que visam condenar, afirmar, encorajar ou negar estilos de vida sexual, ou quaisquer conjuntos de atitudes com relação a esses estilos de vida.</p>



        <h2><a name=""DireitosDosIndios"">20. Direitos dos Índios</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>O Tema:</strong> Os direitos dos índios têm sido usurpados ao longo dos anos.

        </p>



        <p>

            <strong>O Princípio:</strong> Os indivíduos devem ser livres para decidir e escolher

            sua própria cidadania, e as tribos devem ser livres para escolher

            o nível de autonomia que desejam.

        </p>



        <p>

            <strong>Soluções:</strong> Os índios devem ter seus direitos de propriedade restaurados, inclusive direitos de livre trânsito, acesso, caça e pesca. Os órgãos regulamentadores dos índios devem ser abolidos, deixando que as próprias tribos e seus membros determinem seu sistema de governo. Devem ser entabuladas negociações para solucionar todas as questões entre as tribos e o Governo.</p>


"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 8,
				Titulo = "Comércio e Economia",
				Link = "Economia",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
	    <div id=""index"">

    	    <h1>Índice</h1>



            <ol>

			    <li><a href=""#AEconomia"">A Economia</a></li>

			    <li><a href=""#Taxacao"">Taxação</a></li>

			    <li><a href=""#InflacaoEDepressao"">Inflação e depressão</a></li>

                <li><a href=""#FinancasEInvestimentoDeCapital"">Finanças e investimentos de capital</a></li>

                <li><a href=""#DividaDoGoverno"">Dívidas do governo</a></li>

                <li><a href=""#Monopolios"">Monopólios</a></li>

                <li><a href=""#Subsidios"">Subsídios</a></li>

                <li><a href=""#BarreirasDeComercio"">Barreiras de comércio</a></li>

                <li><a href=""#ServicosDeUtilidadePublica"">Serviços de utilidade pública</a></li>

                <li><a href=""#SindicatosENegociacoesColetivas"">Sindicatos e negociações coletivas</a></li>

            </ol>

    

		    <h1>Ideias</h1>



		    <ul>

			    <li><a href=""/Liber/Direitos"">Direitos Individuais</a></li>

			    <li><a href=""/Liber/Economia"">Comércio e Economia</a></li>

			    <li><a href=""/Liber/Domestico"">Assuntos Domésticos</a></li>

			    <li><a href=""/Liber/Exterior"">Relações Exteriores</a></li>

			    

		    </ul>

	    </div>



        <p>

            Nós acreditamos que cada pessoa tem o direito de oferecer bens e serviços aos outros no livre mercado. Portanto, nos opomos a todas as intervenções do governo na área da economia. O único papel dos governos existentes na área econômica é o de proteger os direitos de propriedade, resolver disputar judiciais e prover uma estrutura legal na qual as trocas voluntárias sejam protegidas.</p>

        

        <p>

        Esforço no sentido de redistribuir riquezas ou de controlar pela força o comércio são intoleráveis. A manipulação governamental da economia cria uma classe privilegiada - aqueles que têm acesso ao dinheiro dos impostos - e uma classe explorada - aqueles que pagam os impostos.</p>

        

        <p>

        Nós acreditamos que todos os indivíduos têm o direito de dispor dos frutos do próprio trabalho como bem entenderem e que o governo não tem direito de tirar-lhes essa riqueza. Nós nos opomos à caridade governamental, tais como programas assistenciais e subsídios, mas aplaudimos veementemente os indivíduos e organizações de caridade que ajudam os necessitados e contribuem em uma grande variedade de causas valorosas através de atividades voluntárias.</p>

        

        <h2><a name=""AEconomia"">1. A economia</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        <strong>A questão:</strong> A intervenção do governo na economia põe em perigo tanto a liberdade individual quanto a prosperidade material de todos os brasileiros.</p>

        

        <p>

        <strong>O princípio:</strong> O livre mercado, que respeita os direitos individuais nas trocas voluntárias com outros indivíduos, deve funcionar sem impedimentos pelo governo. O único papel do governo na área econômica é o de proteger os direitos de propriedade, resolver disputas judiciais e prover uma estrutura legal na qual as trocas voluntárias sejam protegidas.</p>

        

        <p>

        <strong>Soluções:</strong> Para assegurar a liberdade econômica e melhorar o bem estar econômico dos brasileiros, implantaríamos as seguintes políticas:</p>

        

        <p>

            a.) Dramática redução tanto de impostos como de gastos do governo;

        </p>

        

        <p>

            b.) Fim dos déficits no orçamento;

        </p>

        

        <p>

            c.) Fim de políticas monetárias inflacionárias;

        </p>

        

        <p>

            d.) Eliminação de todos os impedimentos governamentais ao livre comércio e;

        </p>

        

        <p>

            e.) Eliminação de todos os controles de salários, preços, aluguéis, lucros, produção e juros.

        </p>

        

        <h2><a name=""Taxacao"">2. Taxação</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        <strong>A questão:</strong> A manipulação governamental da economia cria uma classe privilegiada - aqueles com acesso ao dinheiro dos impostos - e uma classe explorada - aqueles que são pagadores de impostos.</p>

        

        <p>

        <strong>O princípio:</strong> Todas as pessoas têm direito de manter os frutos de seu trabalho. A atividade governamental não deveria incluir a coleta forçada de dinheiro ou bens dos indivíduos em violação de seus direitos individuais. Concordamos com a taxação apenas para sustentar os serviços necessários para a manutenção da propriedade e direitos individuais. Nenhum imposto pode jamais ser justo, simples ou neutro ao livre mercado.</p>

        

        <p>

            <strong>Soluções:</strong> Especificamente: a) apoiar o direito de qualquer indivíduo de contestar o pagamento de impostos com base em fundamentos morais, religiosos, legais ou constitucionais; b) oposição a qualquer taxação da renda de pessoas físicas ou jurídicas, incluindo a impostos sobre ganhos de capital; c) oposição a qualquer aumento nos impostos existentes e à criação de novos impostos; d) apoiar a abolição de todos os impostos; e) apoiar a anistia incondicional de indivíduos que tenham sido condenados ou que são acusados de resistência aos impostos; f) revogar todas as leis que criminalizam o não-pagamento de tributos; g).opor-se à servidão coercitiva feita pelo Estado a empresários que funcionam como coletores de tributos de seus empregados.</p>

        

        <h2><a name=""InflacaoEDepressao"">3. Inflação e Depressão</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> O controle governamental sobre o dinheiro e o sistema bancário é a causa primária da inflação e da depressão econômica.

        </p>

        

        <p>

        <strong>O princípio:</strong> Indivíduos envolvidos em trocas voluntárias devem ser livres para usar como dinheiro qualquer commodity ou item livremente acordado entre as duas partes, tais como moedas de ouro denominadas por suas unidades de peso.</p>

        

        <p>

            <strong>Soluções:</strong> Apoiar a abolição de todas as leis que regulam o uso da moeda e de todas as unidades de conta compulsórias governamentais, assim como a eliminação de toda moeda-fiat governamental e de todas as moedas cunhadas pelo governo. Todas as restrições à cunhagem privada de moedas devem ser abolidas, para que a cunhagem seja aberta à competição no livre mercado. Apoiar um sistema bancário livre, com irrestrita competição entre bancos e instituições de depósito de todos os tipos. A única restrição necessária em relação à inflação monetária é a aplicação consistente da proteção geral contra fraudes aos ramos bancário e de cunhagem de moeda. Abolir o Banco Central e toda e qualquer instituição e/ou intervenção que afete o crédito e o sistema bancário, como o Banco do Brasil, a Caixa Econômica Federal e os Bancos Estaduais. Apoiar a abolição do BNDES e de todas as instituições creditícias federais e estaduais. Para completar a separação entre o sistema bancário e o Estado, defesa de um sistema de tesouro indepentedente, no qual todos os fundos do governo são guardados pelo próprio governo e não depositados em bancos privados. Enquanto não é abolido, o Banco Central, para que a inflação seja contida, deve imediatamente parar de expandir a base monetária. Como medidas provisórias, nós ainda apoiamos: a) a suspensão de todas as restrições a ramificações bancárias; b) a eliminação de todas as leis de usura; c) a remoção de todas as restrições aos juros pagos por depósitos; d) a eliminação das leis que estabelecem requerimentos marginais para a compra e venda de seguros; e) a revogação de todos os outros controles do crédito; f) a abolição do controle do Banco Central sobre as reservas de bancos não-membros e outras instituições de depósito e; g) a suspensão da proibição de depósitos domésticos em moedas estrangeiras.</p>

        

        <h2><a name=""FinancasEInvestimentoDeCapital"">4. Finanças e investimentos de capital</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        <strong>A questão:</strong> A regulação governamental dos mercados de capital inibe o investimento e criam vantagens no mercado para aqueles com acesso a políticos e burocratas, através de isenções de leis contra fraude e quebras de contrato.</p>

        

        <p>

            <strong>O princípio:</strong> O livre mercado deve operar sem os impedimentos da regulação governamental, embora o governo deva punir fraude, roubo e quebras de contrato sem exceções.</p>

        

        <p>

        <strong>Soluções:</strong> Apoiar a abolição de toda regulação dos mercados financeiro e de capitais. O que deve ser punido é o roubo de informações ou brechas de contrato que mantenham informações em segredo. Abolir todas as leis que reprimem as pequenas e arriscadas especulações de capital e todas regulações federais do mercado de commodities. Oposição a quaisquer tentativas de banir ou regular o investimento na bolsa de mercadorias e futuros ou em quaisquer outros instrumentos financeiros que venham a emergir no futuro. Abolir todas as leis baseadas no obscuro conceito do &quot;insider trading&quot;. </p>

        

        <h2><a name=""DividaDoGoverno"">5. Dívidas do governo</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> O débito do governo força os indivíduos a assumirem dívidas em que não escolheram incorrer; distorce os mercados de capital e arruína a economia.</p>

        

        <p>

            <strong>O princípio:</strong> O governo não deve assumir dívidas nem ter posses, pois esses débitos são responsabilidades dos indivíduos e as propriedades foram tiradas deles.</p>

        

        <p>

            <strong>Soluções:</strong> Apoiar uma emenda constituicional requerendo que os governos federal, estaduais e municipais equilibrem suas contas. Efetivamente, uma emenda de equilíbrio de orçamento deve requerer:

        </p>

        

        <p>

            a.) que nem o Congresso nem o Presidente possam ignorar essa regra;

        </p>

        

        <p>

            b.) que todos os itens de fora do orçamento sejam incluídos no orçamento;

        </p>

        

        <p>

            c.) que o orçamento seja equilibrado exclusivamente através do corte de gastos, não por aumento de impostos e;

        </p>

        

        <p>

            d.) que nenhuma exceção deve ser feita para períodos de emergência nacional.

        </p>

        

        <p>

            Governos enfrentando crises fiscais devem sempre pedir a moratória em vez de aumentar impostos. O Banco Central deve ser proibido de adquirir quaisquer seguros adicionais do governo, ajudando assim a eliminar o aspecto inflacionário do déficit.</p>

        

        <h2><a name=""Monopolios"">6. Monopólios</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> Nós identificamos o governo como a causa do monopólio, através da concessão de privilégios legais a grupos de interesses na economia.</p>

        

        <p>

            <strong>O princípio:</strong> Leis anti-truste não evitam monopólios, mas os criam por limitarem a competição. Nós defendemos o direito dos indivíduos de formarem corporações, cooperativas e outros tipos de companhias baseadas em associações voluntárias.</p>

        

        <p>

            <strong>Soluções:</strong> Abolir todos os monopólios coercitivos. Para aboli-los, advogamos uma estrita separação entre os negócios e o Estado. Leis de incorporação não devem incluir garantias de privilégios monopolísticos. Em particular, eliminar os limites especiais na responsabilização de corporações por danos causados em transações contratuais e não contratuais. Oposição a limites estaduais ou federais sobre o tamanho das companhias privadas e sobre o direito das companhias de se fundirem. Oposição a esforços - em nome do ""interesse público"" ou por qualquer outra razão - para expandir o licenceamento federal de corporações com o pretexto de o governo controlar as empresas. Abolir todas as leis anti-truste. Eliminar o CADE e quaisquer outras instituições que visem limitar o tamanho das corporações.</p>

        

        <h2><a name=""Subsidios"">7. Subsídios</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> A competição irrestrita no livre mercado

            é o melhor meio de atingir a prosperidade.

        </p>

        

        <p>

            <strong>O princípio:</strong> Para chegarmos a uma economia livre, na qual o governo não vitimize ninguém para o benefício de terceiros, nós nos opomos a todos os subsídios a empresas, empregados, educação, agricultura, ciência, radiodifusão, artes, esportes ou quaisquer outros interesses especiais. Em particular, condenamos quaisquer esforços de forjar uma aliança entre governo e empresas sob o pretexto de &quot;reindustrialização&quot; ou da &quot;política indústrial&quot;. Alívio ou isenção de taxação ou de qualquer outra intervenção involuntária do governo, no entanto, não deve ser considerada um subsídio.</p>

        

        <p>

            <strong>Soluções:</strong> Abolição do BNDES, a principal agência nacional de subsídio a interesses especiais com empréstimos governamentais. Oposição a quaisquer garantias governamentais a empréstimos privados. Tais garantias transferem recursos para grupos especiais tanto quanto gastos do governo propriamente ditos e, a nível nacional, excedem empréstimos diretos do governo em volume total. Pagadores de impostos não devem nunca sustentar os custos da moratória de empréstimos garantidos pelo governo. Todas as agências nacionais, estaduais e municipais cuja função seja a de segurar empréstimos devem ser abolidas ou privatizadas. Os empréstimos de empreendimentos patrocinados pelo governo, mesmo quando não segurados pelo governo, constituem outra forma de subsídio. Todos esses empreendimentos devem ser abolidos ou totalmente privatizados.</p>

        

        <h2><a name=""BarreirasDeComercio"">8. Barreiras de comércio</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> Tarifas e cotas servem apenas para dispensar tratamento especial a grupos favorecidos e para diminuir o bem estar dos consumidores e de outros indivíduos. Essas medidas também reduzem o alcance dos contratos e o entendimento entre diferentes povos.</p>

        

        <p>

            <strong>O princípio:</strong> Indivíduos comerciando com outros indivíduos em outras nações voluntariamente deve ser a única fonte de regulação dos mercados internacionais. Todas as barreiras protecionistas são desnecessárias e onerosas.</p>

        

        <p>

            <strong>Soluções:</strong> Abolir todas as barreiras comerciais e todos os programas de subsídio às exportações. Essa política deve ser unilateralmente adotada, independentemente das políticas comerciais de outros países.</p>

        

        <h2><a name=""ServicosDeUtilidadePublica"">9. Serviços de utilidade pública</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> O envolvimento do governo na provisão de serviços de utilidade pública enfraquece o livre mercado e limita o desenvolvimento e a disponibilidade de serviços de alta qualidade.</p>

        

        <p>

            <strong>O princípio:</strong> O direito de oferecer no mercado serviços como coleta de lixo, proteção contra incêndios, eletricidade, gás natural, TV, correios, telefone ou água e esgoto não devem ser impedidos pela lei.</p>

        

        <p>

            <strong>Soluções:</strong> Extinção de franquias privilegiadas pelo governo e de monopólios governamentais para esses serviços. Todas as regulações das indústrias que provejam esses serviços devem ser abolidas.</p>

        

        <h2><a name=""SindicatosENegociacoesColetivas"">10. Sindicatos e negociações coletivas</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> A interferência do governo na relação empregador/empregado impôs um peso desnecessário na nossa economia, destruindo os direitos de ambos de assumir contratos no livre mercado.</p>

        

        <p>

            <strong>O princípio:</strong> Apoiamos o direito de pessoas livres voluntariamente estabelecerem ou associarem-se a sindicatos trabalhistas. Um empresário deve ter o direito de reconhecer ou de se recusar a reconhecer um sindicato como o agente de barganha coletiva de alguns ou de todos os seus empregados.</p>

        

        <p>

            <strong>Soluções:</strong> Nos opomos à interferência governamental nas negociações, tais como arbitragem compulsória ou imposição de uma obrigação de negociar. Abolir a CLT e todas as outras leis de direito ao trabalho, que proíbem empregadores de fazerem contratos voluntários com sindicatos. Oposição a todas as ordens governamentais de recondução ao trabalho. Empregados e empresários devem ter o direito de organizar boicotes, se assim escolherem. No entanto, boicotes ou greves não justificam a iniciação de violência contra outros trabalhadores, empresários, aqueles que não desejem aderir à greve e outras pessoas pacíficas.</p>

"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 9,
				Titulo = "Assuntos domésticos",
				Link = "Domestico",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
 	    <div id=""index"">

    	    <h1>Índice</h1>



            <ol>

			    <li><a href=""#Energia"">Energia</a></li>

                <li><a href=""#Poluicao"">Poluição</a></li>

                <li><a href=""#ProtecaoAoConsumidor"">Proteção ao Consumidor</a></li>

                <li><a href=""#Educacao"">Educação</a></li>

                <li><a href=""#Populacao"">População</a></li>

                <li><a href=""#Transporte"">Transporte</a></li>

                <li><a href=""#PobrezaEDesemprego"">Pobreza e desemprego</a></li>

                <li><a href=""#LeisTrabalhistasCLTs"">Leis Trabalhistas (CLTs)</a></li>

            <li><a href=""#PrevidenciaSocial"">Previd&ecirc;ncia Social</a></li>

            <li><a href=""#Saude"">Sa&uacute;de</a></li>

            <li><a href=""#UsoDosRecursos"">Uso dos recursos naturais</a></li>

            <li><a href=""#Agricultura"">Agricultura</a></li>

            <li><a href=""#LeisEleitorais"">Leis eleitorais</a></li>

            <li><a href=""#Secessao"">Secess&atilde;o</a>   </li>

            </ol>

    

		    <h1>Ideias</h1>

		    <ul>

			    <li><a href=""/Liber/Direitos"">Direitos Individuais</a></li>

			    <li><a href=""/Liber/Economia"">Comércio e Economia</a></li>

			    <li><a href=""/Liber/Domestico"">Assuntos Domésticos</a></li>

			    <li><a href=""/Liber/Exterior"">Relações Exteriores</a></li>

			    

		    </ul>

	    </div>

       

        <p>

 Os problemas atuais em áreas como energia, poluição, saúde, cidades em decadência e pobreza não são solucionados, mas causados pelo governo. O assistencialismo, supostamente desenvolvido para ajudar os pobres, é na verdade uma carga crescente e parasita carregada por todas as pessoas produtivas, e prejudica, ao invés de beneficiar, os pobres.

        </p>

        

        <h2><a name=""Energia"">1. Energia</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> O controle do governo sobre a indústria de entergia resultou em altos preços, apagões, falta de competição, falta de exploração e falta de desenvolvimento de fontes alternativas de energia, além de dar vantagem no mercado existente àqueles com acesso político.

        </p>

        

        <p>

        	<strong>O princípio:</strong> Defendemos a criação de um livre mercado de petróleo instituindo direito de propriedade sobre petróleo subterrâneo e condenamos todos os controles pelo governo sobre a saída na indústria de petróleo. A indústria de energia nuclear deve ser testada em livre mercado. Nos opomos ao controle governamental sobre o preço da energia, alocação e produção. Nos opomos à criação de uma agência de mobilização na área de energia.

		</p>

        

        <p>

        	<strong>Soluções:</strong> Todos os recursos enérgicos possuídos pelo governo devem ser privatizados. Energia nuclear deve ser desnacionalizada e as posses na indústria transferidas para o setor privado. Fim de todas as participações diretas e indiretas na indústria de energia nuclear, incluindo subsídios, pesquisa e fundos para desenvolvimento, empréstimos garantidos, subsídios para jogar o lixo, e agências federais, civis e militares, de enriquecimento de urânio. Privatização de todas as empresas públicas de prospecção e distribuição de petróleo e derivados e qualquer tentativa de aumentar impostos sobre petróleo ou a imposição de quotas de petróleo. A abertura do mercado deverá, por si só, gerar competição para busca de novas fontes de energia, inclusive a renovável.

        </p>

        

        <h2><a name=""Poluicao"">2. Poluição</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> A poluição do meio-ambiente é vista hoje sob uma perspectiva socialista e estatista, onde o meio-ambiente é um bem ""público"" não passível de apropriação e os danos causados devem ser reparados mediante indenização ao Estado, que nunca repassa os valores para o meio-ambiente degradado.

        </p>

        

        <p>

        	<strong>O princípio:</strong> A defesa da vida, liberdade e propriedade privada é o único papel legítimo do Estado. A publicização do meio-ambiente acarreta em ineficiência na sua proteção e impede que os verdadeiros atingidos pela poluição receba a justa indenização pela violação da sua propriedade privada, tanto de seu corpo quanto de seus bens.

        </p>

        

        <p>

        	<strong>Soluções:</strong> Desenvolver um sistema legal objetivo definindo os direitos de propriedade para o ar e a água. A defesa do meio-ambiente deve ser feita através dos proprietários que forem lesados ou possuam potencial para serem lesados por poluidores. O Governo não deve intervir na questão como parte, pois as indenizações são desviadas por burocratas e nunca chegam a seu destino. Extinção de agências e órgãos reguladores do meio-ambiente, que impedem o exercício do direito de propriedade dos cidadãos.

        </p>

        

        <h2><a name=""ProtecaoAoConsumidor"">3. Proteção ao Consumidor</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> Regulações de proteção ao consumidor pelo governo restringem a competição do livre mercado e substituem o direito de um indivíduo fazer escolhas independentes por padrões determinados pelo governo.

        </p>

        

        <p>

        	<strong>O princípio:</strong> A demanda dos consumidores deve reger a proteção ao consumidor. Defendemos fortes e efetivas leis para que o conteúdo dos produtos esteja nos lacres e defesa contra fraudes.

        </p>

        

        <p>

        	<strong>Soluções:</strong> Extinção de órgãos que certificam produtos para o consumidor, passando esse encargo para entidades privadas, com elaboração de leis que defendam os consumidores de fraudes. Extinção de regulações paternalistas que impõem preços, definem padrões para produtos, ou restringem a possibilidade de correr riscos e livre escolha. Extinção de leis que obrigam o consumidor a consumir o produto ou serviço de maneira determinada, tal como o uso de cinto de segurança em veículos automotores.

        </p>

        

        <h2><a name=""Educacao"">4. Educação</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> Escolas públicas levam à doutrinação das crianças ou interferem na livre escolha dos indivíduos. Leis de educação compulsória geram escolas com muitos problemas semelhantes a prisões.

        </p>

        

        <p>

        	<strong>O princípio:</strong> Educação, como qualquer outro serviço, pode ser melhor executado pelo livre mercado, alcançando maior qualidade e eficiência com maior diversidade de escolha.

        </p>

        

        <p>

        	<strong>Soluções:</strong> Defesa da completa separação entre educação e estado. Posse, operação, regulação e subsídios pelo governo de escolas, colégios e universidades devem cessar. Fim das garantias da educação pública. Extinção das leis de educação compulsória. Apoio à redução imediata de ajuda fiscal para escolas e remoção de tributos que tenham finalidade de custear educação, pois cidadãos não são responsáveis pela educação de crianças que não são seus filhos. Extinção de todos os tributos que incidam no sistema educacional. Como medida transitória, defesa da privatização das escolas públicas e entrega de vales-escola para as crianças que delas necessitarem.

        </p>

        

        <h2><a name=""Populacao"">5. População</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> Observamos que as tragédias causadas por gestações não desejadas são agravadas, se não criadas, por políticas governamentais de censura, restrição e proibição.

        </p>

        

        <p>

        	<strong>O princípio:</strong> O povo brasileiro não é um recurso nacional colecionável. Nos opomos a quaisquer medidas coercivas para controle populacional.

        </p>

        

        

        <p>

        	<strong>Soluções:</strong> Combater ações governamentais que compelem ou proíbem aborto, promovem esterilização ou quaisquer outras formas de controle de natalidade. Especificamente, condenar qualquer tentativa de elaborar leis que visem a esterilização forçada de miseráveis, deficientes mentais ou indivíduos com problemas de saúde. Revogar todas as leis que restringem a participação em trocas voluntárias de mercadorias, serviços ou informação relacionada à sexualidade humana, reprodução, controle de natalidade ou tecnologias médicas ou biológicas relacionadas ao assunto. Oposição a leis governamentais e políticas que restrinjam a oportunidade de escolher alternativas para o aborto.

        </p>

        

        <h2><a name=""Transporte"">6. Transporte</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> A interferência do governo no transporte é caracterizada por restrição monopolística, corrupção e ineficiência.

        </p>

        

        <p>

        	<strong>O princípio:</strong> A prestação de serviços de transportes deve ser tratada como qualquer serviço, sendo prestada através de mercados livres e mantida por responsabilidade judicial rigorosa.

        </p>

        

        <p>

        	<strong>Soluções:</strong> Fim de todos os órgãos governamentais que promovem e regulam o transporte, e transferência de suas funções a entidades privadas competitivas. Privatização de aeroportos, ferrovias, sistemas de controle de tráfego e estradas públicas. Extinção de leis que regulam o consumo de bebidas alcoolicas no trânsito e fim de favores governamentais à indústria de automobilística. Extinção de leis restringindo a competição da área automobilística tais como monopólios de taxi e ônibus e a proibição de serviços de micro-ônibus e vans. Defesa do transporte alternativo.

        </p>

        

        <h2><a name=""PobrezaEDesemprego"">7. Pobreza e desemprego</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> Ações fiscais e monetárias do governo que estimulam artificialmente a expansão dos negócios garantem um eventual aumento no desemprego ao invés de reduzi-lo. Programas do governo são ineficientes, paternais, humilhantes e invasivos na privacidade.

        </p>

        

        <p>

        	<strong>O princípio:</strong> A forma adequada de ajuda para os pobres é através de esforços voluntários de grupos privados e indivíduos. Nenhum trabalhador deve ser legalmente penalizado pela falta de certificação e nenhum consumidor deve ser legalmente restrito de contratar indivíduos não-licenciados.

        </p>

        

        <p>

            <strong>Soluções:</strong> Eliminação da obrigatoriedade de certificação oficial para trabalhar em qualquer área. Abolição de todas as agências governamentais e não-governamentais federais, estaduais e locais que restrinjam a entrada em qualquer profissão ou regulam sua prática. Extinção de todo auxílio-desemprego, projetos de esmola e programas de ajuda aos pobres. Extinção de todas as leis que impedem um indivíduo de encontrar um emprego, tais como salário mínimo, a chamada ""legislação protetiva"" para mulheres e crianças, restrições governamentais no estabelecimento de creches, e a CLT. Fim do incentivo governamental para aposentadoria forçada. Estimular a subtituição do Estado pela iniciativa privada do campo da solidariedade através de maciços abatimentos em impostos em virtude de doações para entidades de caridade privadas.</p>

        <h2><a name=""LeisTrabalhistasCLTs"">8. Leis Trabalhistas (CLTs)</a></h2>

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        <p> <strong>O Assunto:</strong> As ações arbitrárias da Justiça do Trabalho invadem os direitos à propriedade, elevam preços, geram desemprego e se impõem injustamente sobre os geradores de emprego. Acabam por transformar empregadores em criminosos e empregados em vítimas, prejudicando a economia. </p>

        <p> <strong>O princípio:</strong> Essas leis negam o direito à liberdade e propriedade tanto ao empregado quanto ao empregador, e interfere em sua relação contratual privada. Uma sociedade de livre-comercio é baseada em trocas voluntárias e uma troca voluntária só acontece quando ambas as partes enxergam vantagens. Qualquer ação coercitiva por parte do governo que tire o livre arbítrio dos indivíduos e decida por eles o que é ou não vantajoso é errada. </p>

        <p> <strong>Soluções:</strong> Relações trabalhistas são trocas voluntárias entre empregado e empregador e cabe apenas às partes envolvidas a resolução dos termos contratuais. Grupos ativistas de consumidores do setor privado devem ser criados para substituir agências governamentais ineficientes. Abolição de todas as leis trabalhistas.</p>

        <h2><a name=""PrevidenciaSocial"">9. Previdência Social</a></h2>

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        <p> <strong>A questão:</strong> O sistema previdenciário é um falido e imoral esquema piramidal com valores absurdos de endividamento e possui uma taxa de retorno abaixo na média para seus participantes. </p>

        <p> <strong>O princípio:</strong> Numa sociedade livre, o plano de aposentadoria é responsabilidade do indivíduo e não do governo. </p>

        <p> <strong>Soluções:</strong> Defendemos a substituição da atual previdência pública, fraudulenta, falida e patrocinada pelo governo, por sistemas privados voluntários. Transitoriamente, liquidação da previdência social em fatias para instituições financeiras privadas e venda de bens pertencentes ao poder público para custear as atuais aposentadorias.</p>

        <h2><a name=""Saude"">10. Saúde</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> O Brasil é um dos poucos países do mundo que possuem uma rede universal pública de segurança de saúde. Em virtude dos incentivos perversos típicos do poder público, uma quantia obscena de dinheiro vilipendiado da sociedade pelo governo é destinado a um falido, imoral e ineficiente Sistema Único de Saúde, onde pessoas demoram horas na fila para serem atendidas. Os poucos privilegiados que conseguem pagar um plano privado de saúde após serem acharcados pelo Estado, sofrem nas mãos de um mercado altamente regulamentado por agências governamentais corruptas.

        </p>

        

        <p>

        	<strong>O princípio:</strong> Reconhecemos o direito dos indivíduos, livres da intervenção do governo e seus danosos efeitos colaterais, de determinar o nível de seguridade que querem, o nível de saúde que querem, os provedores de saúde que querem, os remédios e tratamentos que querem usar e todos os outros aspectos da saúde. O papel do governo em qualquer tipo de seguridade deve ser apenas o de fazer valer contratos quando necessário, não o de ditar às seguradoras e consumidores quais tipos de contrato eles devem acordar voluntariamente.        </p>

        

        <p>

        	<strong>Soluções:</strong> Restaurar e reviver um mercado livre na área de saúde. Promover uma completa separação entre medicina e Estado. Acabar com o Sistema Único de Saúde e agências, como ANS e ANVISA, que controlam o mercado de saúde e promovem monopólio de empresas corrputoras. Todos os serviços de saúde são mais eficientemente providas pelo setor privado. Transitoriamente, privatização de todos os centros médicos públicos e fornecimento de vale-saúde para a população.

        </p>

        

        <h2><a name=""UsoDosRecursos"">11. Uso dos recursos</a> naturais </h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> O governo controla o uso dos recursos através de despropriação, leis de zona, códigos de construção, códigos de postura, controle de aluguel, estatutos urbanos e rurais, leis florestais e ambientais, entre outras medidas legais. Tais regulações e programas violam o direito de propriedade, discriminam minorias, criam falta de moradia e tendem a inflacionar os aluguéis. Todas as restrições governamentais sobre o uso privado ou transferência voluntária de direitos de água ou controles despóticos similares podem apenas agravar a má distribuição de água. 

        </p>

        

        <p>

        	<strong>O princípio:</strong> O uso dos recursos é responsabilidade e direito dos donos legítimos da terra, água e outros recursos naturais.

        </p>

        

        <p>

        	<strong>Soluções:</strong> Estabelecer um sistema privado eficiente e justo de direitos sobre água aplicado tanto para água na superfície quanto para água no subsolo, baseado no princípio do <em>homesteading</em> (primeiro que usar). Promover a completa separação entre o fornecimento de água e o Estado, de modo a previnir crises de falta de água no futuro. Privatização de todos os projetos e empresas de águas governamentais. Fim de todos os órgãos e agências destinadas ao controle de recursos naturais. Revogar todas as leis que controlam e regulam o uso dos recursos naturais.

        </p>

        

        <h2><a name=""Agricultura"">12. Agricultura</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> O mercado livre da agricultura, sistema que alimenta grande parte do mundo, foi arado por intervenções do governo. Subsídios, regulações e taxas encorajaram a centralização do agronegócio. As políticas de exportação do governo fazem com que os fazendeiros sejam reféns dos caprichos das administrações públicas.

        </p>

        

        <p>

        	<strong>O princípio:</strong> Tanto fazendeiros quanto consumidores devem ser livres das intromissões e medidas contra-produtivas dos governos em todos os níveis. Os cidadãos devem ser livres para plantar, vender ou comprar o que quiserem, na quantidade que quiserem, quando quiserem.

        </p>

        

        <p>

        	<strong>Soluções:</strong> Agricultores e outros fornecedores de produtos e serviços no mercado livre da agricultura devem operar sem qualquer regulação governamental, enquanto são policiadas pelas agências de proteção ao consumidor do setor privado com relação à qualidade, e devem ser punidas pelo judiciário em casos de fraude e enganação. Eliminar todos os programas de governo para fazendas, incluindo suporte de preços, subsídios diretos e toda e qualquer regulação na produção agrícola. Desregulamentar a indústria de transportes, barateando o escoamento de produtos agrícolas. Fim do envolvimento do governo no controle de pestes na agricultura, que passa a ser responsabilidade dos agricultores.</p>

        

        <h2><a name=""LeisEleitorais"">13. Leis Eleitorais</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> O sistema eleitoral brasileiro é completamente distorcido. A obrigatoriedade de voto faz do mesmo um dever e não um direito. Há superrepresentação de estados pouco populosos e subrepresentação de estados muito populosos. A legislação eleitoral veda a liberdade política com restrição ao lançamento de candidaturas e criação de partidos.

        </p>

        

        <p>

        	<strong>O princípio:</strong> O sufrágio é um direito e não um dever. Esse direito é amplo e irrestrito, devendo o eleitor possuir a maior quantiadade possível de opções.

        </p>

        

        <p>

        	<strong>Soluções:</strong> Proposição de um sistema eleitoral justo, que reflita a representatividade das correntes políticas no âmbito federal, estadual e local. Fim do controle governamental dos partidos politicos, permitindo liberdade de criação, associação e expressão, com possibilidade de existência de partidos regionais e locais. Fim do subsídio público aos partidos políticos, em especial o fundo partidário. Correção da representação dos Estados na Câmara dos Deputados.

        </p>

        

        <h2><a name=""Secessao"">14. Secessão</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A questão:</strong> As pessoas são forçadas a se subordinar aos governos e participar de seus programas, geralmente como provedores de financiamento, independentemente de sua vontade.

        </p>

        

        <p>

        	<strong>O princípio:</strong> Como toda associação política deve ser voluntária, reconhecemos o direito de secessão política. Isso inclui o direito de secessão por entidades políticas, grupos privados ou indivíduos. O exercício desse direito, assim como o exercício de todos os outros direitos, não anula obrigações legais e morais de não violar o direito de outros.

        </p>

        

        <p>

        	<strong>Soluções:</strong> Defendemos o direito de entidades políticas, grupos privados e indivíduos a renunciar sua filiação com qualquer governo, e ser dispensado das obrigações impostas por esses governos, aceitando, em contrapartida, não receber nenhum suporte do governo com o qual foi feita a secessão.

        </p>
"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 10,
				Titulo = "Relações Exteriores",
				Link = "Exterior",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
	    <div id=""index"">

            <h1>Índice</h1>



		    <ul>

        	    <li style=""border:none""><a href=""#PoliticaDiplomatica""><strong>A. Politica diplomática</strong></a>

            	    <ul>

            		    <li><a href=""#Negociacoes"">1. Negociações</a></li>

                        <li><a href=""#BrasileirosNoExteriorEDireitosHumanos"">2. Brasileiros no exterior e Direitos Humanos</a></li>

                    </ul>

                </li>

            

                <li style=""border:none""><a href=""#ForcasArmadas""><strong>B. Forças Armadas</strong></a>

            	    <ul>

            		    <li><a href=""#PoliticaMilitar"">1. Política Militar</a></li>

                    </ul>

                </li>

            

                <li style=""border:none""><a href=""#PolticaEconomica""><strong>C. Política econômica</strong></a>

            	    <ul>

            		    <li><a href=""#AjudaInternacional"">1. Ajuda internacional</a></li>

                        <li><a href=""#MoedasEstrangeiras"">2. Moedas estrangeiras</a></li>

                        <li><a href=""#RecursosSemDono"">3. Recursos sem Dono</a></li>

                    </ul>

                </li>

            </ul>

    

		    <h1>Ideias</h1>

		    <ul>

			    <li><a href=""/Liber/Direitos"">Direitos Individuais</a></li>

			    <li><a href=""/Liber/Economia"">Comércio e Economia</a></li>

			    <li><a href=""/Liber/Domestico"">Assuntos Domésticos</a></li>

			    <li><a href=""/Liber/Exterior"">Relações Exteriores</a></li>

			    

		    </ul>

	    </div>



        <p>

            A política externa do Brasil deve ser pautada pela manutenção da paz e pela defesa contra qualquer forma de ataque à vida, à propriedade ou à liberdade dos cidadãos brasileiros ou em território nacional. É imperativo à qualquer ação de defesa respeitar os direitos individuais de todas as pessoas. As relações entre os Estados devem ser pautadas pelo princípio da não-intervenção. O governo brasileiro deve evitar a formação de alinhamentos automáticos e se abster de realizar ou de participar de qualquer ação imperialista, reconhecendo o direito ao livre comércio, viagens e imigração.</p>

        

        <h2><a name=""PoliticaDiplomatica"">A. Política diplomática</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <h2><a name=""Negociacoes"">1. Negociações</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> A intervenção do governo brasileiro nos assuntos de outros Estados é uma tentativa de impor nossos valores a outras nações através da força, mesmo quando em ação conjunta com outros governos.</p>

        

        <p>

        <strong>O princípio:</strong> O mais importante princípio de política externa deve ser a eliminação da intervenção do governo brasileiro nos assuntos de outros Estados. Não precisamos participar de nenhuma espécie de governo mundial para mantermos relações diplomáticas com outras nações.</p>

        

        <p>

            <strong>Soluções:</strong> Drástica redução no custo e no tamanho de nosso corpo diplomático. Apoiar a retirada do Brasil das Nações Unidas e o fim do auxílio financeiro a essa organização. Oposição a qualquer política que designe as Nações Unidas como força policial do mundo. Oposição ao comprometimento de tropas nacionais em guerras sob o comando da ONU. Oposição a assinatura de qualquer tratado que possibilite a violação dos direitos individuais.</p>

        

        <h2><a name=""BrasileirosNoExteriorEDireitosHumanos"">2. Brasileiros no exterior e direitos humanos</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> Governos estrangeiros podem violar os direitos dos brasileiros que se encontram ou possuem propriedades no exterior, assim como esses governos violam os negócios de seus próprios cidadãos. Entretanto, qualquer esforço para estender a proteção do governo do Brasil aos cidadãos brasileiros que se encontram ou possuem propriedades sob jurisdição de outros Estados envolve risco de intervenção militar, da mesma forma que a tentativa de estender esta proteção aos estrangeiros em geral. Em particular, a proteção de investimentos de cidadãos ou negócios brasileiros no estrangeiro é uma forma injusta de auxílio, pois implica em custos que serão financiados por todos os cidadãos brasileiros.</p>

        

        <p>

            <strong>O princípio:</strong> Condenar oficialmente toda violação dos direitos de propriedade, tanto de cidadãos brasileiros como de estrangeiros. Adesão ao princípio de que os cidadãos de nosso país assumem por conta própria os riscos de viajar, viver e possuir negócios no exterior, seguindo o princípio de não intervir nos assuntos internos de outros países.</p>

        

        <p>

        <strong>Soluções:</strong> Eliminar de todo e qualquer passaporte, visto ou outros papéis exigidos para atravessar fronteiras. Informar nossos cidadãos, através das embaixadas brasileiras, que estão sujeitos a leis estrangeiras quando viajam ou investem em outro país. O governo brasileiro não pode isolar nossos cidadãos das leis estrangeiras quando eles se encontram fora do país; nossas embaixadas não podem assumir a responsabilidade de proteger cidadãos das conseqüências de suas próprias condutas enquanto eles se encontram em outros Estados, da mesma forma que não o podem fazer com estrangeiros em geral.</p>

        

        <h2><a name=""ForcasArmadas"">B. Forças Armadas</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <h2><a name=""PoliticaMilitar"">1. Política Militar</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>	

            <strong>A questão:</strong> O uso potencial de armas nucleares é a maior ameaça a todos os povos do mundo. Logo, devemos buscar reduzir ao mínimo o risco de uma guerra nuclear.</p>

        

        <p>

            <strong>O princípio:</strong> Qualquer política militar brasileira deve ter como objetivo aumentar a segurança para as vidas, a liberdade e a propriedade de seus cidadãos, que vivem em território nacional, contra o risco de um ataque externo. Esse objetivo deve ser alcançado ao menor custo financeiro possível e sem prejuízo às liberdades que o mesmo busca proteger.</p>

        

        <p>

            <strong>Soluções:</strong> As armas de destruição em massa não-nucleares das forças brasileiras devem ser substituídas por armamentos menores, feitos para atingir alvos militares e não para matar milhões de civis. Interromper qualquer tentativa governamental de criar armamentos nucleares de destruição em massa. Retirar tropas brasileiras que se encontram no exterior, participando das missões de paz da ONU. Não há qualquer prognóstico que indique que o povo brasileiro corra risco de sofrer um ataque militar convencional, particularmente de longas distâncias. Retirar o Brasil de qualquer acordo que o comprometa a participar de guerras por causa de outros governos e também o abandono de doutrinas que pregam a liderança do Brasil sobre os outros países da América do Sul.</p>

        

        <h2><a name=""PoliticaEconomica"">C. Política econômica</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <h2><a name=""AjudaInternacional"">1. Ajuda internacional</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> O governo federal utiliza a ajuda internacional como um meio para influenciar a política de outras nações soberanas ao prestar auxílio às pessoas necessitadas nesses países. Isso obriga os cidadãos brasileiros a subsidiar governos e políticas com as quais eles podem não concordar.</p>

        

        <p>	

            <strong>O princípio:</strong> Os indivíduos não devem ser obrigados, através do

            pagamento de impostos, a financiar uma nação ou grupo estrangeiro.

        </p>	

            

        <p>		

            <strong>Ações transitórias:</strong> Eliminar toda forma de auxílio militar, econômico, técnico e científico, sustentada através dos impostos, a governos ou organizações estrangeiras. Abolir o subsídio do governo à venda de armas. Abolir todos os órgãos federais que tornam o cidadão brasileiro que paga impostos um fiador das operações de empréstimo relacionadas à exportação. Encerrar a participação do governo brasileiro nos círculos internacionais de commodities que restringem a produção, limitam a inovação tecnológica e aumentam os preços. Acabar com todas as proibições a indivíduos ou empresas que desejam manter negócios com qualquer país ou organização estrangeira, a menos que o negócio se constitua em uma ameaça direta ao povo brasileiro.</p>

	

        <h2><a name=""MoedasEstrangeiras"">2. Moedas estrangeiras</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>		

            <strong>A questão:</strong> O envolvimento do governo federal no mercado internacional de câmbio solapa estabilidade do Real, cuja cotação é modificada artificialmente, o que prejudica a liberdade dos mercados.</p>

        

        <p>		

            <strong>O princípio:</strong> Os cidadãos, através da liberdade de comércio nos mercados,

            devem constituir o único fator determinante do valor de bens e serviços.

        </p>

        

        <p>	

            <strong>Soluções:</strong> O envolvimento do governo nos mercados de câmbio internacionais, juntamente com as reservas financeiras do Banco Central deveriam ser extintos, e o comércio realizado pelos setores privados deve ser o único fator a influenciar a cotação da moeda. O Brasil deve liquidar as reservas em moeda estrangeira, bem como outras formas de crédito que gerem inflação. O país deve se retirar do Banco Mundial e do Fundo Monetário Internacional. Retirar o Brasil do papel de fiador de governos estrangeiros.</p>

        

        <h2><a name=""RecursosSemDono"">3. Recursos sem Dono</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A questão:</strong> Governos e grupos internacionais reivindicam o direito aos recursos sem dono, apesar de não possuírem jurisdição sobre esses, impondo tais reivindicações contra indivíduos através da força.</p>

        

        <p>			

            <strong>O princípio:</strong> Indivíduos têm o direito de usufruir os recursos sem dono e também de territórios internacionais como o oceano, a Antártida e o espaço cósmico.</p>

        

        <p>			

            <strong>Soluções:</strong> Fim do reconhecimento de qualquer reivindicação de governos nacionais ou organizações internacionais sobre territórios internacionais. Ajudar a desenvolver um padrão internacional para o reconhecimento de reivindicações a propriedade feitas por particulares como no caso das pistas de transportes, faixas de transmissão, direito à exploração de minérios, à pesca e ao cultivo em oceanos. Todas as leis, tratados e acordos internacionais que restringem ou impedem o usufruto de recursos sem dono devem ser abolidos. Recusa em aceitar o proposto Tratado sobre Direito do Mar, pois ele exclui o princípio da propriedade privada.</p>

"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 11,
				Titulo = "Faça uma doação",
				Link = "Doacao",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
		<p>Ajude o LIBER a conquistar mais liberdade para todos. Doe aqui:</p>

		<form target=""pagseguro"" action=""https://pagseguro.uol.com.br/checkout/doacao.jhtml"" method=""post"">

			<input type=""hidden"" name=""email_cobranca"" value=""brunopaludo@hotmail.com"" />

			<input type=""hidden"" name=""moeda"" value=""BRL"" />

			<input type=""hidden"" name=""ref_transacao"" value=""0"" />

			<input type=""image"" src=""https://p.simg.uol.com.br/out/pagseguro/i/botoes/doacoes/205x30-doar-azul.gif"" name=""submit"" alt=""Pague com PagSeguro - é rápido, grátis e seguro!"" />

		</form>

		<p></p>
"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 12,
				Titulo = "Divulgue o LIBER",
				Link = "Divulgacao",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
	<h2>

		Banner horizontal</h2>

	<p>

		<img src=""/Content/images/bannerLIBERhor01.png"" /></p>

	<p>

		<strong>Código HTML:</strong></p>

	<pre>&lt;a href=""http://www.libertarios.com.br/""&gt;&lt;img src=""http://www.libertarios.com.br/Content/images/bannerLIBERhor01.png"" style=""border:0px;""&gt;&lt;/a&gt;</pre>

	<h2>

		Banner vertical</h2>

	<p>

		<img src=""/Content/images/bannerLIBERvert01.png"" /></p>

	<p>

		<strong>Código HTML:</strong></p>

	<pre>&lt;a href=""http://www.libertarios.com.br/""&gt;&lt;img src=""http://www.libertarios.com.br/Content/images/bannerLIBERvert01.png"" style=""border:0px;""&gt;&lt;/a&gt;</pre>


"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 13,
				Titulo = "LIBER 500",
				Link = "Liber500",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
        <h2>Fichas de apoio ao registro - desafio LIBER 500</h2>



        <p>O <strong>LIBER</strong> está coletando as 500 mil assinaturas necessárias para

           registrar o partido junto ao TSE e disputar eleições.

           Faça parte dessa conquista!</p>



        <p>A assinatura desta ficha não representa filiação ao partido,

           é somente um manifesto de apoio ao registro do <strong>LIBER</strong>.</p>



        <p id=""ficha_btn"">

            <a href=""/Content/download/ficha_apoio_liber_500.pdf"" target=""_blank"">Baixe a ficha de apoio e o manual para coleta de assinaturas</a>

        </p>



        <h2>Dados obrigatórios:</h2>



        <ul>

            <li>Nome completo (sem abreviaturas)</li>

            <li>Nome da mãe (sem abreviaturas)</li>

            <li>Data de nascimento</li>

            <li>Assinatura (como no título de eleitor)</li>

        </ul>



        <h2>As fichas devem ser enviadas para:</h2>

			

			<address>

				<b>Bernardo Santoro</b><br />

				Rua Henrique Raffard nº 337, Bingen<br />

				Petrópolis - RJ<br />

				CEP 25665-062<br />

			</address>

"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 14,
				Titulo = "Contato",
				Link = "Contato",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
        <p>

            Em caso de dúvida, envie um e-mail para <a href=""mailto:contato@pliber.org.br"">contato@pliber.org.br</a>.

            O Secretário Geral encaminhará a mensagem para o responsável.

        </p>



        <ul class=""formatted_list"">

            <li class=""highlight""><strong>Presidente</strong>

                <a href=""mailto:presidente@pliber.org.br"">presidente@pliber.org.br</a>

            </li>

            <li><strong>Vice Presidente</strong>

                <a href=""mailto:vice@pliber.org.br"">vice@pliber.org.br</a>

            </li>

            <li><strong>Secretário Geral</strong>

                <a href=""mailto:contato@pliber.org.br"">contato@pliber.org.br</a>

            </li>

            <li><strong>Corregedor</strong>

                <a href=""mailto:corregedor@pliber.org.br"">corregedor@pliber.org.br</a>

            </li>

            <li><strong>Tesouraria</strong>

                <a href=""mailto:tesouraria@pliber.org.br"">tesouraria@pliber.org.br</a>

            </li>

            <li><strong>Captação de Recursos</strong>

                <a href=""mailto:recursos@pliber.org.br"">recursos@pliber.org.br</a>

            </li>

            <li><strong>Comunicação</strong>

                <a href=""mailto:sejaliber@pliber.org.br"">sejaliber@pliber.org.br</a>

            </li>

            <li><strong>Marketing</strong>

                <a href=""mailto:mkt@pliber.org.br"">mkt@pliber.org.br</a>

            </li>

            <li><strong>Relações Públicas</strong>

                <a href=""mailto:rp@pliber.org.br"">rp@pliber.org.br</a>

            </li>

            <li><strong>Assessoria de Imprensa</strong>

                <a href=""mailto:imprensa@pliber.org.br"">imprensa@pliber.org.br</a>

            </li>

            <li><strong>Webmaster</strong>

                <a href=""mailto:webmaster@pliber.org.br"">webmaster@pliber.org.br</a>

            </li>

        </ul>

"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 15,
				Titulo = "Diretórios",
				Link = "Diretorios",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
        <div style=""float: left;"">

            <h2>Região Sul</h2>



            <ul class=""formatted_list"">

                <li><strong>Rio Grande do Sul</strong><br />

                    Presidente: <em>Alexsander Rosa</em><br />

                    Email para contato: <a href=""mailto:alexsander.rosa@gmail.com"">alexsander.rosa@gmail.com</a>

                </li>

                <li><strong>Santa Catarina</strong><br />

                    Presidente: <em>André Poffo</em><br />

                    Email para contato: <a href=""mailto:andrehpoffo@gmail.com"">andrehpoffo@gmail.com</a>

                </li>

                <li><strong>Paraná</strong><br />

                    Presidente: <em>Geraldo Boz Junior</em><br />

                    Email para contato: <a href=""mailto:gbozjr@gmail.com"">gbozjr@gmail.com</a>

                </li>

            </ul>

        </div>



        <div style=""float: right; width: 320px;"">

            <h2>Região Centro-Oeste</h2>



            <ul class=""formatted_list"">

                <li><strong>Mato Grosso do Sul</strong><br />

                    Presidente: <em>Elberto Teles Ribeiro</em><br />

                    Email para contato: <a href=""mailto:professor.elberto@hotmail.com"">professor.elberto@hotmail.com</a>

                </li>



                <li><strong>Mato Grosso</strong><br />

                    Presidente: <em>Rodrigo Martins Mussnich</em><br />

                    Email para contato: <a href=""mailto:rodrigo.liber@gmail.com"">rodrigo.liber@gmail.com</a>

                </li>



                <li><strong>Distrito Federal</strong><br />

                    Presidente: <em>André Ramos</em><br />

                    Email para contato: <a href=""mailto:alscramos@gmail.com"">alscramos@gmail.com</a>

                </li>

            </ul>

        </div>



        <div style=""float: left"">

            <h2>Região Sudeste</h2>



            <ul class=""formatted_list"">

                <li><strong>São Paulo</strong><br />

                    Presidente: <em>André Rufino</em><br />

                    Vice-presidente: <em>Roberto Chiocca</em><br />

                    Email para contato: <a href=""mailto:andrerrufino@gmail.com"">andrerrufino@gmail.com</a>

                </li>



                <li><strong>Minas Gerais</strong><br />

                    Presidente: <em>Caio José de Oliveira Ramos</em><br />

                    Email para contato: <a href=""mailto:caio@yahoo.com.br"">caio@yahoo.com.br</a>

                </li>



                <li><strong>Rio de Janeiro</strong><br />

                    Presidente: <em>Patrick Gappo</em><br />

                    Email para contato: <a href=""mailto:patrickccg@globo.com"">patrickccg@globo.com</a>

                </li>



                <li><strong>Espírito Santo</strong><br />

                    Presidente: <em>Sidnei Santana Carneiro</em><br />

                    Email para contato: <a href=""mailto:sidneisc@gmail.com"">sidneisc@gmail.com</a>

                </li>

            </ul>

        </div>



        <div style=""float: right; width: 320px;"">

            <h2>Região Nordeste</h2>



            <ul class=""formatted_list"">

                <li><strong>Ceará</strong><br />

                    Presidente: <em>Bruno Aguiar</em><br />

                    Email para contato: <a href=""mailto:brunobca@gmail.com"">brunobca@gmail.com</a>

                </li>

            </ul>

        </div>



        <div style=""float: right; width: 320px;"">

            <h2>Região Norte</h2>



            <ul class=""formatted_list"">

                <li><strong>Amazonas</strong><br />

                    Presidente: <em>Fabiano Castanhola</em><br />

                    Email para contato: <a href=""mailto:fcastanhola@gmail.com"">fcastanhola@gmail.com</a>

                </li>



                <li><strong>Rondônia</strong><br />

                    Presidente: <em>Joel Castro de Oliveira</em><br />

                    Email para contato: <a href=""mailto:joelcstr@gmail.com"">joelcstr@gmail.com</a> ou<br />

                    <a href=""mailto:joelcstr@hotmail.com"">joelcstr@hotmail.com</a>

                </li>



                <li><strong>Pará</strong><br />

                    Presidente: <em>Marcos Neemias Negrão Reis</em><br />

                    Email para contato: <a href=""mailto:mneemias@gmail.com"">mneemias@gmail.com</a>

                </li>

            </ul>

        </div>
"
				#endregion
			});

			context.Paginas.Add(new Pagina
			{
				PaginaID = 16,
				Titulo = "Perguntas Frequentes",
				Link = "FAQ",
				Publicado = true,
				CriadoEm = DateTime.Now,
				#region Conteudo = "..."
				Conteudo = @"
        <p>

            <strong>O que é um Libertário?</strong>

        </p>

        

        <p>

            Um Libertário acredita no princípio da Liberdade, que você deve ser

            livre para tomar decisões sobre a sua própria vida desde que não interfira

            com os direitos básicos dos outros - vida, liberdade e propriedade.

        </p>

        

        <p>

            <strong>Que enfoque terão os Libertários se forem eleitos?</strong>

        </p>

        

        <p>

            Se um governo Libertário for eleito, ele reduzirá os impostos a um nível mínimo

            e reduzirá o tamanho do Estado a um mínimo. Ele também retiraria restrições

            às liberdades econômicas e individuais e buscaria reduzir a interferência do

            governo nas diversas áreas da vida, tanto quanto possível.

        </p>

        

        <p>

            <strong>E se meu parlamentar for o único Libertário ou apenas um entre poucos?</strong>

        </p>

        

        <p>

            Ótimo. Se indivíduos Libertários forem eleitos ao Congresso

            (ou mesmo a uma Câmara de Vereadores), eles votarão contra leis que restringem

            as liberdades pessoais e econômicas e a favor de leis que aumentam a liberdade.

            Eles teriam uma posição privilegiada para divulgar a mensagem Libertária no Brasil.

        </p>

        

        <p>

            <strong>Mas e os programas sociais para os necessitados?</strong>

        </p>

        

        <p>

            Governo é força. Libertários acreditam numa situação onde todos ganham:

            uma sociedade voluntária onde as pessoas cooperam através do comércio e da caridade.

            A questão moral aqui é que os Libertários acreditam que não é certo tomar

            de uma pessoa à força para suprir as necessidades de outra. Os Libertários

            acreditam em minimizar os impostos e financiar o governo por outros meios,

            se possível. Programas sociais para os necessitados devem ser fornecidos

            através de meios voluntários. Forçar os outros a ""dar"" não é justo nem generoso.

            O governo não deve decidir quem precisa de ajuda, porque o

            assistencialismo é prejudicial para algumas pessoas: ele incentiva

            a dependência, a falta de iniciativa e a falta de planejamento.

            Uma economia livre produzirá mais riqueza para todos. Impostos são uma maneira

            de privar as pessoas de suas riquezas e da capacidade de investir

            essa riqueza em novos negócios, que no final das contas

            beneficiariam os mais pobres.

        </p>

        

        <p>

            <strong>Pessoas são egoístas. Não podemos depender de outros para dar aos necessitados

            por conta própria. Vocês não estão sendo otimistas demais

            em relação à natureza humana?</strong>

        </p>

        

        <p>

            Não. Libertários também são céticos sobre a natureza humana e acreditam 

            que as pessoas no governo não devem ter poder demais sobre os outros.

            Há muitos brasileiros generosos que fazem doações à caridade, mesmo agora

            com impostos altos. Pense nas possibilidades de doação em uma sociedade

            com impostos extremamente baixos. As pessoas se preocupam em sustentar

            suas próprias famílias e em viver responsavelmente e elas precisam ser

            livres para tomar suas próprias decisões quanto ao uso de seu dinheiro.

            A maior parte das pessoas com quem convivemos são boas a maior

            parte do tempo - caso contrário a Sociedade não funcionaria - nós confiamos

            nas pessoas como iguais. No entanto, quanto mais poder dermos

            aos outros, mais distorcidas as coisas ficam.

            Como Lord Acton disse, ""o Poder corrompe"".

        </p>

        

        <p>

            <strong>Vocês não são contra os pobres? E os

            programas de ajuda governamental às empresas?</strong>

        </p>

        

        <p>

            Não, uma sociedade mais livre removerá os obstáculos aos desavantajados

            e os ajudará a crescer economicamente. Os Libertários mudarão a natureza

            do governo. Um grande fator para o descontrole do governo é a influência

            das grandes empresas. Nenhum grupo econômico deve usar o governo para

            controlar os outros ou para beneficiar seu próprio negócio. O Livre Mercado

            deve operar sem interferência. Libertários abolirão subsídios

            e restrições à livre concorrência.

        </p>

        

        <p>

            <strong>E os necessitados? Os Libertários defendem o egoísmo e o interesse próprio?</strong>

        </p>

        

        <p>

            Libertários acreditam que os mais necessitados em nossa sociedade são os mais

            prejudicados pelo sistema vigente, no qual o governo beneficia a grupos de interesse às

            custas dos pagadores de impostos. Dinheiro que os indivíduos poderiam estar

            direcionando para crianças autistas, idosos pobres ou um novo negócio estão

            indo para o governo que o utiliza pra manter sua estrutura inchada

            e para subsidiar indústrias existentes.

        </p>

        

        <p>

            O governo também estabelece cartórios que restringem o acesso a

            várias profissões. As leis trabalhistas vigentes impedem o acesso dos

            menos qualificados aos degraus mais baixos da escada do sucesso.

            Em geral, nossa sociedade como um todo é muito mais pobre do que deveria

            e sofre com a falta de oportunidades causadas pelos nossos impostos

            exorbitantes, pelas nossas leis que causam desemprego e pelo excesso de

            centralização que desestimula a iniciativa pessoal.

        </p>

        

        <p>

            Libertários acreditam em respeitar as escolhas dos outros. Libertários reconhecem

            que indivíduos sempre vão defender seus próprios interesses

            em qualquer sistema de governo - inclusive o sistema vigente. É bom que as

            pessoas sejam motivadas a resolver problemas e perseguir seus desejos e necessidades,

            pois isso leva a um nível de inovação e produtividade que

            beneficia a todos. No entanto, é muito melhor que o indivíduos

            defendam seus interesses num ambiente de livre mercado ao invés

            de usar o poder governamental para isso.

        </p>

        

        <p>

            A motivação para se fazer o bem ao próximo vai além dos motivos materiais.

            No entanto, esses motivos podem ser caracterizados como interesse próprio

            uma vez que o benevolente pode, por exemplo, sentir-se melhor

            consigo mesmo através do ato de bondade.

        </p>

        

        <p>

            Libertários acreditam que é bom e necessário ajudar o próximo

            através de caridade privada, mas acreditamos que não é justificável

            dar poderes ao governo - ocupado por pessoas buscando seus próprios

            interesses - de forçar uma pessoa a entregar grande parte de sua riqueza

            ao governo com o suposto objetivo de ajudar os outros.

        </p>

        

        <p>

            Como Ludwig von Mises diz no seu livro Ação Humana:

            ""We may fully endorse the religious and ethical precepts that declare it

            to be man's duty to assist his unlucky brethren whom nature has doomed.

            But the recognition of this duty does not answer the question

            concerning what methods should be resorted to for its performance.""

        </p>

        

        <p>

            <strong>Os Libertários querem fazer o Brasil ficar parecido com os Estados Unidos?</strong>

        </p>

        

        <p>

            Na verdade, não. Os Estados Unidos também precisam de muitas destas mesmas reformas.

        </p>

        

        <p>

            <strong>Vocês modificariam as Leis de Defesa do Consumidor? Que Leis permaneceriam?</strong>

        </p>

        

        <p>

            Sim. Os consumidores se informariam usando avaliações de produtos

            e serviços disponíveis no Livre Mercado. Os Libertários acreditam que o

            governo deve proteger os cidadãos e sua propriedade de assassinato,

            roubo, fraude e danos pessoais ou ambientais. Os tribunais devem estar

            disponíveis para consumidores que buscam indenização de fabricantes que

            mentem sobre seus produtos. De resto, os cidadãos devem ser

            livres para assumir seus próprios riscos no que diz respeito a

            produtos, materiais, substâncias, alimentos e drogas.

        </p>

        

        <p>

            <strong>Como os Libertários reformariam o Sistema Judiciário?

            E quanto aos menores infratores?</strong>

        </p>

        

        <p>

            Os que são condenados por crimes devem ser penalizados de forma

            proporcional ao seus crimes, independente de idade. A identidade de

            menores condenados não deve ser protegida. Em caso de crimes não-violentos,

            o foco deve ser mudado para fazer o criminoso indenizar a vítima e

            fazê-lo pagar os custos da polícia, do julgamento e da prisão. Em caso de

            crime violento, a indenização da vítima deve ser combinada com uma sentença

            de prisão que inclua um meio de trabalhar para pagar o que é

            devido. Não devem haver crimes sem vítima. Ninguém deve estar

            na prisão sem ter causado mal a outrem.

        </p>

        

        <p>

            <strong>Os Libertários não deveriam ficar fora da política?</strong>

        </p>

        

        <p>

            Não, pois há justificativas válidas para participar da política

            eleitoral. Votar no LIBER é um ato de auto-defesa. Encorajar as

            pessoas a votar no LIBER é possibilitar que elas votem a favor da

            Liberdade e contra os impostos, o intervencionismo

            e o gigantismo estatal.

        </p>

        

        <p>

            <strong>Eu não deveria apoiar um partido político maior que tenha

            mais chances de vencer uma eleição?</strong>

        </p>

        

        <p>

            Não, pois quando você vota nos partidos tradicionais você

            está votando pelo gigantismo estatal. Você está votando a favor do

            lobby das grandes empresas, que visa receber subsídios e restringir

            a entrada de concorrentes no mercado. Nenhum dos grandes partidos vai

            implementar as políticas libertárias. Apoiar o LIBER é um voto a favor

            da Liberdade, porque os Libertários buscam transformar o Brasil

            em uma sociedade livre. Votar no LIBER pressiona os outros

            partidos a dar atenção aos seus interesses.

        </p>

        

        <p>

            <strong>O que o LIBER pensa de restrições à liberdade de expressão?</strong>

        </p>

        

        <p>

            O LIBER é contrário a restrições à liberdade de expressão que

            impedem as pessoas de opinar sobre qualquer assunto. Leis contra

            ameaças a outros são válidas, assim como leis que punem a fraude.

        </p>

        

        <p>

            <strong>Como vocês justificam impostos num governo libertário?

            Vocês não acreditam que impostos são uma forma de roubo?</strong>

        </p>

        

        <p>

            Outros métodos podem ser usados para financiar as funções legítimas

            do governo (ex: polícia, cortes e juízes). Eliminar todos os impostos

            é o ideal, mas para muitos libertários não está claro que isto seja possível.

            Há outros métodos que podem ser tentados. Criminosos podem ter

            que pagar os custos policiais e judiciários. Taxas de utilização

            de serviços governamentais podem ser possíveis.

        </p>

        

        <p>

            <strong>Os Libertários são ateus?</strong>

        </p>

        

        <p>

            Não. Há muitos libertários religiosos, assim como há muitos agnósticos e

            ateus. Libertarianismo é uma filosofia

            que se preocupa com a política, apenas.

        </p>

        

        <p>

            <strong>Libertário quer dizer libertino? Os Libertários defendem

            promiscuidade, drogas e estilos de vida alternativos?</strong>

        </p>

        

        <p>

            O Libertarianismo acredita que devemos deixar as pessoas

            tomar suas próprias decisões. O Libertarianismo se preocupa

            apenas com o papel que um governo deve ter.

        </p>

        

        <p>

            <strong>Os Libertários acreditam em direitos como habeas corpus e que

            os acusados devem ser considerados inocentes até prova em contrário?</strong>

        </p>

        

        <p>

            Claro. Os Libertários orgulhosamente aderem às tradições Liberais

            Clássicas que compartilhamos com muitas outras pessoas.

        </p>

        

        <p>

            <strong>Se o LIBER assumir o governo, vocês não seriam

            exatamente como os outros partidos?</strong>

        </p>

        

        <p>

            O partido Libertários se baseia em princípios e na redução do

            poder do governo sobre as vidas dos brasileiros. O objetivo do LIBER

            é reformar o estado de forma que o governo não tenha mais tanto poder,

            independente do partido que esteja no poder.

        </p>

        

        <p>

            <strong>O governo deve interferir nas relações entre patrões e empregados?</strong>

        </p>

        

        <p>

            Não.

        </p>
"
				#endregion
			});

			#endregion

			#region Menus - fazer depois

			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "Principal", Controller = "Home", Action = "Index" });
			
			//context.Menus.Add(new Menu { MenuID = 2, Titulo = "Nosso Partido" });
			//context.Menus.Add(new Menu { MenuID = 3, Titulo = "História", Link = "Historia" });
			//context.Menus.Add(new Menu { MenuID = 4, Titulo = "Filosofia", Link = "Filosofia" });
			//context.Menus.Add(new Menu { MenuID = 5, Titulo = "Programa", Link = "Programa" });
			//context.Menus.Add(new Menu { MenuID = 6, Titulo = "Estatuto", Link = "Estatuto" });
			//context.Menus.Add(new Menu { MenuID = 7, Titulo = "Lideranças Nacionais", Link = "Lideranca" });
			//context.Menus.Add(new Menu { MenuID = 8, Titulo = "Prestação de Contas", Link = "Contas" });

			//context.Menus.Add(new Menu { MenuID = 9, Titulo = "Ideias", Link = "" });
			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "", Link = "" });
			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "", Link = "" });
			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "", Link = "" });
			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "", Link = "" });
			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "", Link = "" });
			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "", Link = "" });
			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "", Link = "" });
			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "", Link = "" });
			//context.Menus.Add(new Menu { MenuID = 1, Titulo = "", Link = "" });

			#endregion

			#region Autores

			context.Autores.Add(new Autor { AutorID = 1, Nome = "André Luiz Santa Cruz Ramos" });
			context.Autores.Add(new Autor { AutorID = 2, Nome = "Bernardo Santoro" });
			context.Autores.Add(new Autor { AutorID = 3, Nome = "Bruno Paludo" });
			context.Autores.Add(new Autor { AutorID = 4, Nome = "Filipe Rangel Celeti" });
			context.Autores.Add(new Autor { AutorID = 5, Nome = "Geraldo Boz Junior" });
			context.Autores.Add(new Autor { AutorID = 6, Nome = "Guilherme Inojosa" });
			context.Autores.Add(new Autor { AutorID = 7, Nome = "Juliano Torres" });
			context.Autores.Add(new Autor { AutorID = 8, Nome = "Matheus Assaf" });
			context.Autores.Add(new Autor { AutorID = 9, Nome = "Secretário Geral" });
			context.Autores.Add(new Autor { AutorID = 10, Nome = "Sidnei Santana Carneiro" });
			context.Autores.Add(new Autor { AutorID = 11, Nome = "Pedro Carleial" });
			context.Autores.Add(new Autor { AutorID = 12, Nome = "Pedro Henrique Gonzalez" });
			context.Autores.Add(new Autor { AutorID = 13, Nome = "Raphael Moras de Vasconcellos" });
			context.Autores.Add(new Autor { AutorID = 14, Nome = "Fernando Araujo" });
			context.Autores.Add(new Autor { AutorID = 15, Nome = "Cristiano Chiocca" });
			context.Autores.Add(new Autor { AutorID = 16, Nome = "Fernando Chiocca" });
			context.Autores.Add(new Autor { AutorID = 17, Nome = "Pedro Duarte Jr" });
			context.Autores.Add(new Autor { AutorID = 18, Nome = "Renato Drummond" });
			context.Autores.Add(new Autor { AutorID = 19, Nome = "Thiago Pinheiro" });
			context.Autores.Add(new Autor { AutorID = 20, Nome = "Beatriz C. Lopes" });
			context.Autores.Add(new Autor { AutorID = 21, Nome = "Luciana Lopes" });
			context.Autores.Add(new Autor { AutorID = 22, Nome = "Tesoureiro" });
	
			#endregion

			#region Save

			context.SaveChanges();

			#endregion

		}
	}
}