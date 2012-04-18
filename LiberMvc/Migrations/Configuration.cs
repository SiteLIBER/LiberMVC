namespace LiberMvc.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
	using LiberMvc.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LiberMvc.Models.LiberDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LiberMvc.Models.LiberDB context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

					#region GrauInstrucao

					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Selecione o Grau de Instru��o" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Ensino Fundamental (1� a 8�) [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Ensino Fundamental (1� a 8�)" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Ensino M�dio (Colegial) [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Ensino M�dio (Colegial)" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Ensino M�dio (Magist�rio) [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Ensino M�dio (Magist�rio)" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Superior - T�cnica [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Superior - T�cnica" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Superior - Gradua��o [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Superior - Gradua��o" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Especializa��o e extens�o [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Especializa��o e extens�o" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "P�s-gradua��o [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "P�s-gradua��o" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "MBA [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "MBA" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Mestrado [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Mestrado" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Doutorado [Incompleto]" });
					context.GrauInstrucao.AddOrUpdate(new GrauInstrucao { Descricao = "Doutorado" });

					#endregion

					#region EstadoCivil

					context.EstadoCivil.AddOrUpdate(new EstadoCivil { Descricao = "Selecione o Estado Civil" });
					context.EstadoCivil.AddOrUpdate(new EstadoCivil { Descricao = "Solteiro (a)" });
					context.EstadoCivil.AddOrUpdate(new EstadoCivil { Descricao = "Casado (a)" });
					context.EstadoCivil.AddOrUpdate(new EstadoCivil { Descricao = "Divorciado (a)" });
					context.EstadoCivil.AddOrUpdate(new EstadoCivil { Descricao = "Vi�vo (a)" });
					context.EstadoCivil.AddOrUpdate(new EstadoCivil { Descricao = "Outros" });

					#endregion

					#region TipoPostagem

					context.TiposPostagem.AddOrUpdate(new TipoPostagem { TipoPostagemID = 1, Descricao = "Blog" });
					context.TiposPostagem.AddOrUpdate(new TipoPostagem { TipoPostagemID = 2, Descricao = "Artigo" });
					context.TiposPostagem.AddOrUpdate(new TipoPostagem { TipoPostagemID = 3, Descricao = "Video" });

					#endregion

					#region Titulos

					context.Titulos.AddOrUpdate(new Titulo { TituloID = 1, Nome = "Usu�rio", Codigo = "Usuario" });
					context.Titulos.AddOrUpdate(new Titulo { TituloID = 2, Nome = "Filiado", Codigo = "Filiado" });
					context.Titulos.AddOrUpdate(new Titulo { TituloID = 3, Nome = "Administrador", Codigo = "Admin" });
					context.Titulos.AddOrUpdate(new Titulo { TituloID = 4, Nome = "Editor", Codigo = "Editor" });

					#endregion

					#region Paginas

					#region submenu: nossoPartido
					var nossoPartido = @"
 <div id=""index"">
            <h1>Nosso Partido</h1>
					<ul>
						<li><a href=""/Liber/Historia"">Hist�ria</a></li>
						<li><a href=""/Liber/Filosofia"">Filosofia</a></li>
						<li><a href=""/Liber/Programa"">Programa</a></li>
						<li><a href=""/Liber/Estatuto"">Estatuto</a></li>
						<li><a href=""/Liber/Lideranca"">Lideran�as Nacionais</a></li>
						<li><a href='/Liber/Contas'>Presta��o de Contas</a></li>
					</ul>
         </div>
";
					#endregion

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 1,
						Titulo = "Hist�ria",
						Link = "Historia",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = nossoPartido + @"
        <p>

            A ideia de criar o Libert�rios surgiu na rede social Orkut.

            Foi criada uma comunidade e interessados come�aram a entrar.

            Por l� mesmo come�amos a esbo�ar nossas propostas, todas advindas

            da aplica��o do Libertarianismo. A primeira gera��o do partido

            come�ou a estudar a lei eleitoral e exemplos para descobrir

            como fundar um partido no Brasil. Al�m disso, foi criado um site,

            mas toda a movimenta��o ocorria ainda nessa comunidade.

        </p>



        <p>

            O segundo momento marcante na nossa hist�ria aconteceu em Belo

            Horizonte em Junho de 2009. Nessa ocasi�o os fundadores realizaram uma

            conven��o nacional para fundar o LIBER. Nesse evento foi aprovado o

            nosso estatuto, nosso programa e tamb�m foi eleito um diret�rio

            nacional com o objetivo de se responsabilizar oficialmente pelo

            LIBER e perseguir os passos para sua funda��o.

        </p>



        <p>

            Em 19 de janeiro de 2010 conseguimos publicar o nosso estatuto e programa no

            Di�rio Oficial da Uni�o, nos tornando assim oficialmente um partido,

            mas ainda nesse momento em organiza��o.

        </p>



        <p class=""image"">

            <img src=""/Content/images/fundacao.jpg"" alt=""Funda��o"" /><br />

            <span class=""legend"">Reuni�o de funda��o do LIBER, 20 de Junho de 2009.</span>

        </p>



        <p>

            Em Abril de 2010 realizamos nossa segunda conven��o nacional e nela

            foi corrigido alguns rumos do LIBER. Desde l� passamos a tentar

            profissionalizar as atividades partid�rias e nos posicionar

            de forma mais adequada.

        </p>



        <p>

            Nosso CNPJ que nos permite abrir conta e banco e fazer compras

            em nome da institui��o partido Libert�rios foi alcan�ado em janeiro

            de 2011, completando assim a primeira etapa da funda��o

            de um partido, que � o registro civil.

        </p>



        <p>

            Nesse exato momento estamos nos organizando para concluir a segunda etapa,

            que � recolher cerca de 500 mil assinaturas de apoio ao registro do partido

            Libert�rios no TSE. Se voc� tem disposi��o e quer ver a liberdade

            triunfando no Brasil, ajude-nos nessa tarefa.

        </p>



        <ul class=""annexes"">

            <li class=""pdf_file"">

                <a id=""A1"" href=""/Content/download/carta_helio_beltrao.pdf"" target=""_blank"">Carta de Helio Beltrao em apoio a funda��o do LIBER.</a>

            </li>

            <li class=""pdf_file"">

                <a href=""/Content/download/Ata_CGNacional_2010.04.10.pdf"" target=""_blank"">

                    Ata da Conven��o Geral do Diret�rio Nacional do

                    Libert�rios em Porto Alegre na data de 10 de abril de

                    2010.

                </a>

            </li>

            <li class=""pdf_file"">

                <a href=""/Content/download/fundacao.pdf"" target=""_blank"">Veja a ata de funda��o aqui.</a>

            </li>

        </ul>
"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 2,
						Titulo = "Filosofia",
						Link = "Filosofia",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = nossoPartido + @"
		<p>

			O LIBER � uma institui��o de atua��o pol�tica, sem fins lucrativos, 

			que visa difundir os preceitos do Libertarianismo, doutrina filos�fica 

			baseada nos princ�pios da n�o agress�o e da auto-propriedade.

		</p>



		<p>

			O Libertarianismo defende a maximiza��o das liberdades individuais, 

			devolvendo �s pessoas o direito de determinar a condu��o de suas vidas 

			e de realizar suas escolhas de acordo com suas pr�prias consci�ncias, 

			desde que sem iniciar agress�o contra terceiros, possibilitando, assim, 

			o pleno desenvolvimento de suas capacidades e felicidade.

		</p>



		<p>

			O Libertarianismo abomina qualquer interven��o violenta na vida e nas 

			escolhas das pessoas, seja ela promovida por outros indiv�duos ou por grupos. 

			Ademais, sempre que o estado viola o direito dos indiv�duos de dispor 

			do pr�prio tempo e de seus bens, o resultado � desastroso - mis�ria, 

			escassez e guerras. Assim, o LIBER acredita que em um Livre Mercado 

			de bens e ideias, todos os indiv�duos s�o beneficiados, independentemente 

			de sua aptid�o f�sica, classe social ou grau de instru��o.

		</p>



		<p>

			O LIBER acredita que uma sociedade baseada na coopera��o volunt�ria 

			� uma sociedade mais justa, solid�ria, coesa e pr�spera. Da mesma forma, 

			o LIBER entende que qualquer tentativa de criar justi�a, solidariedade, 

			coes�o ou prosperidade baseada na imposi��o, no uso de for�a, em amea�as 

			ou em san��es � absurda, imoral e sempre resultar� no exato oposto - na 

			sociedade em que vivemos hoje, uma sociedade dividida, onde reina 

			a pobreza, a indiferen�a e a injusti�a.

		</p>



		<p>

			O LIBER movimenta-se para tornar-se um partido pol�tico, ampliando, assim, 

			seu leque de atua��o, de forma a permitir a difus�o do Libertarianismo 

			dentro da pr�pria ""m�quina estatal"".

		</p>
"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 3,
						Titulo = "Programa",
						Link = "Programa",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = nossoPartido + @"
        <p>

            N�s, os Libert�rios, defendemos:

        </p>



        <p>

            <strong>Quanto � Organiza��o do Estado:</strong> descentraliza��o administrativa e real

            federalismo; redu��o dr�stica da carga tribut�ria; simplifica��o dos impostos;

            fim da progressividade tribut�ria e das cobran�as em cascata.

        </p>



        <p>

            <strong>Quanto aos Direitos Individuais:</strong> o direito de propriedade � o

            direito individual essencial e n�o pode ser relativizado em nenhuma hip�tese.

            Negamos a fun��o social da propriedade e a fun��o social dos contratos.

            A liberdade de escolha do indiv�duo n�o pode ser suprimida, salvo em caso de

            les�o ao direito de outrem. Defendemos, ainda, a descriminaliza��o dos

            ""crimes sem v�tima""; descriminaliza��o do uso de drogas;

            legaliza��o de jogos de azar; uni�o civil entre quaisquer cidad�os e

            liberdade de formas do casamento; fim do alistamento militar obrigat�rio;

            fim da discrimina��o oficial estabelecida pelas cotas raciais; garantia do

            direito � posse e porte de arma; reforma pol�tica ampla, liberdade para

            cria��o de partidos, inclusive regionais, corre��o da proporcionalidade

            na C�mara dos Deputados, fim do fundo partid�rio e fim do voto obrigat�rio;

            liberdade de imigra��o e emigra��o.

        </p>



        <p>

            <strong>Quanto aos Servi�os P�blicos:</strong> retirada do Estado da presta��o de servi�os

            p�blicos, tais como educa��o, sa�de, infra-estrutura, administra��o

            presidi�ria, entre outros.

        </p>



        <p>

            <strong>Quanto ao Sistema Econ�mico:</strong> elimina��o dos controles de sal�rios, pre�os,

            alugu�is, lucros, produ��o e juros; fim do favorecimento p�blico a setores

            privados da economia; fim do controle monet�rio com extin��o do Banco Central;

            plena liberdade econ�mica; fim dos monop�lios estatais; privatiza��o das

            empresas p�blicas e sociedades de economia mista; fim da interfer�ncia

            governamental nas rela��es trabalhistas com total liberdade entre as partes;

            liberdade de organiza��o sindical; livre mercado com circula��o de bens,

            produtos e servi�os.

        </p>


"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
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

		    Artigo 1�. O Libert�rios, cuja sigla �; LIBER, � um

		    partido pol�tico, com sede e foro na Capital Federal, dura��o

		    indeterminada, a��o em todo o territ�rio nacional e �

		    regido por este Estatuto e pela legisla��o aplic�vel.

	    </p>



	    <p>

		    Artigo 2�. O LIBER visa defender e propagar os princ�pios do Libertarianismo,

		    conforme detalhados em seu Programa, segundo os quais:

	    </p>



	    <p>

		    I. Todo indiv�duo tem direito (a) � vida, origem de todos os outros

		    direitos; (b) � liberdade de agir e buscar sua felicidade como lhe convier;

		    e (c) � propriedade, fruto leg�timo de sua vida e sua liberdade; e

	    </p>



		<p>

			II. Para que esses direitos sejam respeitados, � essencial que nenhum

			indiv�duo ou grupo inicie o uso de for�aa ou fraude contra outrem.

		</p>



		<p>

			Par�grafo �nico. Altera��es neste artigo necessitam

			aprova��o de 90% (noventa por cento) dos filiados com direito a voto

			em conven��o exclusiva para este fim.

		</p>



		<h2>Os Filiados, Seus Direitos e Deveres.</h2>



        <p>

	        Artigo 3�. Pode se filiar ao LIBER qualquer brasileiro, no pleno gozo de seus

	        direitos pol�ticos, que concorde com o Programa e o Estatuto do LIBER. &sect;

	        1�. O filiado fica vinculado ao DI Nacional e aos outros

	        cujas �reas incluam o seu domic�lio eleitoral. &sect;

            2�. O DI da menor subdivis�o far� o controle das filia��es

	        e disponibilizar� as informa��es aos DIs que o englobem.

        </p>



	    <p>

		    Artigo 4�. Os filiados t�m direito a:

	    </p>



		<p>

			I. Votar nas conven��es diretas;

		</p>



		<p>

			II. Concorrer a cargos dos DIs que participe;

		</p>



		<p>

			III. Concorrer pelo LIBER a cargos p�blicos, respeitadas as normas de

			escolha de candidatos;

		</p>



		<p>

			IV. Ser informado sobre as decis�es e finan�as do LIBER em todos

			os n�veis da federa��o; e

		</p>



		<p>

			V. Ter seus dados mantidos em sigilo, exceto conforme exigido por lei e para

			as finalidades intr�nsecas do LIBER.

            &sect; 1�. O direito indicado no inciso I acima, apenas poder� ser exercido por indiv�duos

			em dia com suas anuidades e filiados h� mais de 12 (doze) meses.

            &sect; 2�. Os direitos indicados nos incisos II a III acima, apenas

			poder�o ser exercidos por indiv�duos em dia com suas anuidades e filiados

			h� mais de 24 (vinte e quatro) meses.

		</p>



	    <p>

		    Artigo 5�. � dever dos filiados:

	    </p>



		<p>

			I. Manter conduta �tica;

		</p>



		<p>

			II. Manter atitude respeitosa com outros filiados;

		</p>



		<p>

			III. Abster-se de defender posi��es contr�rias aos princ�pios

			libert�rios; e

		</p>



		<p>

			IV. Pagar a anuidade dos DIs.

		</p>



		<p>

			Artigo 6�. A filia��o ser� cancelada nas hip�teses

			previstas em lei e por decis�o do CJ competente, da qual mais recurso.

		</p>



		<h2>Organiza��o e Funcionamento.</h2>



		<p>

			Artigo 7�. O LIBER se organiza em Diret�rios (DI) que podem existir

			nos n�veis nacional, estadual, municipal e, quando for o caso, zonal.

		</p>



		<p>

			&sect; 1�. Cada DI ter� programa e estatuto complementar aos dos

			DIs superiores;

		</p>



		<p>

			&sect; 2�. Respeitados os limites aqui previstos, cada DI ter�

			autonomia para definir sua estrutura e decidir as quest�es pertinentes ao

			seu �mbito de atua��o.

		</p>



		<p>

			Artigo �. Cada DI dever� possuir os seguintes �rg�os:

		</p>



		<p>

			I. Conven��o Geral (CG);

		</p>



		<p>

			II. Comit� Executivo (CE);

		</p>



		<p>

			III. Comit� Fiscal (CF); e

		</p>



		<p>

			IV. Comit� Julgador (CJ).

		</p>



	    <p>

		    &sect; 1�. � vedado o ac�mulo de cargos em quaisquer �rg�os

		    de um mesmo DI. Em DIs de diferentes n�veis da federa��o apenas

		    � permitido o ac�mulo de um ou mais cargos no CE (exceto se na Executiva)

		    com outro cargo qualquer.

	    </p>



		<p>

			&sect; 2�. Os membros destes �rg�os n�o receber�o

			remunera��o ou isen��o de anuidades, exceto pelo ressarcimento

			de despesas previamente autorizadas e comprovadamente incorridas no exerc�cio

			de sua fun��o.

		</p>



		<p>

			&sect; 3�. Os DIs zonais poder�o optar, em seus estatutos, por

			substituir os �rg�os previstos acima, por uma Executiva e um corpo

			de delegados.

		</p>



		<p>

			Artigo 9�. A cria��o de um DI depende da aprova��o

			deste pela CG do DI imediatamente superior.

		</p>



		<p>

			Artigo 10. Pelo voto favor�vel de 75% (setenta e cinco por cento) de

			sua CG, o DI imediatamente superior poder� dissolver o DI abaixo. A convoca��o

			desta CG dever� ser fundamentada e poder� ser questionada pelo DI

			prejudicado no CJ Nacional.

		</p>



		<h2>As Conven��es Gerais.</h2>



		<p>

			Artigo 11. Periodicamente os DIs dever�o reunir seus filiados em CGs na forma

			estabelecida neste Estatuto, as quais dever�o ser diretas nos DIs da menor

			subdivis�o do LIBER e indiretas, por meio de delegados, nos demais DIs.

		</p>



		<p>

			&sect; 1�. N�o obstante o &sect; 1� do Artigo 4�, todo filiado

			poder� comparecer e se manifestar nas CGs.

		</p>



		<p>

			&sect; 2�. Nas CGs indiretas, os DIs imediatamente inferiores poder�o

			enviar (a) 01 (um) delegado para cada 01% (um por cento) da arrecada��o

			com anuidades obtida pelo DI em quest�o, paga por filiados ao DI inferior;

			e (b) 01 (um) delegado para cada 01% (um por cento) dos votos obtidos por candidatos

			do LIBER em elei��es proporcionais da unidade da federa��o

			do DI em quest�o, na �rea correspondente �quele DI inferior;

			sempre arredondado para baixo. Se for o caso, pelo menos 02 (dois) dias �teis

			antes da CG, o DI realizar� uma reuni�o pr�via na qual votar�o

			os filiados n�o vinculados a DIs inferiores, esta reuni�o ter�

			efeitos de um DI inferior. Caso algum DI imediatamente inferior n�o totalize

			01% (um por cento) da arrecada��o e dos votos ele ter� direito

			a 01 (um) delegado.

		</p>



		<p>

			&sect; 3�. O estatuto de cada DI inferior determinar� como ser�o

			escolhidos seus delegados.

		</p>



		<p>

			&sect; 4�. Os delegados poder�o outorgar procura��es

			a outro delegado de seu DI ou enviar seu voto por escrito ao presidente da CG.

		</p>



		<p>

			Artigo 12. Compete exclusivamente �s CGs:

		</p>



		<p>

			I. Ordinariamente, nos 04 (quatro) primeiros meses de cada ano, deliberar sobre

			as demonstra��es financeiras, eleger os membros dos seus �rg�os

			e indicar os respectivos membros do CE do DI acima, nos termos do Artigo 13, &sect; 2�;

		</p>



		<p>

			II. Sempre que houver uma elei��o, definir os candidatos do respectivo

			ente federativo e, se for o caso, definir o voto dos delegados do DI na CG correspondente

			do DI acima;

		</p>



		<p>

			III. Alterar o estatuto e programa do DI;

		</p>



		<p>

			IV. Tornar definitiva a suspens�o e substituir o Presidente do CE e

			sua Executiva;

		</p>



		<p>

			V. Autorizar a cria��o ou dissolver o DI abaixo ou o respectivo

			DI e definir a destina��o de seu patrim�nio; e

		</p>



		<p>

			VI. Deliberar sobre qualquer assunto relevante, conforme decidido pelo CE.

		</p>



		<p>

			&sect; 1�. Altera��es nos programa requerem aprova��o

			de 75% (setenta e cinco por cento) dos respectivos filiados com direito a voto;

		</p>



		<p>

			&sect; 2�. As CGs ser�o convocadas pelo Presidente do CE, com pelo

			menos 30 (trinta) dias de anteced�ncia nas Nacionais, explicitando-se, na

			convoca��o, a pauta, local, data, hor�rios de in�cio

			e fim e, quando for o caso, a data e hor�rios da reuni�o pr�via

			e a quantidade de delegados de cada DI. As CGs ser�o instaladas, em primeira

			convoca��o, com a presen�aa de 25% (vinte e cinco por cento)

			dos membros com direito a voto. Salvo previsto em contr�rio, as vota��es

			da CG ser�o decididas por maioria simples, desconsiderados os votos brancos

			e nulos.

		</p>



		<h2>Comit� Executivo.</h2>



		<p>

			Artigo 13. Cada CE possuir� at� 53 (cinquenta e tr�s)

			membros, com mandato de 02 (dois) anos, com inicio no dia seguinte � confirma��o

			de sua elei��o, e ter� compet�ncia para:

		</p>



		<p>

			I. Aprovar regras gerais para a organiza��o do DI, incluindo

			procedimentos para as CGs e escolha de candidatos;

		</p>



		<p>

			II. Ratificar ou rejeitar integralmente as regras propostas pelo CF e CJ;

		</p>



		<p>

			III. Suspender por qualquer motivo o Presidente do CE;

		</p>



		<p>

			IV. Ouvido o CJ, decidir sobre alian�a eleitoral;

		</p>



		<p>

			V. Propor altera��es no estatuto e no programa do DI; e

		</p>



		<p>

			VI. Requisitar, motivadamente, a convoca��o da CG para deliberar

			sobre quaisquer assuntos.

		</p>



		<p>

			&sect; 1�. O Presidente, o Vice-Presidente e o Secret�rio do CE

			s�o eleitos concorrendo na mesma chapa e n�o poder�o ser reeleitos;

			j� os demais membros ser�o eleitos individualmente pela CG. Em at�

			05 (cinco) dias da posse o Presidente indicar�, dentre os demais membros

			do CE, o Tesoureiro e o Corregedor, que dever�o receber o aval, respectivamente,

			do CF e do CJ. Presidente, Vice-Presidente, Secret�rio, Tesoureiro e Corregedor

			do CE constituir�o a Executiva do DI.

		</p>



		<p>

			&sect; 2�. Nas CGs indiretas, os DIs imediatamente abaixo poder�o

			eleger (a) 01 (um) membro do CE para cada 04% (quatro por cento) da arrecada��o

			obtida com anuidades pelo DI em quest�o, paga por filiados ao DI inferior;

			e (b) 01 (um) membro para cada 04% (quatro por cento) dos votos obtidos por candidatos

			do LIBER em elei��es proporcionais da unidade da federa��o

			do DI em quest�o, na �rea correspondente �quele DI inferior;

			sempre arredondado para baixo. Os DIs poder�o se compor para aproveitar as

			sobras de seus votos.

		</p>



		<p>

			&sect; 3�. As reuni�es do CE ser�o convocadas pelo Presidente

			da CE, com pelo menos 10 (dez) dias de anteced�ncia e ser�o instaladas

			com a presen�aa da maioria dos seus membros. Salvo previs�o em contr�rio,

			as vota��es dos CEs ser�o decididas por maioria simples, desconsiderados

			os votos brancos e nulos. Os membros da CE poder�o outorgar procura��es

			a outro membro ou enviar seu voto por escrito ao presidente da CE.

        </p>



        <p>

            &sect; 4�. Os membros da CE permanente impedidos ser�o repostos na pr�xima CG

			Ordin�ria e os novos membros completar�o o mandato vacante. Caber�

			ao DI que indicou o membro impedido indicar seu substituto.

		</p>



		<p>

			&sect; 5�. As reuni�es do CE poder�o ser assistidas por

			qualquer filiado.

		</p>



		<p>

			Artigo 14. Compete ao Presidente:

		</p>



		<p>

			I. A administra��o ordin�ria do DI;

		</p>



		<p>

			II. Convocar e presidir as CGs e as reuni�es do CE;

		</p>



		<p>

			III. Com o aval da CF ou CJ, respectivamente, nomear e substituir o Tesoureiro

			e o Corregedor;

		</p>



		<p>

			IV. Representar o DI, ativa ou passivamente, em ju�zo ou fora dele,

			pessoalmente ou por procuradores, conforme aqui previsto.

		</p>



		<p>

			Par�grafo �nico. O Presidente ser� responsabilizado sempre

			que, por dolo ou culpa, a��es ou omiss�es no exerc�cio

			de sua fun��o trouxerem preju�zo ao LIBER ou �; sua imagem.

		</p>



		<p>

			Artigo 15. Compete ao Vice-Presidente:

		</p>



		<p>

			I. Substituir o Presidente em casos de impedimentos;

		</p>



		<p>

			II. Realizar as obriga��es do Presidente no caso de in�rcia

			deste; e

		</p>



		<p>

			III. Exercer as demais atribui��es que lhes sejam conferidas

			pelo Presidente.

		</p>



		<p>

			&sect; 1�. No caso do inciso II acima, o Vice-Presidente iniciar�

			uma representa��o contra o Presidente no CJ para que se avaliem os

			motivos da in�rcia.

		</p>



		<p>

			&sect; 2�. O Vice-Presidente ser� responsabilizado sempre que,

			por dolo ou culpa, n�o cumprir suas fun��es, especialmente

			no que trata o inciso II acima.

		</p>



		<p>

			Artigo 16. Compete ao Secret�rio:

		</p>



		<p>

			I. Participar de e registrar todas as reuni�es do CE e CGs;

		</p>



		<p>

			II. Manter as informa��es sobre filiados vinculados ao seu DI

			e, quando for o caso, repass�-las ao DI superior, resguardando o sigilo sobre

			informa��es privadas;

		</p>



		<p>

			III. Supervisionar os demais registros do DI e exercer as atribui��es

			inerentes; e

		</p>



		<p>

			IV. Salvo no caso de documentos sigilosos ou privados, zelar pela ampla divulga��o

			de seus registros e fornecer c�pias destes sempre que solicitado por qualquer

			filiado, exigindo apenas o necess�rio para cobrir os custos.

		</p>



		<p>

			&sect; 1�. No caso de impedimento tempor�rio do Secret�rio

			o Vice-Presidente assumira suas fun��es. No caso de impedimento permanente

			o Presidente indicar� o novo Secret�rio dentre os membros da CE, o

			qual dever� receber o aval da CF e do CJ.

		</p>



		<p>

			&sect; 2�. O Secret�rio ser� responsabilizado sempre que,

			por dolo ou culpa, houver informa��es incorretas em seus registros

			ou ocorrer a divulga��o de dados sigilosos ou privados.

		</p>



		<p>

			Artigo 17. Compete ao Tesoureiro:

		</p>



		<p>

			I. Manter a contabilidade e elaborar as demonstra��es financeiras

			do exerc�cio encerrado, conforme os princ�pios de contabilidade geralmente

			aceitos no Brasil e a legisla��o aplic�vel;

		</p>



		<p>

			II. Controlar o pagamento e inadimpl�ncia dos filiados;

		</p>



		<p>

			III. Assinar, com o Presidente, quaisquer documentos que impliquem responsabilidade

			financeira do DI; e

		</p>



		<p>

			IV. Informar o CF periodicamente e sempre que solicitado sobre a situa��o

			financeira e os gastos DI e auxiliar o CF em suas atribui��es.

		</p>



		<p>

			&sect; 1�. As demonstra��es financeiras anuais dever�o

			indicar com clareza a participa��o de cada DI inferior na arrecada��o

			com anuidades obtida pelo DI em quest�o. Esta participa��o

			ser� utilizada para a os c�lculos indicados no item (a) do Artigo

			11�, &sect; 2� e do Artigo 13, &sect; 2�.

		</p>



		<p>

			&sect; 2�. O Tesoureiro ser� responsabilizado sempre que, por dolo

			ou culpa, deixar de prestar informa��es relevantes ao CF, houver informa��es

			incorretas em seus registros ou o DI sofrer preju�zo financeiro.

		</p>



		<p>

			Artigo 18. Compete ao Corregedor:

		</p>



		<p>

			I. Supervisionar o andamento das atividades relevantes da Executiva;

		</p>



		<p>

			II. Aconselhar a Executiva em quest�es que envolvam a �tica e

			disciplina partid�ria;

		</p>



		<p>

			III. Exercer a presid�ncia do DI no impedimento do Presidente e do Vice-Presidente;

		</p>



		<p>

			IV. Assinar, com o Presidente, quaisquer documentos que impliquem vincula��o

			pol�tica do LIBER com outros partidos; e

		</p>



		<p>

			V. Informar o CJ periodicamente e sempre que solicitado sobre as atividades

			exercidas pelo CE e auxiliar o CJ em suas atribui��es.

		</p>



		<p>

			Par�grafo �nico. O Corregedor ser� responsabilizado sempre

			que, por dolo ou culpa, deixar de prestar informa��es relevantes ao

			CJ ou o DI sofrer dano � sua imagem.

		</p>



		<h2>Comit� Fiscal.</h2>



		<p>

			Artigo 19. O CF ter� 03 (tr�s) membros, com mandato de 03 (tr�s)

			anos eleitos, um a cada ano, pela CG, e ter� compet�ncia para:

		</p>



		<p>

			I. Acompanhar a movimenta��o financeira do DI;

		</p>



		<p>

			II. Auditar e opinar sobre as demonstra��es financeiras anuais;

		</p>



		<p>

			III. Auditar, organizar e enviar ao �rg�o estatal competente

			e ao DI superior, toda a presta��o de contas do DI;

		</p>



		<p>

			IV. Acompanhar e orientar a atua��o dos candidatos, parlamentares

			e executivos do �mbito do DI sobre o uso de recursos e provocar o CJ no caso

			de irregularidades; e

		</p>



		<p>

			V. Elaborar e propor � CE regras sobre assuntos de sua compet�ncia,

			como o uso de recursos, presta��o de contas e sua estrutura interna.

		</p>



		<p>

			&sect; 1�. O presidente do CF ser� escolhido por seus pares, para

			o mandato de 01 (um) ano.

		</p>



		<p>

			&sect; 2�. Em impedimento permanente de membro do CF, os demais indicar�o

			substituto provis�rio, que ocupar� o cargo at� a pr�xima

			CG Ordin�ria, a qual eleger� o substituto para completar o mandato

			vacante. Caso a maioria dos membros esteja permanentemente impedida (com ou sem

			substitutos provis�rios) ser� convocada imediatamente uma CG para

			eleger os substitutos permanentes.

		</p>



		<p>

			&sect; 3�. As decis�es do CF s�o tomadas por maioria dos

			votos, cabendo ao seu presidente o voto de desempate. As demais regras para reuni�o

			ser�o definidas da forma prevista neste Estatuto.

		</p>



		<h2>Comit� Julgador.</h2>



		<p>

			Artigo 20. O CJ ter� 05 (cinco) membros, com mandato de 05 (cinco)

			anos eleitos, um a cada ano, pela CG, e ter� compet�ncia para:

		</p>



		<p>

			I. Sempre que provocado por qualquer interessado, julgar conflitos internos

			do DI e aplicar san��es;

		</p>



		<p>

			II. Analisar previamente candidaturas a cargos p�blicos, com o objetivo

			de impedir o aparelhamento do partido ou seu uso para obter cargos p�blicos

			independentemente do compromisso com as ideias libert�rias.

		</p>



		<p>

			III. Analisar e opinar sobre as propostas de alian�aa partid�ria;

		</p>



		<p>

			IV. Acompanhar e orientar a atua��o dos filiados ao DI no tocante

			� coer�ncia com o Programa e os princ�pios libert�rios; e

		</p>



		<p>

			V. Elaborar e propor � CE regras sobre assuntos de sua compet�ncia,

			como a organiza��o de julgamentos, aplica��o de san��es

			e sua estrutura interna.

		</p>



		<p>

			&sect; 1�. O presidente do CJ ser� escolhido por seus pares, para

			o mandato de 01 (um) ano.

		</p>



		<p>

			&sect; 2�. Em impedimento permanente de membro do CJ, os demais indicar�o

			substituto provis�rio, que ocupar� o cargo at� a pr�xima

			CG Ordin�ria, a qual eleger� o substituto para completar o mandato

			vacante. Caso a maioria dos membros esteja permanentemente impedida (com ou sem

			substitutos provis�rios) ser� convocada imediatamente uma CG para

			eleger os substitutos permanentes.

		</p>



		<p>

			&sect; 3�. No caso de impedimento permanente do Presidente e do Vice-Presidente

			do CE o presidente do CJ imediatamente convocar� uma CG para a elei��o

			da nova Executiva.

		</p>



		<p>

			&sect; 4�. As decis�es do CJ s�o tomadas por maioria dos votos,

			cabendo ao seu presidente o voto de desempate. As demais regras para reuni�o

			ser�o definidas da forma prevista neste Estatuto.

		</p>



		<h2>Disciplina e Fidelidade Partid�ria</h2>



		<p>

			Artigo 21. Observadas os estatutos dos demais DIs, as normas e demais disposi��es

			propostas pelo CJ e aprovadas pelo CE, os processos disciplinares do LIBER ser�o

			regidos pelo disposto neste cap�tulo.

		</p>



		<p>

			Artigo 22. Quando provado, em processo conduzido pelo CJ, garantida ampla defesa,

			que um filiado praticou qualquer das atividades indicadas abaixo, o filiado sofrer�

			a medida disciplinar cab�vel.

		</p>



		<p>

			I. Desrespeito � �tica libert�ria, �s diretrizes

			program�ticas, exerc�cio de atividade pol�tica contr�ria

			ao Programa ou qualquer forma de promo��o do Estado e de suas compet�ncias;

		</p>



		<p>

			II. Descumprimento do Estatuto ou desobedi�ncia � orienta��o

			fixada por �rg�o competente;

		</p>



		<p>

			III. Promo��o de filia��es em bloco que objetivem

			o predom�nio de pessoas ou grupos estranhos ou sem afinidade com o LIBER;

		</p>



		<p>

			IV. Pagamento coletivo da contribui��o de filiados;

		</p>



		<p>

			V. Desrespeito, agress�o ou formula��o de den�ncias

			infundadas contra outros filiados;

		</p>



		<p>

			VI. Obstru��o ao funcionamento de qualquer �rg�o

			do LIBER;

		</p>



		<p>

			VII. Abandono, sem motivo justificado por escrito, dos cargos e fun��es

			partid�rias;

		</p>



		<p>

			VIII. Improbidade no exerc�cio de cargo p�blico, fun��o

			administrativa ou em �rg�o partid�rio;

		</p>



		<p>

			IX. Infidelidade partid�ria, nos termos da lei e deste Estatuto; e

		</p>



		<p>

			X. Salvo autoriza��o expressa do CE correspondente, apoiar governos

			que contrariem os princ�pios do LIBER, principalmente atrav�s do exerc�cio

			de cargo pol�ticos.

		</p>



		<p>

			Par�grafo �nico. A infidelidade n�o ser� pun�vel,

			sempre que for motivada, de forma fundamentada, por viola��o ao inciso

			I acima realizada por �rg�o do LIBER de um DI igual ou superior �quele

			prejudicado pela infidelidade.

		</p>



		<p>

			Artigo 23. O CJ definir� a medida disciplinar cab�vel, dentre

			as listadas abaixo, conforme a severidade da infra��o, os danos causados

			ao LIBER e a primariedade do r�u.

		</p>



		<p>

			&sect; 1�. S�o medidas disciplinares:&nbsp;

		</p>



		<p>

			I. Advert�ncia p�blica;

		</p>



		<p>

			II. Suspens�o de 01 (um) a 12 (doze) meses, a qual suspende os direitos

			do filiado indicados nos incisos I a III do Artigo 4�;

		</p>



		<p>

			III. Destitui��o de fun��o em �rg�o partid�rio;

		</p>



		<p>

			IV. Perda das prerrogativas, cargos ou fun��es que exer�a

			em decorr�ncia da representa��o e da propor��o

			partid�ria, na respectiva Casa Legislativa;

		</p>



		<p>

			V. Perda de mandato; e

		</p>



		<p>

			VI. Desligamento, que acarretar� no afastamento definitivo do filiado ao LIBER.

		</p>



		<p>

			&sect; 2�. O CJ poder� cumular as medidas disciplinares.

		</p>



		<p>

			&sect; 3�. As decis�es do CJ ser�o fundamentadas e, quando for

			o caso, dever�o explicitar seu prazo e/ou condi��o de revoga��o.

		</p>



		<p>

			Artigo 24. Qualquer filiado prejudicado poder� ou, sempre que tiver

			ci�ncia, o corregedor dever� iniciar o processo disciplinar mediante

			representa��o contra o infrator na CJ da menor subdivis�o competente.

		</p>



		<p>

			Artigo 25. Salvo quando a puni��o se limitar a advert�ncia p�blica,

			o prejudicado, dentro de 15 (quinze) dias, poder� recorrer ao CJ imediatamente

			superior, o qual dever� decidir nos limites do questionamento.

		</p>



		<p>

			&sect; 1�. Se a senten�a for confirmada n�o caber� novo

			recurso; do contr�rio, o prejudicado ou o corregedor do DI contrariado poder�

			recorrer ao CJ acima do que proferiu a segunda decis�o e este decidir�

			definitivamente.

		</p>



		<p>

			&sect; 2�. A decis�o deste �ltimo CJ ser� limitada pelas

			anteriores, de forma que n�o ser� poss�vel aplicar novas penas,

			ou proferir senten�as mais gravosas ou mais brandas que as aplicadas pelas

			CJs inferiores.

		</p>



		<p>

			&sect; 3�. Caso n�o haja CJ acima dispon�vel, caber� pedido

			de reconsidera��;o ao �ltimo CJ.

		</p>



		<h2>Fontes de Recursos</h2>



		<p>

			Artigo 26. As fontes de recursos do LIBER s�o:

		</p>



		<p>

			I. Anuidades pagas pelos filiados;

		</p>



		<p>

			II. Doa��es, observada a legisla��o;

		</p>



		<p>

			III. Rendimentos decorrentes de sua atividade ou da aplica��o

			de seus recursos; e

		</p>



		<p>

			IV. Repasses p�blicos que o LIBER seja obrigado a receber.

        </p>



        <p>           

            Par�grafo �nico. As doa��es ser�o feitas diretamente

			ao DI favorecido e n�o contar�o para fins item (a) do Artigo 11�,

	        &sect; 2� e do Artigo 13, &sect; 2�.

		</p>



		<p>

			Artigo 27. O valor das anuidades ser� definido pela CG de cada DI da

			menor subdivis�o poss�vel e ser� igual para todos os filiados

			ao DI em quest�o, permitido apenas abatimentos para menores de 24 (vinte

			e quatro) anos.

        </p>



        <p>

            Par�grafo �nico. O n�o pagamento

			da anuidade n�o ser� motivo para inicio de procedimento administrativo

			e seus efeitos n�o ser�o considerados para fins de reincid�ncia.

		</p>



		<p>

			Artigo 28. A CG de cada DI que englobe outros DIs dever� definir o percentual

			da arrecada��o com anuidades dos filiados dos DIs englobados que esse

			receber� e, quando houver filiados n�o vinculados a DIs inferiores,

			tamb�m dever� definir o valor da anuidade a ser paga por estes filiados.

		</p>



	    <p>

		    &sect; 1�. O percentual definido dever� ser igual para todos os DIs

		    englobados e n�o poder� ser superior a 50% (cinquenta por cento)

		    da arrecada��o total com anuidades dos DIs imediatamente inferiores.

	    </p>



		<p>

			&sect; 2�. Quando for o caso, a anuidade cobrada por um DI superior, n�o

			poder� ser mais gravosa que a maior anuidade dos DIs imediatamente inferiores.

			Caso a maior anuidade de um DI imediatamente inferior seja reduzida, a anuidade

			do DI superior ser� reduzida sem necessidade uma CG.

		</p>



		<p>

			Artigo 29. As anuidades sempre ser�o pagas ao DI da menor subdivis�o

			poss�vel e este repassar� a porcentagem correspondente de sua arrecada��o

			com filiados ao DI imediatamente superior.

		</p>



		<p>

			Artigo 30. Os repasses p�blicos que o LIBER � obrigado a receber,

			ser�o divididos em duas partes, uma incorporada ao patrim�nio do DI

			em quest�o e outra distribu�da entre os DIs imediatamente inferiores,

			na propor��o dos votos obtidos por eles na �ltima elei��o

			proporcional do DI em quest�o.

		</p>



		<p>

			&sect; 1�. Nos termos da legisla��o vigente o DI Nacional dever�

			direcionar o valor correspondente para a cria��o e manuten��o

			de instituto ou funda��o de pesquisa e de doutrina��o

			e educa��o pol�tica.

		</p>



		<p>

			&sect; 2�. A parcela repassada aos DIs inferiores ser� maior do que

			a retida e ser� definida em CG do DI correspondente.

		</p>



		<p>

			Artigo 31. Toda a contabilidade do LIBER se� realizada conforme os termos

			definidos pelo CF, os princ�pios de contabilidade geralmente aceitos no Brasil,

			a legisla��o aplic�vel e as recomenda��es dos �rg�os estatais competentes.

		</p>



		<p>

			Artigo 32. O presidente do CF submeter� aos �rg�os estatais

			competentes, nos prazos determinados em lei, o balan�o cont�bil, a

			presta��o de contas e toda a documentos exigida por lei.

		</p>



		<h2>Disposi��es Transit�rias.</h2>



		<p>

			Artigo 33. As exig�ncias de 12 (doze) e 24 (vinte e quatro) meses de

			filia��o, previstos, respectivamente nos &sect; 1� e &sect; 2�,

			Artigo 4 acima, n�o se aplicam para indiv�duos filiados at�

			06 (seis) meses antes da obten��o do registro do partido no Tribunal

			Superior Eleitoral.

		</p>



		<p>

			Artigo 34. At� a primeira elei��o proporcional do DI correspondente

			em que participem candidatos do LIBER:

		</p>



		<p>

			I. N�o ser�o indicados delegados ou membros do CE em decorr�ncia

			do item (b) do Artigo 11�, &sect; � e do Artigo 13, &sect; 2�, de

			forma que estes �rg�os ter�o a metade de seus membros; e

		</p>



		<p>

			II. Os recursos de que trata o Artigo 28 se�o distribu�dos conforme

			a propor��o de filiados em dia com suas anuidades.

        </p>
"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 5,
						Titulo = "Lideran�as Nacionais",
						Link = "Lideranca",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
	<ul class=""formatted_list"">

		<li class=""highlight""><strong>Presidente Nacional</strong> <a href=""http://www.facebook.com/profile.php?id=100002078219123"" target=""_blank"">Bernardo Santoro Pinto Machado</a> </li>

		<li><strong>Vice-presidente Nacional</strong> <a href=""http://www.facebook.com/carlo.rocha"" target=""_blank"">Carlo Rocha</a> </li>

		<li><strong>Secret�rio Geral</strong> <a href=""http://www.facebook.com/fkirsch"" target=""_blank"">Felipe Kirsch</a> </li>

		<li><strong>Tesoureiro</strong> <a href=""http://www.facebook.com/Bruno.Paludo"" target=""_blank"">Bruno Paludo</a> </li>

		<li><strong>Rela��es P�blicas</strong> <a href=""http://www.facebook.com/luciana.lnb"" target=""_blank"">Luciana Lopes Nominato Braga</a> </li>

		<li><strong>Capta��o de Recursos</strong> <a href=""http://www.facebook.com/fkirsch"" target=""_blank"">Felipe Kirsch</a> </li>

		<li><strong>Comunica��o</strong> <a href=""http://www.facebook.com/odilon.candido"" target=""_blank"">Odilon Candido</a> </li>

		<li><strong>Marketing</strong> <a href=""http://www.facebook.com/profile.php?id=800879729"" target=""_blank"">Andr� Rufino</a> </li>

		<li><strong>Corregedora</strong> <a href=""http://www.facebook.com/luciana.lnb"" target=""_blank"">Luciana Lopes Nominato Braga</a> </li>

	</ul>

	<div style=""float: left; padding-right: 15px"">

		<h2>

			Comite Julgador</h2>

		<ul class=""formatted_list"" style=""margin: 0px;"">

			<li><a href=""http://www.facebook.com/caiomagnolc"" target=""_blank"">Caio Magno Lima Campos</a></li>

			<li><a href=""http://www.facebook.com/chiocca"" target=""_blank"">Fernando Fiori Chiocca</a></li>

			<li><a href=""http://www.facebook.com/filipeceleti"" target=""_blank"">Filipe Rangel Celeti</a></li>

			<li><a href=""http://www.facebook.com/profile.php?id=100001335191421&ref=ts"" target=""_blank"">Pedro Henrique Ferreira Gonz�lez</a></li>

			<li><a href=""http://www.facebook.com/rchiocca"" target=""_blank"">Roberto Fiori Chiocca</a></li>

		</ul>

	</div>

	<div style=""float: left; padding-right: 15px"">

		<h2>

			Comite Fiscal</h2>

		<ul class=""formatted_list"" style=""margin: 0px;"">

			<li><a href=""http://www.facebook.com/profile.php?id=100001878387467"" target=""_blank"">Geraldo Boz Junior</a></li>

			<li><a href=""http://www.facebook.com/heliob"" target=""_blank"">H�lio Marcos Coutinho Beltr�o</a></li>

			<li><a href=""http://www.facebook.com/profile.php?id=100000921473730"" target=""_blank"">Thiago Pinheiro de Souza</a></li>

		</ul>

	</div>

	<div style=""float: left"">

		<h2>

			Comite Executivo</h2>

		<ul class=""formatted_list"" style=""margin: 0px;"">

			<li><a href=""http://www.facebook.com/profile.php?id=800879729"" target=""_blank"">Andr� Rufino</a></li>

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

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 6,
						Titulo = "Presta��o de Contas",
						Link = "Contas",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
		<iframe id=""ifr_contas"" style=""width: 100%; height: 752px;"" src=""https://spreadsheets.google.com/pub?key=0AgpZiPcMXN9wdExCSVBYRld1N2VQN3JMNUNiU2NOQ3c&hl=en&single=true&gid=0&output=html""></iframe>
"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 7,
						Titulo = "Direitos Individuais",
						Link = "Direitos",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
         <div id=""index"">

            <h1>�ndice</h1>



            <ol>

			    <li><a href=""#LiberdadeEResponsabilidade"">Liberdade e responsabilidade</a></li>

			    <li><a href=""#Crime"">Crime</a></li>

			    <li><a href=""#CrimesSemVitima"">Crimes sem v�tima</a></li>

			    <li><a href=""#GuerraContraAsDrogas"">Guerra contra as drogas</a></li>

                <li><a href=""#ODireitodepossuireportararmas"">O Direito de possuir e portar armas</a></li>

                <li><a href=""#ProtecaoAosAcusadosCriminalmente"">Prote��o aos acusados criminalmente</a></li>

                <li><a href=""#JusticaParaOIndividuo"">Justi�a para o indiv�duo</a></li>

                <li><a href=""#Juris"">J�ris</a></li>

                <li><a href=""#SoberaniaIndividual"">Soberania Individual</a></li>

                <li><a href=""#GovernoESaudeMental"">Governo e Sa�de Mental</a></li>

                <li><a href=""#LiberdadeDeComunicacao"">Liberdade de comunica��o</a></li>

                <li><a href=""#LiberdadeDeReligiao"">Liberdade de Religi�o</a></li>

                <li><a href=""#ODireitoDePropriedade"">O Direito de Propriedade</a></li>

                <li><a href=""#ODireitoDePrivacidade"">O Direito de Privacidade</a></li>

                <li><a href=""#AlistamentoEAsForcasArmadas"">Alistamento e as For�as Armadas</a></li>

                <li><a href=""#Imigracao"">Imigra��o</a></li>

                <li><a href=""#DireitosDasMulheresEAborto"">Direitos das Mulheres e Aborto</a></li>

                <li><a href=""#FamiliasECriancas"">Fam�lias e Crian�as</a></li>

                <li><a href=""#DireitosSexuais"">Direitos sexuais</a></li>

                <li><a href=""#DireitosDosIndios"">Direitos dos �ndios</a></li>

            </ol>



            <h1>Ideias</h1>



            <ul>

			    <li><a href=""/Liber/Direitos"">Direitos Individuais</a></li>

			    <li><a href=""/Liber/Economia"">Com�rcio e Economia</a></li>

			    <li><a href=""/Liber/Domestico"">Assuntos Dom�sticos</a></li>

			    <li><a href=""/Liber/Exterior"">Rela��es Exteriores</a></li>

			    

            </ul>

        </div>



        <p>

            N�o existe conflito entre a ordem p�blica e os direitos individuais. Ambos os conceitos s�o baseados no mesmo princ�pio fundamental: que nenhum indiv�duo, grupo ou governo pode iniciar agress�o contra qualquer outro indiv�duo, grupo ou governo.</p>



        <h2><a name=""LiberdadeEResponsabilidade"">1. Liberdade e responsabilidade</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> A responsabilidade pessoal � desencorajada pelo governo quando nega aos indiv�duos a oportunidade de exerc�-la. De fato, a nega��o da liberdade promove a irresponsabilidade.</p>



        <p>

            <strong>O princ�pio:</strong> Os indiv�duos devem ser livres para fazerem suas pr�prias escolhas, e devem aceitar a responsabilidade pelas consequ�ncias das mesmas. Para que os indiv�duos possam fazer suas escolhas pessoais na pr�pria vida, devem aceitar que esse direito deve ser estendido a outros individuos em suas respectivas vidas. Nossa defesa de tal direito n�o significa que necessariamente aprovamos ou desaprovamos essas escolhas. Acreditamos que as pessoas devem aceitar a responsabilidade individual pelas conseq��ncias de suas a��es.</p>



        <p>

            <strong>Solu��es:</strong> Pol�ticas libert�rias promover�o uma sociedade onde as pessoas ser�o livres para fazer suas pr�prias decis�es e aprender com elas. Revoga��o de todas as leis que presumem que o Governo sabe melhor que o indiv�duo como viver sua pr�pria vida. Encorajar a dissemina��o de informa��es pelo setor privado para ajudar os consumidores a fazerem decis�es informadas sobre produtos e servi�os. Aplica��o de leis contra fraude e falsifica��o.</p>



        <h2><a name=""Crime"">2. Crime</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O alto �ndice de crimes violentos - e a inabilidade demonstrada pelo Governo de lidar com o problema - amea�a a vida, felicidade e pertences dos brasileiros. Ao mesmo tempo, viola��es dos direitos por parte do Governo debilitam o senso de justi�a das pessoas em rela��o ao crime. Leis sobre crimes sem v�timas violam os direitos individuais e tamb�m aumentam as incid�ncias de crimes propriamente ditos.</p>



        <p>

            <strong>O princ�pio:</strong> A �nica fun��o justificada do Governo � proteger as vidas, direitos e propriedade dos cidad�os.</p>



        <p>

            <strong>Solu��es:</strong> O modo apropriado para reprimir o crime � atrav�s da aplica��o constante e imparcial de leis que protegem os direitos individuais. Apoiamos servi�os privados de prote��o e grupos comunit�rios e volunt�rios de combate ao crime, desde que tais servi�os n�o sejam compuls�rios. Luta pelo fim de leis de &quot;crimes de �dio&quot;, que punem pessoas pelos seus pensamentos e discursos, distraem dos crimes reais e promovem ressentimento, dando a alguns indiv�duos status especial sob a lei. Leis sobre crimes sem v�timas devem ser revogadas. Apoiamos mudan�as institucionais, consistentes com o respeito total aos direitos do acusado, as quais permitiriam v�timas a iniciar a��es judiciais em caso de les�o ou ofensa.</p>



        <h2><a name=""CrimesSemVitima"">3. Crimes sem v�tima</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> Atividades que afetam apenas o autor e mais ningu�m tem sido criminalizadas pelo governo por meio da codifica��o na lei de uma moralidade particular.</p>



        <p>

            <strong>O princ�pio:</strong> Somente a��es que infringem direitos ou danificam a propriedade de outros podem ser tratadas como crimes.</p>



        <p>

            <strong>Solu��es:</strong> Defesa da revoga��o de todas as leis federais, estaduais e locais que criam &quot;crimes sem v�timas?.</p>



        <p>

            Em particular, apoiamos:

        </p>



        <p>

            a) Revoga��o de todas as leis que pro�bam a produ��o, venda, posse, ou uso de drogas, e de todas as requisi��es de prescri��o m�dica para a compra de vitaminas, drogas, e subst�ncias similares; a revoga��o de todas as leis restringindo ou proibindo o uso ou venda de �lcool, requerendo sinais e tarjas de avisos sobre sa�de, fazendo gar�ons ou anfitri�es respons�veis pelo comportamento de clientes e convidados, fazendo empresas de bebidas alco�licas respons�veis por doen�as e defici�ncias de rec�m-nascidos, e fazendo casas de jogos respons�veis pelas perdas de jogadores intoxicados; a revoga��o de todas as leis ou pol�ticas autorizando a parada de motoristas sem causa prov�vel para o teste de �lcool ou uso de drogas; a revoga��o de todas as leis que pro�bam rela��es sexuais em consenso, incluindo prostitui��o e lenoc�nio, e o fim da opress�o estatal de homossexuais homens e mulheres, e que sejam respeitados todos seus direitos como indiv�duos; a revoga��o de todas as leis regulando ou proibindo a posse, uso, venda, produ��o, ou distribui��o de material de sexo expl�cito, independente de seu &quot;valor social&quot; ou conformidade com os &quot;padr�es da comunidade&quot;, revoga��o de todas as leis que pro�bam a comercializa��o de armas, bem como que restrinjam seu porte e posse;

        </p>



        <p>

            b) Revoga��o de todas as leis regulando ou proibindo o jogo;

        </p>



        <p>

        c) Revoga��o de todos os estatutos que criminalizam pessoas ou empresas que trabalham com jogos de azar ou com�rcio de material expl�cito, o que se iguala a punir comportamento pac�fico - incluindo tamb�m o com�rcio de material de sexo expl�cito;</p>



        <p>

        d) Revoga��o de todas as leis interferindo no direito de cometer suic�dio e aux�lio ao suic�dio, infringindo o direito de um indiv�duo sobre sua pr�pria vida, com remiss�o de pena para os atualmente encarcerados ou condenados por esses &quot;crimes&quot;; e </p>

        <p>e) Revoga��o de todas as leis interferindo no direito da fam�lia de optar pelo desligamento ou n�o de aparelhos que mantenham artificialmente a vida de indiv�duos em estado de morte cerebral. </p>

        <h2><a name=""GuerraContraAsDrogas"">4. Guerra contra as drogas</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O sofrimento que o abuso de certas drogas traz � deplor�vel; entretanto, a proibi��o de drogas causa mais danos que as pr�prias drogas. A chamada &quot;guerra contra as drogas&quot; � na realidade uma guerra contra o povo brasileiro. A guerra contra as drogas � uma grave amea�a � liberdade individual, � ordem p�blica, e � paz mundial.</p>



        <p>

            <strong>O princ�pio:</strong> Os indiv�duos devem ter o direito de usar drogas, seja por prop�sito medicinal ou recreativo, sem medo de repres�lia legal, e devem ser legalmente respons�veis pelas conseq��ncias de suas a��es se elas violarem os direitos de outros.</p>



        <p>

            <strong>Solu��es:</strong> O envolvimento social dos indiv�duos � essencial para resolver o problema de mau uso e abuso das subst�ncias. Educa��o popular e grupos de assist�ncia s�o abordagens melhores que a proibi��o, e apoiamos as atividades de organiza��es privadas como a melhor forma de avan�ar na quest�o. Revoga��o de todas as leis estabelecendo penalidades civis e criminais pelo uso de drogas, legalizando o mesmo.</p>

        <h2><a name=""ODireitodepossuireportararmas"" id=""ODireitodepossuireportararmas"">5. O Direito de possuir e portar armas</a></h2>

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        <p> <strong>A quest�o:</strong> Todos os n�veis de governo freq�entemente violam os direitos dos cidad�os a sua autodefesa com leis que restringem, limitam ou simplesmente pro�bem a propriedade e uso de armas de fogo. Essas &quot;leis de desarmamento&quot; s�o sempre justificadas pela falsa premissa de que elas levar�o a uma redu��o no n�vel de viol�ncia em nossa sociedade.</p>

        <p> <strong>O princ�pio:</strong> N�s somos a favor do direito de possuir e portar armas, em respeito ao direito de autodefesa do cidad�o contra criminosos e contra o Governo.</p>

        <p> <strong>Solu��es:</strong> Defesa do fim de todo tipo de restri��o, regulamenta��o para a posse, manufatura, transfer�ncia ou venda de armas de fogo ou muni��o. Rejeitar todas as leis que exijam o registro de armas de fogo ou muni��o. Fim de todas as leis de controle de armas. Fim dos departamentos, secretarias ou outras entidades criadas com o espec�fico fim de controlar o uso de armas de fogo. Condenar todo e qualquer esfor�o do Governo para banir ou restringir o uso de spray lacrimog�neo, ou quaisquer outros dispositivos de autodefesa.</p>

        <h2><a name=""ProtecaoAosAcusadosCriminalmente"">6. Prote��o aos acusados criminalmente</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> Pol�ticas de puni��o instant�nea retiram dos acusados importantes defesas contra abuso de poder governamental: j�ris e o processo judicial.</p>



        <p>

            <strong>O princ�pio:</strong> At� que as pessoas sejam provadas culpadas, todos seus direitos individuais devem ser respeitados. Somos contr�rios a qualquer concep��o de que grupos de indiv�duos s�o por natureza cidad�os de segunda-classe e a qualquer alega��o que a pol�cia possui possui compet�ncia para reconhecer pessoas que precisam de puni��o. Opomos-nos � redu��o de salvaguardas constitucionais nos direitos dos acusados criminalmente.</p>



        <p>

            <strong>Solu��es:</strong> Abolir a permiss�o do Governo de confiscar propriedades antes dos procedimentos civis ou criminais adequados. Restitui��o total para todas as perdas sofridas por pessoas presas, indiciadas, julgadas, detidas ou de qualquer outra forma prejudicadas no curso dos procedimentos criminais contra elas, quando n�o resultarm em sua condena��o. Quando forem considerados respons�veis, policiais e outros agentes do governo devem arcar com o custo dessa restitui��o. A pol�cia deve ser proibida de usar for�a excessiva sobre o desordeiro ou acusado criminalmente, lan�ando m�o do que eles consideram ser puni��o instant�nea nas ruas, ou usar de pris�o preventiva, salvo em flagrante delito. Estimulo a outras formas de restri��o cautelar diversas da pris�o preventiva O sistema judicial deve ser reformado para permitir que r�us em processos criminais e ambas as partes em processos civis possam apresentar um n�mero razo�vel de recursos aos ju�zes, sendo o atual n�mero excessivo.</p>



        <h2><a name=""JusticaParaOIndividuo"">7. Justi�a para o indiv�duo</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O sistema atual de leis criminais � baseado quase somente na puni��o e com pouco enfoque na v�tima. A v�tima, em regra, � duplamente penalizada: no momento em que � lesada pelo criminoso e quando o Governo o obriga a custear as despesas daquele atrav�s de tributos. O sistema de julgamento civil � fortemente controlado por um Estado ineficiente.</p>



        <p>

            <strong>O princ�pio:</strong> O prop�sito de um sistema de justi�a � prover a restitui��o a quem sofreu a perda � custa daqueles que causaram a perda. Nos casos de crimes violentos, um prop�sito adicional � defender a sociedade da amea�a cont�nua da viol�ncia.</p>



        <p>

            <strong>Solu��es:</strong> Apoiamos:

        </p>



        <p>

            a) a maior restitui��o poss�vel para a v�tima � custa do criminoso ou malfeitor. Priorizar o ressarcimento da v�tima com pesada indeniza��o contra o criminoso, em detrimento da pris�o do mesmo, em casos de crimes n�o-violentos. Conjugar o ressarcimento da v�tima com a pris�o do criminoso em casos de crimes violentos;</p>



        <p>

            b) afirmar o direito da v�tima de perdoar o criminoso ou malfeitor, impedindo, contudo, amea�as � v�tima para esse prop�sito; e

        </p>



        <p>

        c) estimulo a autocomposi��o e a heterocomposi��o via arbitragem.</p>



        <h2><a name=""Juris"">8. J�ris</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O direito de ser julgado por um j�ri popular � uma essencial para que os direitos individuais n�o sejam infringidos pelo Governo.</p>



        <p>

            <strong>O Princ�pio:</strong> J�ris populares devem ser compostos de volunt�rios, n�o de jurados for�ados. Ademais, o direito dos jurados de julgar n�o apenas conforme os fatos, mas de julgar a pr�pria lei deve ser reconhecido e encorajado.</p>



        <p>

            <strong>Solu��es:</strong> Em todos os casos no qual o Estado � parte, o juiz deve ser obrigado a informar os jurados de sua prerrogativa de julgar a lei, assim como os fatos, e de absolver um r�u em processo criminal ou julgar em desfavor do Estado em processos c�veis, sempre que considerarem a lei injusta ou opressiva.</p>



        <h2><a name=""SoberaniaIndividual"">9. Soberania Individual</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O Governo tem se colocado em uma posi��o de superioridade perante seus cidad�os, negando seus direitos sob o argumento do &quot;interesse p�blico&quot;, tornando-se assim a principal amea�a aos nossos direitos, em vez de seu principal protetor.</p>



        <p>

            <strong>Princ�pio:</strong> A �nica situa��o de uso leg�timo de for�a � na defesa dos direitos individuais - vida, liberdade, e a propriedade legalmente adquirida - contra agress�o, seja por for�a ou por fraude. Esse direito � inerente ao indiv�duo, o qual - com seu consentimento - pode ser ajudado por qualquer outro indiv�duo ou grupo. O direito a se defender se estende � defesa contra atos agressivos do pr�prio Governo.</p>



        <p>

            <strong>Solu��es:</strong> O Governo deve se ater ao seu papel de protetor de direitos, e ser respons�vel por suas a��es contra indiv�duos. Defesa do fim imediato de todos os institutos jur�dicos que concedem primazia do &quot;interesse p�blico&quot; civil sobre o interesse privado. Governantes eleitos e burocratas devem ser igualmente respons�veis por tais a��es, com prioridade em responsabilizar civilmente governantes e burocratas pelos danos causados pelo Governo contra os cidad�os.</p>



        <h2><a name=""GovernoESaudeMental"">10. Governo e Sa�de Mental</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> Indiv�duos s�o medicados � for�a ou tem sua medica��o negada, baseado n�o na necessidade m�dica, mas em um programa social imposto pelo Governo.</p>



        <p>

            <strong>O Princ�pio:</strong> O uso ou absten��o de medica��o deve ser volunt�ria.

        </p>



        <p>

            <strong>Solu��es:</strong> Oposi��o ao tratamento for�ado de qualquer pessoa ou interna��o for�ada em institui��o de tratamento mental. Oposi��o ao tratamento for�ado dos idosos, das pessoas com les�es na cabe�a ou daqueles com capacidade reduzida. Oposi��o � invas�o do lar e da privacidade das pessoas por agentes de sa�de ou quaisquer outros agentes do Governo. Defesa do fim do gasto de dinheiro dos pagadores de tributos para qualquer programa de tratamento psiqui�trico, psicol�gico ou de pesquisa de comportamento.</p>



        <h2><a name=""LiberdadeDeComunicacao"">11. Liberdade de comunica��o</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> A liberdade de express�o decorre diretamente do direito de autopropriedade do indiv�duo sobre seu corpo e pensamento. Somos contra qualquer cerceamento da liberdade de express�o, constantemente atacada pelo Governo.

        </p>



        <p>

            <strong>O Princ�pio:</strong> Defendemos os direitos individuais � liberdade irrestrita de express�o, liberdade de imprensa e o direito dos indiv�duos de discordar do pr�prio Governo. Reconhecemos que a liberdade total de express�o � poss�vel apenas como parte de um sistema de direitos totais de propriedade. A liberdade de usar sua pr�pria voz; a liberdade de alugar um sal�o de conven��es; a liberdade de ser propriet�rio de um jornal ou de uma esta��o de televis�o aberto ou cabo de transmiss�o; a liberdade de hospedar e publicar informa��o na Internet; a liberdade de agitar ou de queimar sua pr�pria bandeira; e liberdades similares baseadas na propriedade s�o precisamente o que constitui a liberdade de comunica��o. Ao mesmo tempo, reconhecemos que a liberdade de comunica��o n�o se estende ao uso de propriedades de outrem para promover ideias sem o consentimento de seus respectivos donos.

        </p>



        <p>

        <strong>Solu��es:</strong> Deixar ao crit�rio do livre-mercado a propriedade de frequ�ncias de ondas. Somos contra a posse estatal, subs�dio ou financiamento p�blico de qualquer organiza��o de comunica��o. A remo��o de todos esses regulamentos e pr�ticas de toda a m�dia de comunica��o abre caminho para a diversidade e inova��o. Revoga��o de qualquer lei que promova censura, regula��o ou controle de m�dias de comunica��o, tais como:</p>

        <p>a) Equipamentos de recep��o e armazenamento, tais como gravadores de fita digitais e dispositivos de radar, e a fabrica��o de terminais de v�deo por companhias telef�nicas;</p>

        <p>b) Quadros de avisos eletr�nicos, redes de comunica��o, e outras midas interativas;</p>

        <p>c) Jornais eletr�nicos, classificados eletr�nicos, arquivos de bibliotecas, sites da Internet e qualquer outra nova m�dia de informa��o, que merecem total liberdade; ou</p>

        <p>d) Comunica��o e propaganda comercial.</p>

        <p>          Fim de restri��o da linguagem em todas as escolas que recebam verbas p�blicas. Linguagem que for considerada ofensiva a certos grupos n�o deve ser causa para a��o legal.</p>

        <p>          Fim da censura pr�via via ordens judiciais que limitam a cobertura e divulga��o jornal�stica de crimes ou procedimentos criminais - o direito de publicar e transmitir n�o deve ser cerceado meramente pela conveni�ncia do sistema judicial. Deploramos quaisquer esfor�os no sentido de impor controle de opini�es � m�dia, seja pelo uso de leis antitruste, seja por qualquer outra a��o governamental que vise eliminar o &quot;preconceito&quot; da m�dia. Recha�amos controle estatal sobre pornografia.</p>

        <p>Extin��o de �rg�os governamentais que regulam os meios de comunica��o e o conte�do jornal�stico.</p>

        <p>Defesa da responsabilidade civil e penal a posteriori do conte�do divulgado pela m�dia e por seus representantes. </p>

        <h2><a name=""LiberdadeDeReligiao"">12. Liberdade de Religi�o</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O Governo rotineiramente invade os direitos de privacidade pessoal baseado somente nas cren�as religiosas dos indiv�duos.</p>



        <p>

            <strong>O Princ�pio:</strong> Defendemos o direito dos indiv�duos de participar (ou se abster de participar) de qualquer atividade religiosa que n�o viole os direitos de outras pessoas.</p>



        <p>

             <strong>A Solu��o:</strong> Perfeita separa��o entre Igreja e Estado. Fim de quaisquer a��es do Governo que favore�am ou prejudiquem qualquer religi�o.</p>



        <h2><a name=""ODireitoDePropriedade"">13. O Direito de Propriedade</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O direito de propriedade privada tem sido constantemente atacado pelo Estado, distorcendo seu conceito e relativizando seu alcance, especialmente em nome do interesse p�blico, bem com tamb�m em nome de valores est�ticos, risco, padr�es morais, estimativas de custo-benef�cio, promo��o ou restri��o de crescimento econ�mico. O Estado rotineiramente interfere na opera��o de neg�cios privados. A taxa��o de im�veis privados, na pr�tica, torna o Estado possuidor de todas as terras, for�ando os indiv�duos a pagar pelo uso de suas pr�prias casas e pontos comerciais.

        </p>



        <p>

            <strong>O Princ�pio:</strong> Todos os direitos s�o intrinsecamente ligados ao direito de propriedade. Tais direitos como a liberdade de n�o servir a algu�m involuntariamente bem como a liberdade de express�o e liberdade de imprensa s�o baseados na auto-propriedade. O direito de propriedade � um axioma inerente a exist�ncia do ser humano, em especial a auto-propriedade de seu corpo e pensamento. Nossos corpos s�o nossas propriedades tanto quanto o s�o as terras e objetos materiais legalmente adquiridos. Aquele que possui uma propriedade tem total direito de controlar, usar, dispor dela - ou de qualquer maneira usufruir de sua propriedade sem interfer�ncia, at� que e a n�o ser que, o exerc�cio desse controle infrinja direitos v�lidos de outras pessoas.

        </p>



        <p>

            <strong>Solu��es:</strong> Exigir o fim da taxa��o de propriedades imobili�rias privadas. A propriedade tem sido tomada de seus verdadeiros donos pelo Governo ou por a��o privada em viola��o dos direitos individuais; deste modo, apoiamos sua restitui��o a seus leg�timos donos. Revoga��o de quaisquer leis que relativizem o direito de propriedade, bem como regulem o  uso, frui��o e disposi��o de propriedades privadas. Revoga��o das leis que declarem preponder�ncia do ?interesse p�blico? sobre o interesse privado, principalmente quando restringem o uso da propriedade privada em nome de valores est�ticos, risco, padr�es morais, estimativas de custo-benef�cio, promo��o ou restri��o de crescimento econ�mico.

        </p>



        <h2><a name=""ODireitoDePrivacidade"">14. O Direito de Privacidade</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> As prote��es � privacidade t�m sido lentamente desgastadas ao longo dos anos. O n�mero do CPF se tornou praticamente um identificador universal, facilitando enormemente os casos de roubo de identidade. O Governo pode acessar contas banc�rias, bilhetes de viagens a�reas e conhecer todos os h�bitos de consumo de cidad�os respeitadores da lei, apenas com a fraca justificativa de que � preciso evitar crimes ou sonega��es.

        </p>



        <p>

            <strong>O Princ�pio:</strong> O direito do indiv�duo � privacidade, propriedade e o direito de falar ou n�o falar n�o deve ser infringido pelo Governo. O Governo n�o deve usar meios eletr�nicos ou de outra natureza para espionar as a��es de um indiv�duo ou sua propriedade sem o consentimento do propriet�rio ou ocupante. Correspond�ncias, transa��es banc�rias ou financeiras, registros m�dicos, comunica��es com advogados, registros de emprego outros tantos n�o devem estar abertos para o conhecimento do Governo sem o consentimento de todas as partes envolvidas nestas a��es.</p>

        <p>Arranjos contratuais privados, incluindo contratos de trabalho, devem ser fundados no consentimento m�tuo e aceita��o em uma sociedade que promove a liberdade de associa��o. Proibi��o de qualquer forma de investiga��o da vida pregressa do indiv�duo pelo Governo para fins civis, bem como de regulamenta��es que forcem empresas prestadoras de servi�o ao Governo a impor tais investiga��es.</p>

        <p>

            <strong>Solu��es:</strong> Apoio �s prote��es contra a arbitrariedade investigat�ria ou policial do Governo e oposi��o ao uso de mandados de busca para examinar ou apreender materiais pertencentes a pessoas inocentes. Fim de restri��es e regulamenta��es ao desenvolvimento privado, venda e uso de tecnologia de encripta��o. Fim de qualquer requerimento de abertura ou viola��o dos m�todos de encripta��o ou chaves, e qualquer outro requerimento for�ando o uso de dispositivos ou protocolos de comunica��o especificados pelo Governo. Fim da classifica��o governamental da pesquisa civil sobre os m�todos de encripta��o. Rejeitar propostas de aplica��o de um cart�o de identidade universal. Defesa do direito do cidad�o em n�o cooperar com o censo nacional.</p>



        <h2><a name=""AlistamentoEAsForcasArmadas"">15. Alistamento e as For�as Armadas</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O Governo promove servi�o militar obrigat�rio, um programa de trabalho compuls�rio e coercitivo para os jovens.</p>



        <p>

            <strong>O Princ�pio:</strong> For�ar indiv�duos a servir as For�as Armadas n�o � nada menos que escravid�o.

        </p>



        <p>

            <strong>Solu��es:</strong> Fim de qualquer tentativa de registro dos indiv�duos para fins de alistamento ou conscri��o e qualquer invas�o da privacidade de algu�m por meio de registros escolares, de habilita��o para dirigir e outros, para esse mesmo fim. Aboli��o de qualquer tipo de servi�o de sele��o de recrutas. Destrui��o de todos os arquivos em m�dia magn�tica, �ptica, mista, ou impressa que contenham informa��es que possam ser usadas para selecionar pessoas ao alistamento. Revoga��o de leis que punem a deser��o. Os membros das For�as Armadas devem ter o direito de deixar seu trabalho como qualquer outra pessoa. Cessa��o de guerras imperialistas promovida pela nossa na��o. Fim da exclus�o das For�as Armadas por conduta homossexual. Reconhecimento dos direitos civis dos membros das For�as Armadas. Promover o moral, a dignidade e o senso de justi�a entre os militares.

        </p>



        <h2><a name=""Imigracao"">16. Imigra��o</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

             <strong>A quest�o:</strong> Estrangeiros que fogem da opress�o de seus pa�ses e buscam melhorar de vida tentam migrar e viver no Brasil.

        </p>



        <p>

            <strong>O Princ�pio:</strong> Sustentamos que os direitos humanos n�o devem ser negados ou restringidos com base na nacionalidade. Estrangeiros sem documenta��o n�o devem ser impedidos de exercer seu direito fundamental de trabalhar e de ir e vir sem serem importunados. Ademais, a imigra��o n�o deve ser restringida por motivos de ra�a, religi�o, cren�a pol�tica, idade ou prefer�ncia sexual. � injusta a promo��o de incentivos para retornarem a seus pa�ses.</p>



        <p>

            <strong>Solu��es:</strong> Acabar com a deporta��o de cidad�os pelo Governo Federal com base na falta de documenta��o para estar no pa�s. Rejeitar todas as medidas que punem empregadores que contratem trabalhadores sem documentos de imigra��o, pois tais medidas oprimem o livre empreendimento, hostilizam os trabalhadores e sistematicamente desencorajam a contrata��o de imigrantes, legais ou n�o. Eliminar todas as restri��es � imigra��o, e anistiar totalmente aqueles que entraram no pa�s ilegalmente.</p>



        <h2><a name=""DireitosDasMulheresEAborto"">17. Direitos das Mulheres e Aborto</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> Reconhecemos que o aborto � um tema muito sens�vel e que as pessoas, incluindo os libert�rios, podem ter opini�es de boa-f� nos dois lados da quest�o. Acreditamos que o Governo n�o deve interferir nesta quest�o. Somos contra abortos pagos ou ordenados pelo Governo. � extremamente duro for�ar algu�m que acredita que o aborto � assassinato a pagar pelo aborto de outras pessoas por meio de impostos. Mulheres t�m recebido favorecimento estatal atrav�s de cotas e outros mecanismos.</p>



        <p>

            <strong>O Princ�pio:</strong> O princ�pio da n�o-inicia��o da agress�o contra outros indiv�duos � basilar na doutrina libert�ria. Como nem mesmo a ci�ncia pode afirmar se o nascituro j� � um indiv�duo aut�nomo, temos opini�es de boa-f� dos dois lados.

        </p>



        <p>

            <strong>Solu��es:</strong> Revogar todas as leis que promovam a tirania por meio de discrimina��o reversa.</p>



        <h2><a name=""FamiliasECriancas"">18. Fam�lias e Crian�as</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O envolvimento do Governo nas responsabilidades dos pais tem enfraquecido as fam�lias e substitu�do os valores familiares pelos valores ensinados pelo Governo.

        </p>



        <p>

            <strong>O Princ�pio:</strong> Fam�lias e lares s�o institui��es privadas, que devem ser livres da intrus�o ou interfer�ncia por parte do Governo. Pais ou outros guardi�es t�m o direito de educar seus filhos de acordo com seus valores e cren�as, sem interfer�ncia do Governo - a n�o ser que estes filhos estejam sendo molestados f�sica, sexual ou psicologicamente. Devido a esses direitos dos pais, um jovem pode n�o ser capaz de exercer todos os seus direitos dentro do contexto familiar. Entretanto, os jovens t�m o direito de reivindicar sua emancipa��o assumindo a administra��o e a prote��o de seus pr�prios direitos, encerrando a depend�ncia em rela��o a seus pais ou guardi�es, e assumindo todas as responsabilidades da vida adulta. Uma crian�a, um jovem, � um ser humano e, como tal, deve ser tratado com Justi�a. Os pais n�o t�m o direito de abandonar ou p�r em perigo seus filhos de maneira inconseq�ente. Sempre que os pais n�o puderem ou n�o quiserem criar seus filhos, eles devem encontrar outra pessoa para assumir a guarda deles.

        </p>



        <p>

            <strong>Solu��es:</strong> Reconhecemos que determinar quando o abuso infantil ocorre � dif�cil. Apenas as cortes locais devem ter o poder de remover uma crian�a de seu lar, com o consentimento da comunidade. Essa medida n�o � a �nica a ser tomada quando uma crian�a estiver em perigo f�sico imediato. Abolir todas as leis que impedem esses processos, notadamente aquelas que restringem os servi�os privados de ado��o. Revogar as leis que impedem a crian�a de exercer seu direito de trabalhar ou aprender. Fim da pr�tica de se deter crian�as e jovens que n�o foram acusados de nenhum crime. Extin��o dos estatutos que impedem que as crian�as e jovens tenham o mesmo tratamento e prote��es processuais dos adultos.

        </p>



        <h2><a name=""DireitosSexuais"">19. Direitos sexuais</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>A quest�o:</strong> O Governo presumiu que deve decidir sobre o que � ou n�o aceit�vel em pr�ticas sexuais dentro dos relacionamentos pessoais, impondo um c�digo particular de moral e de valores morais, retirando a escolha pessoal nesses assuntos.</p>



        <p>

            <strong>O Princ�pio:</strong> Adultos t�m o direito a fazer

            sua escolha privativa em atividades

            sexuais consensuais.

        </p>



        <p>

            <strong>Solu��es:</strong> Abolir todas as tentativas do Governo de ditar, proibir, controlar ou encorajar qualquer estilo particular de vida, de uni�o de pessoas ou qualquer rela��o contratual. Repelir leis e pol�ticas existentes que visam condenar, afirmar, encorajar ou negar estilos de vida sexual, ou quaisquer conjuntos de atitudes com rela��o a esses estilos de vida.</p>



        <h2><a name=""DireitosDosIndios"">20. Direitos dos �ndios</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>



        <p>

            <strong>O Tema:</strong> Os direitos dos �ndios t�m sido usurpados ao longo dos anos.

        </p>



        <p>

            <strong>O Princ�pio:</strong> Os indiv�duos devem ser livres para decidir e escolher

            sua pr�pria cidadania, e as tribos devem ser livres para escolher

            o n�vel de autonomia que desejam.

        </p>



        <p>

            <strong>Solu��es:</strong> Os �ndios devem ter seus direitos de propriedade restaurados, inclusive direitos de livre tr�nsito, acesso, ca�a e pesca. Os �rg�os regulamentadores dos �ndios devem ser abolidos, deixando que as pr�prias tribos e seus membros determinem seu sistema de governo. Devem ser entabuladas negocia��es para solucionar todas as quest�es entre as tribos e o Governo.</p>


"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 8,
						Titulo = "Com�rcio e Economia",
						Link = "Economia",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
	    <div id=""index"">

    	    <h1>�ndice</h1>



            <ol>

			    <li><a href=""#AEconomia"">A Economia</a></li>

			    <li><a href=""#Taxacao"">Taxa��o</a></li>

			    <li><a href=""#InflacaoEDepressao"">Infla��o e depress�o</a></li>

                <li><a href=""#FinancasEInvestimentoDeCapital"">Finan�as e investimentos de capital</a></li>

                <li><a href=""#DividaDoGoverno"">D�vidas do governo</a></li>

                <li><a href=""#Monopolios"">Monop�lios</a></li>

                <li><a href=""#Subsidios"">Subs�dios</a></li>

                <li><a href=""#BarreirasDeComercio"">Barreiras de com�rcio</a></li>

                <li><a href=""#ServicosDeUtilidadePublica"">Servi�os de utilidade p�blica</a></li>

                <li><a href=""#SindicatosENegociacoesColetivas"">Sindicatos e negocia��es coletivas</a></li>

            </ol>

    

		    <h1>Ideias</h1>



		    <ul>

			    <li><a href=""/Liber/Direitos"">Direitos Individuais</a></li>

			    <li><a href=""/Liber/Economia"">Com�rcio e Economia</a></li>

			    <li><a href=""/Liber/Domestico"">Assuntos Dom�sticos</a></li>

			    <li><a href=""/Liber/Exterior"">Rela��es Exteriores</a></li>

			    

		    </ul>

	    </div>



        <p>

            N�s acreditamos que cada pessoa tem o direito de oferecer bens e servi�os aos outros no livre mercado. Portanto, nos opomos a todas as interven��es do governo na �rea da economia. O �nico papel dos governos existentes na �rea econ�mica � o de proteger os direitos de propriedade, resolver disputar judiciais e prover uma estrutura legal na qual as trocas volunt�rias sejam protegidas.</p>

        

        <p>

        Esfor�o no sentido de redistribuir riquezas ou de controlar pela for�a o com�rcio s�o intoler�veis. A manipula��o governamental da economia cria uma classe privilegiada - aqueles que t�m acesso ao dinheiro dos impostos - e uma classe explorada - aqueles que pagam os impostos.</p>

        

        <p>

        N�s acreditamos que todos os indiv�duos t�m o direito de dispor dos frutos do pr�prio trabalho como bem entenderem e que o governo n�o tem direito de tirar-lhes essa riqueza. N�s nos opomos � caridade governamental, tais como programas assistenciais e subs�dios, mas aplaudimos veementemente os indiv�duos e organiza��es de caridade que ajudam os necessitados e contribuem em uma grande variedade de causas valorosas atrav�s de atividades volunt�rias.</p>

        

        <h2><a name=""AEconomia"">1. A economia</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        <strong>A quest�o:</strong> A interven��o do governo na economia p�e em perigo tanto a liberdade individual quanto a prosperidade material de todos os brasileiros.</p>

        

        <p>

        <strong>O princ�pio:</strong> O livre mercado, que respeita os direitos individuais nas trocas volunt�rias com outros indiv�duos, deve funcionar sem impedimentos pelo governo. O �nico papel do governo na �rea econ�mica � o de proteger os direitos de propriedade, resolver disputas judiciais e prover uma estrutura legal na qual as trocas volunt�rias sejam protegidas.</p>

        

        <p>

        <strong>Solu��es:</strong> Para assegurar a liberdade econ�mica e melhorar o bem estar econ�mico dos brasileiros, implantar�amos as seguintes pol�ticas:</p>

        

        <p>

            a.) Dram�tica redu��o tanto de impostos como de gastos do governo;

        </p>

        

        <p>

            b.) Fim dos d�ficits no or�amento;

        </p>

        

        <p>

            c.) Fim de pol�ticas monet�rias inflacion�rias;

        </p>

        

        <p>

            d.) Elimina��o de todos os impedimentos governamentais ao livre com�rcio e;

        </p>

        

        <p>

            e.) Elimina��o de todos os controles de sal�rios, pre�os, alugu�is, lucros, produ��o e juros.

        </p>

        

        <h2><a name=""Taxacao"">2. Taxa��o</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        <strong>A quest�o:</strong> A manipula��o governamental da economia cria uma classe privilegiada - aqueles com acesso ao dinheiro dos impostos - e uma classe explorada - aqueles que s�o pagadores de impostos.</p>

        

        <p>

        <strong>O princ�pio:</strong> Todas as pessoas t�m direito de manter os frutos de seu trabalho. A atividade governamental n�o deveria incluir a coleta for�ada de dinheiro ou bens dos indiv�duos em viola��o de seus direitos individuais. Concordamos com a taxa��o apenas para sustentar os servi�os necess�rios para a manuten��o da propriedade e direitos individuais. Nenhum imposto pode jamais ser justo, simples ou neutro ao livre mercado.</p>

        

        <p>

            <strong>Solu��es:</strong> Especificamente: a) apoiar o direito de qualquer indiv�duo de contestar o pagamento de impostos com base em fundamentos morais, religiosos, legais ou constitucionais; b) oposi��o a qualquer taxa��o da renda de pessoas f�sicas ou jur�dicas, incluindo a impostos sobre ganhos de capital; c) oposi��o a qualquer aumento nos impostos existentes e � cria��o de novos impostos; d) apoiar a aboli��o de todos os impostos; e) apoiar a anistia incondicional de indiv�duos que tenham sido condenados ou que s�o acusados de resist�ncia aos impostos; f) revogar todas as leis que criminalizam o n�o-pagamento de tributos; g).opor-se � servid�o coercitiva feita pelo Estado a empres�rios que funcionam como coletores de tributos de seus empregados.</p>

        

        <h2><a name=""InflacaoEDepressao"">3. Infla��o e Depress�o</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> O controle governamental sobre o dinheiro e o sistema banc�rio � a causa prim�ria da infla��o e da depress�o econ�mica.

        </p>

        

        <p>

        <strong>O princ�pio:</strong> Indiv�duos envolvidos em trocas volunt�rias devem ser livres para usar como dinheiro qualquer commodity ou item livremente acordado entre as duas partes, tais como moedas de ouro denominadas por suas unidades de peso.</p>

        

        <p>

            <strong>Solu��es:</strong> Apoiar a aboli��o de todas as leis que regulam o uso da moeda e de todas as unidades de conta compuls�rias governamentais, assim como a elimina��o de toda moeda-fiat governamental e de todas as moedas cunhadas pelo governo. Todas as restri��es � cunhagem privada de moedas devem ser abolidas, para que a cunhagem seja aberta � competi��o no livre mercado. Apoiar um sistema banc�rio livre, com irrestrita competi��o entre bancos e institui��es de dep�sito de todos os tipos. A �nica restri��o necess�ria em rela��o � infla��o monet�ria � a aplica��o consistente da prote��o geral contra fraudes aos ramos banc�rio e de cunhagem de moeda. Abolir o Banco Central e toda e qualquer institui��o e/ou interven��o que afete o cr�dito e o sistema banc�rio, como o Banco do Brasil, a Caixa Econ�mica Federal e os Bancos Estaduais. Apoiar a aboli��o do BNDES e de todas as institui��es credit�cias federais e estaduais. Para completar a separa��o entre o sistema banc�rio e o Estado, defesa de um sistema de tesouro indepentedente, no qual todos os fundos do governo s�o guardados pelo pr�prio governo e n�o depositados em bancos privados. Enquanto n�o � abolido, o Banco Central, para que a infla��o seja contida, deve imediatamente parar de expandir a base monet�ria. Como medidas provis�rias, n�s ainda apoiamos: a) a suspens�o de todas as restri��es a ramifica��es banc�rias; b) a elimina��o de todas as leis de usura; c) a remo��o de todas as restri��es aos juros pagos por dep�sitos; d) a elimina��o das leis que estabelecem requerimentos marginais para a compra e venda de seguros; e) a revoga��o de todos os outros controles do cr�dito; f) a aboli��o do controle do Banco Central sobre as reservas de bancos n�o-membros e outras institui��es de dep�sito e; g) a suspens�o da proibi��o de dep�sitos dom�sticos em moedas estrangeiras.</p>

        

        <h2><a name=""FinancasEInvestimentoDeCapital"">4. Finan�as e investimentos de capital</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        <strong>A quest�o:</strong> A regula��o governamental dos mercados de capital inibe o investimento e criam vantagens no mercado para aqueles com acesso a pol�ticos e burocratas, atrav�s de isen��es de leis contra fraude e quebras de contrato.</p>

        

        <p>

            <strong>O princ�pio:</strong> O livre mercado deve operar sem os impedimentos da regula��o governamental, embora o governo deva punir fraude, roubo e quebras de contrato sem exce��es.</p>

        

        <p>

        <strong>Solu��es:</strong> Apoiar a aboli��o de toda regula��o dos mercados financeiro e de capitais. O que deve ser punido � o roubo de informa��es ou brechas de contrato que mantenham informa��es em segredo. Abolir todas as leis que reprimem as pequenas e arriscadas especula��es de capital e todas regula��es federais do mercado de commodities. Oposi��o a quaisquer tentativas de banir ou regular o investimento na bolsa de mercadorias e futuros ou em quaisquer outros instrumentos financeiros que venham a emergir no futuro. Abolir todas as leis baseadas no obscuro conceito do &quot;insider trading&quot;. </p>

        

        <h2><a name=""DividaDoGoverno"">5. D�vidas do governo</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> O d�bito do governo for�a os indiv�duos a assumirem d�vidas em que n�o escolheram incorrer; distorce os mercados de capital e arru�na a economia.</p>

        

        <p>

            <strong>O princ�pio:</strong> O governo n�o deve assumir d�vidas nem ter posses, pois esses d�bitos s�o responsabilidades dos indiv�duos e as propriedades foram tiradas deles.</p>

        

        <p>

            <strong>Solu��es:</strong> Apoiar uma emenda constituicional requerendo que os governos federal, estaduais e municipais equilibrem suas contas. Efetivamente, uma emenda de equil�brio de or�amento deve requerer:

        </p>

        

        <p>

            a.) que nem o Congresso nem o Presidente possam ignorar essa regra;

        </p>

        

        <p>

            b.) que todos os itens de fora do or�amento sejam inclu�dos no or�amento;

        </p>

        

        <p>

            c.) que o or�amento seja equilibrado exclusivamente atrav�s do corte de gastos, n�o por aumento de impostos e;

        </p>

        

        <p>

            d.) que nenhuma exce��o deve ser feita para per�odos de emerg�ncia nacional.

        </p>

        

        <p>

            Governos enfrentando crises fiscais devem sempre pedir a morat�ria em vez de aumentar impostos. O Banco Central deve ser proibido de adquirir quaisquer seguros adicionais do governo, ajudando assim a eliminar o aspecto inflacion�rio do d�ficit.</p>

        

        <h2><a name=""Monopolios"">6. Monop�lios</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> N�s identificamos o governo como a causa do monop�lio, atrav�s da concess�o de privil�gios legais a grupos de interesses na economia.</p>

        

        <p>

            <strong>O princ�pio:</strong> Leis anti-truste n�o evitam monop�lios, mas os criam por limitarem a competi��o. N�s defendemos o direito dos indiv�duos de formarem corpora��es, cooperativas e outros tipos de companhias baseadas em associa��es volunt�rias.</p>

        

        <p>

            <strong>Solu��es:</strong> Abolir todos os monop�lios coercitivos. Para aboli-los, advogamos uma estrita separa��o entre os neg�cios e o Estado. Leis de incorpora��o n�o devem incluir garantias de privil�gios monopol�sticos. Em particular, eliminar os limites especiais na responsabiliza��o de corpora��es por danos causados em transa��es contratuais e n�o contratuais. Oposi��o a limites estaduais ou federais sobre o tamanho das companhias privadas e sobre o direito das companhias de se fundirem. Oposi��o a esfor�os - em nome do ""interesse p�blico"" ou por qualquer outra raz�o - para expandir o licenceamento federal de corpora��es com o pretexto de o governo controlar as empresas. Abolir todas as leis anti-truste. Eliminar o CADE e quaisquer outras institui��es que visem limitar o tamanho das corpora��es.</p>

        

        <h2><a name=""Subsidios"">7. Subs�dios</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> A competi��o irrestrita no livre mercado

            � o melhor meio de atingir a prosperidade.

        </p>

        

        <p>

            <strong>O princ�pio:</strong> Para chegarmos a uma economia livre, na qual o governo n�o vitimize ningu�m para o benef�cio de terceiros, n�s nos opomos a todos os subs�dios a empresas, empregados, educa��o, agricultura, ci�ncia, radiodifus�o, artes, esportes ou quaisquer outros interesses especiais. Em particular, condenamos quaisquer esfor�os de forjar uma alian�a entre governo e empresas sob o pretexto de &quot;reindustrializa��o&quot; ou da &quot;pol�tica ind�strial&quot;. Al�vio ou isen��o de taxa��o ou de qualquer outra interven��o involunt�ria do governo, no entanto, n�o deve ser considerada um subs�dio.</p>

        

        <p>

            <strong>Solu��es:</strong> Aboli��o do BNDES, a principal ag�ncia nacional de subs�dio a interesses especiais com empr�stimos governamentais. Oposi��o a quaisquer garantias governamentais a empr�stimos privados. Tais garantias transferem recursos para grupos especiais tanto quanto gastos do governo propriamente ditos e, a n�vel nacional, excedem empr�stimos diretos do governo em volume total. Pagadores de impostos n�o devem nunca sustentar os custos da morat�ria de empr�stimos garantidos pelo governo. Todas as ag�ncias nacionais, estaduais e municipais cuja fun��o seja a de segurar empr�stimos devem ser abolidas ou privatizadas. Os empr�stimos de empreendimentos patrocinados pelo governo, mesmo quando n�o segurados pelo governo, constituem outra forma de subs�dio. Todos esses empreendimentos devem ser abolidos ou totalmente privatizados.</p>

        

        <h2><a name=""BarreirasDeComercio"">8. Barreiras de com�rcio</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> Tarifas e cotas servem apenas para dispensar tratamento especial a grupos favorecidos e para diminuir o bem estar dos consumidores e de outros indiv�duos. Essas medidas tamb�m reduzem o alcance dos contratos e o entendimento entre diferentes povos.</p>

        

        <p>

            <strong>O princ�pio:</strong> Indiv�duos comerciando com outros indiv�duos em outras na��es voluntariamente deve ser a �nica fonte de regula��o dos mercados internacionais. Todas as barreiras protecionistas s�o desnecess�rias e onerosas.</p>

        

        <p>

            <strong>Solu��es:</strong> Abolir todas as barreiras comerciais e todos os programas de subs�dio �s exporta��es. Essa pol�tica deve ser unilateralmente adotada, independentemente das pol�ticas comerciais de outros pa�ses.</p>

        

        <h2><a name=""ServicosDeUtilidadePublica"">9. Servi�os de utilidade p�blica</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> O envolvimento do governo na provis�o de servi�os de utilidade p�blica enfraquece o livre mercado e limita o desenvolvimento e a disponibilidade de servi�os de alta qualidade.</p>

        

        <p>

            <strong>O princ�pio:</strong> O direito de oferecer no mercado servi�os como coleta de lixo, prote��o contra inc�ndios, eletricidade, g�s natural, TV, correios, telefone ou �gua e esgoto n�o devem ser impedidos pela lei.</p>

        

        <p>

            <strong>Solu��es:</strong> Extin��o de franquias privilegiadas pelo governo e de monop�lios governamentais para esses servi�os. Todas as regula��es das ind�strias que provejam esses servi�os devem ser abolidas.</p>

        

        <h2><a name=""SindicatosENegociacoesColetivas"">10. Sindicatos e negocia��es coletivas</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> A interfer�ncia do governo na rela��o empregador/empregado imp�s um peso desnecess�rio na nossa economia, destruindo os direitos de ambos de assumir contratos no livre mercado.</p>

        

        <p>

            <strong>O princ�pio:</strong> Apoiamos o direito de pessoas livres voluntariamente estabelecerem ou associarem-se a sindicatos trabalhistas. Um empres�rio deve ter o direito de reconhecer ou de se recusar a reconhecer um sindicato como o agente de barganha coletiva de alguns ou de todos os seus empregados.</p>

        

        <p>

            <strong>Solu��es:</strong> Nos opomos � interfer�ncia governamental nas negocia��es, tais como arbitragem compuls�ria ou imposi��o de uma obriga��o de negociar. Abolir a CLT e todas as outras leis de direito ao trabalho, que pro�bem empregadores de fazerem contratos volunt�rios com sindicatos. Oposi��o a todas as ordens governamentais de recondu��o ao trabalho. Empregados e empres�rios devem ter o direito de organizar boicotes, se assim escolherem. No entanto, boicotes ou greves n�o justificam a inicia��o de viol�ncia contra outros trabalhadores, empres�rios, aqueles que n�o desejem aderir � greve e outras pessoas pac�ficas.</p>

"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 9,
						Titulo = "Assuntos dom�sticos",
						Link = "Domestico",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
 	    <div id=""index"">

    	    <h1>�ndice</h1>



            <ol>

			    <li><a href=""#Energia"">Energia</a></li>

                <li><a href=""#Poluicao"">Polui��o</a></li>

                <li><a href=""#ProtecaoAoConsumidor"">Prote��o ao Consumidor</a></li>

                <li><a href=""#Educacao"">Educa��o</a></li>

                <li><a href=""#Populacao"">Popula��o</a></li>

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

			    <li><a href=""/Liber/Economia"">Com�rcio e Economia</a></li>

			    <li><a href=""/Liber/Domestico"">Assuntos Dom�sticos</a></li>

			    <li><a href=""/Liber/Exterior"">Rela��es Exteriores</a></li>

			    

		    </ul>

	    </div>

       

        <p>

 Os problemas atuais em �reas como energia, polui��o, sa�de, cidades em decad�ncia e pobreza n�o s�o solucionados, mas causados pelo governo. O assistencialismo, supostamente desenvolvido para ajudar os pobres, � na verdade uma carga crescente e parasita carregada por todas as pessoas produtivas, e prejudica, ao inv�s de beneficiar, os pobres.

        </p>

        

        <h2><a name=""Energia"">1. Energia</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> O controle do governo sobre a ind�stria de entergia resultou em altos pre�os, apag�es, falta de competi��o, falta de explora��o e falta de desenvolvimento de fontes alternativas de energia, al�m de dar vantagem no mercado existente �queles com acesso pol�tico.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> Defendemos a cria��o de um livre mercado de petr�leo instituindo direito de propriedade sobre petr�leo subterr�neo e condenamos todos os controles pelo governo sobre a sa�da na ind�stria de petr�leo. A ind�stria de energia nuclear deve ser testada em livre mercado. Nos opomos ao controle governamental sobre o pre�o da energia, aloca��o e produ��o. Nos opomos � cria��o de uma ag�ncia de mobiliza��o na �rea de energia.

		</p>

        

        <p>

        	<strong>Solu��es:</strong> Todos os recursos en�rgicos possu�dos pelo governo devem ser privatizados. Energia nuclear deve ser desnacionalizada e as posses na ind�stria transferidas para o setor privado. Fim de todas as participa��es diretas e indiretas na ind�stria de energia nuclear, incluindo subs�dios, pesquisa e fundos para desenvolvimento, empr�stimos garantidos, subs�dios para jogar o lixo, e ag�ncias federais, civis e militares, de enriquecimento de ur�nio. Privatiza��o de todas as empresas p�blicas de prospec��o e distribui��o de petr�leo e derivados e qualquer tentativa de aumentar impostos sobre petr�leo ou a imposi��o de quotas de petr�leo. A abertura do mercado dever�, por si s�, gerar competi��o para busca de novas fontes de energia, inclusive a renov�vel.

        </p>

        

        <h2><a name=""Poluicao"">2. Polui��o</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> A polui��o do meio-ambiente � vista hoje sob uma perspectiva socialista e estatista, onde o meio-ambiente � um bem ""p�blico"" n�o pass�vel de apropria��o e os danos causados devem ser reparados mediante indeniza��o ao Estado, que nunca repassa os valores para o meio-ambiente degradado.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> A defesa da vida, liberdade e propriedade privada � o �nico papel leg�timo do Estado. A publiciza��o do meio-ambiente acarreta em inefici�ncia na sua prote��o e impede que os verdadeiros atingidos pela polui��o receba a justa indeniza��o pela viola��o da sua propriedade privada, tanto de seu corpo quanto de seus bens.

        </p>

        

        <p>

        	<strong>Solu��es:</strong> Desenvolver um sistema legal objetivo definindo os direitos de propriedade para o ar e a �gua. A defesa do meio-ambiente deve ser feita atrav�s dos propriet�rios que forem lesados ou possuam potencial para serem lesados por poluidores. O Governo n�o deve intervir na quest�o como parte, pois as indeniza��es s�o desviadas por burocratas e nunca chegam a seu destino. Extin��o de ag�ncias e �rg�os reguladores do meio-ambiente, que impedem o exerc�cio do direito de propriedade dos cidad�os.

        </p>

        

        <h2><a name=""ProtecaoAoConsumidor"">3. Prote��o ao Consumidor</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> Regula��es de prote��o ao consumidor pelo governo restringem a competi��o do livre mercado e substituem o direito de um indiv�duo fazer escolhas independentes por padr�es determinados pelo governo.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> A demanda dos consumidores deve reger a prote��o ao consumidor. Defendemos fortes e efetivas leis para que o conte�do dos produtos esteja nos lacres e defesa contra fraudes.

        </p>

        

        <p>

        	<strong>Solu��es:</strong> Extin��o de �rg�os que certificam produtos para o consumidor, passando esse encargo para entidades privadas, com elabora��o de leis que defendam os consumidores de fraudes. Extin��o de regula��es paternalistas que imp�em pre�os, definem padr�es para produtos, ou restringem a possibilidade de correr riscos e livre escolha. Extin��o de leis que obrigam o consumidor a consumir o produto ou servi�o de maneira determinada, tal como o uso de cinto de seguran�a em ve�culos automotores.

        </p>

        

        <h2><a name=""Educacao"">4. Educa��o</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> Escolas p�blicas levam � doutrina��o das crian�as ou interferem na livre escolha dos indiv�duos. Leis de educa��o compuls�ria geram escolas com muitos problemas semelhantes a pris�es.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> Educa��o, como qualquer outro servi�o, pode ser melhor executado pelo livre mercado, alcan�ando maior qualidade e efici�ncia com maior diversidade de escolha.

        </p>

        

        <p>

        	<strong>Solu��es:</strong> Defesa da completa separa��o entre educa��o e estado. Posse, opera��o, regula��o e subs�dios pelo governo de escolas, col�gios e universidades devem cessar. Fim das garantias da educa��o p�blica. Extin��o das leis de educa��o compuls�ria. Apoio � redu��o imediata de ajuda fiscal para escolas e remo��o de tributos que tenham finalidade de custear educa��o, pois cidad�os n�o s�o respons�veis pela educa��o de crian�as que n�o s�o seus filhos. Extin��o de todos os tributos que incidam no sistema educacional. Como medida transit�ria, defesa da privatiza��o das escolas p�blicas e entrega de vales-escola para as crian�as que delas necessitarem.

        </p>

        

        <h2><a name=""Populacao"">5. Popula��o</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> Observamos que as trag�dias causadas por gesta��es n�o desejadas s�o agravadas, se n�o criadas, por pol�ticas governamentais de censura, restri��o e proibi��o.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> O povo brasileiro n�o � um recurso nacional colecion�vel. Nos opomos a quaisquer medidas coercivas para controle populacional.

        </p>

        

        

        <p>

        	<strong>Solu��es:</strong> Combater a��es governamentais que compelem ou pro�bem aborto, promovem esteriliza��o ou quaisquer outras formas de controle de natalidade. Especificamente, condenar qualquer tentativa de elaborar leis que visem a esteriliza��o for�ada de miser�veis, deficientes mentais ou indiv�duos com problemas de sa�de. Revogar todas as leis que restringem a participa��o em trocas volunt�rias de mercadorias, servi�os ou informa��o relacionada � sexualidade humana, reprodu��o, controle de natalidade ou tecnologias m�dicas ou biol�gicas relacionadas ao assunto. Oposi��o a leis governamentais e pol�ticas que restrinjam a oportunidade de escolher alternativas para o aborto.

        </p>

        

        <h2><a name=""Transporte"">6. Transporte</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> A interfer�ncia do governo no transporte � caracterizada por restri��o monopol�stica, corrup��o e inefici�ncia.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> A presta��o de servi�os de transportes deve ser tratada como qualquer servi�o, sendo prestada atrav�s de mercados livres e mantida por responsabilidade judicial rigorosa.

        </p>

        

        <p>

        	<strong>Solu��es:</strong> Fim de todos os �rg�os governamentais que promovem e regulam o transporte, e transfer�ncia de suas fun��es a entidades privadas competitivas. Privatiza��o de aeroportos, ferrovias, sistemas de controle de tr�fego e estradas p�blicas. Extin��o de leis que regulam o consumo de bebidas alcoolicas no tr�nsito e fim de favores governamentais � ind�stria de automobil�stica. Extin��o de leis restringindo a competi��o da �rea automobil�stica tais como monop�lios de taxi e �nibus e a proibi��o de servi�os de micro-�nibus e vans. Defesa do transporte alternativo.

        </p>

        

        <h2><a name=""PobrezaEDesemprego"">7. Pobreza e desemprego</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> A��es fiscais e monet�rias do governo que estimulam artificialmente a expans�o dos neg�cios garantem um eventual aumento no desemprego ao inv�s de reduzi-lo. Programas do governo s�o ineficientes, paternais, humilhantes e invasivos na privacidade.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> A forma adequada de ajuda para os pobres � atrav�s de esfor�os volunt�rios de grupos privados e indiv�duos. Nenhum trabalhador deve ser legalmente penalizado pela falta de certifica��o e nenhum consumidor deve ser legalmente restrito de contratar indiv�duos n�o-licenciados.

        </p>

        

        <p>

            <strong>Solu��es:</strong> Elimina��o da obrigatoriedade de certifica��o oficial para trabalhar em qualquer �rea. Aboli��o de todas as ag�ncias governamentais e n�o-governamentais federais, estaduais e locais que restrinjam a entrada em qualquer profiss�o ou regulam sua pr�tica. Extin��o de todo aux�lio-desemprego, projetos de esmola e programas de ajuda aos pobres. Extin��o de todas as leis que impedem um indiv�duo de encontrar um emprego, tais como sal�rio m�nimo, a chamada ""legisla��o protetiva"" para mulheres e crian�as, restri��es governamentais no estabelecimento de creches, e a CLT. Fim do incentivo governamental para aposentadoria for�ada. Estimular a subtitui��o do Estado pela iniciativa privada do campo da solidariedade atrav�s de maci�os abatimentos em impostos em virtude de doa��es para entidades de caridade privadas.</p>

        <h2><a name=""LeisTrabalhistasCLTs"">8. Leis Trabalhistas (CLTs)</a></h2>

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        <p> <strong>O Assunto:</strong> As a��es arbitr�rias da Justi�a do Trabalho invadem os direitos � propriedade, elevam pre�os, geram desemprego e se imp�em injustamente sobre os geradores de emprego. Acabam por transformar empregadores em criminosos e empregados em v�timas, prejudicando a economia. </p>

        <p> <strong>O princ�pio:</strong> Essas leis negam o direito � liberdade e propriedade tanto ao empregado quanto ao empregador, e interfere em sua rela��o contratual privada. Uma sociedade de livre-comercio � baseada em trocas volunt�rias e uma troca volunt�ria s� acontece quando ambas as partes enxergam vantagens. Qualquer a��o coercitiva por parte do governo que tire o livre arb�trio dos indiv�duos e decida por eles o que � ou n�o vantajoso � errada. </p>

        <p> <strong>Solu��es:</strong> Rela��es trabalhistas s�o trocas volunt�rias entre empregado e empregador e cabe apenas �s partes envolvidas a resolu��o dos termos contratuais. Grupos ativistas de consumidores do setor privado devem ser criados para substituir ag�ncias governamentais ineficientes. Aboli��o de todas as leis trabalhistas.</p>

        <h2><a name=""PrevidenciaSocial"">9. Previd�ncia Social</a></h2>

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        <p> <strong>A quest�o:</strong> O sistema previdenci�rio � um falido e imoral esquema piramidal com valores absurdos de endividamento e possui uma taxa de retorno abaixo na m�dia para seus participantes. </p>

        <p> <strong>O princ�pio:</strong> Numa sociedade livre, o plano de aposentadoria � responsabilidade do indiv�duo e n�o do governo. </p>

        <p> <strong>Solu��es:</strong> Defendemos a substitui��o da atual previd�ncia p�blica, fraudulenta, falida e patrocinada pelo governo, por sistemas privados volunt�rios. Transitoriamente, liquida��o da previd�ncia social em fatias para institui��es financeiras privadas e venda de bens pertencentes ao poder p�blico para custear as atuais aposentadorias.</p>

        <h2><a name=""Saude"">10. Sa�de</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> O Brasil � um dos poucos pa�ses do mundo que possuem uma rede universal p�blica de seguran�a de sa�de. Em virtude dos incentivos perversos t�picos do poder p�blico, uma quantia obscena de dinheiro vilipendiado da sociedade pelo governo � destinado a um falido, imoral e ineficiente Sistema �nico de Sa�de, onde pessoas demoram horas na fila para serem atendidas. Os poucos privilegiados que conseguem pagar um plano privado de sa�de ap�s serem acharcados pelo Estado, sofrem nas m�os de um mercado altamente regulamentado por ag�ncias governamentais corruptas.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> Reconhecemos o direito dos indiv�duos, livres da interven��o do governo e seus danosos efeitos colaterais, de determinar o n�vel de seguridade que querem, o n�vel de sa�de que querem, os provedores de sa�de que querem, os rem�dios e tratamentos que querem usar e todos os outros aspectos da sa�de. O papel do governo em qualquer tipo de seguridade deve ser apenas o de fazer valer contratos quando necess�rio, n�o o de ditar �s seguradoras e consumidores quais tipos de contrato eles devem acordar voluntariamente.        </p>

        

        <p>

        	<strong>Solu��es:</strong> Restaurar e reviver um mercado livre na �rea de sa�de. Promover uma completa separa��o entre medicina e Estado. Acabar com o Sistema �nico de Sa�de e ag�ncias, como ANS e ANVISA, que controlam o mercado de sa�de e promovem monop�lio de empresas corrputoras. Todos os servi�os de sa�de s�o mais eficientemente providas pelo setor privado. Transitoriamente, privatiza��o de todos os centros m�dicos p�blicos e fornecimento de vale-sa�de para a popula��o.

        </p>

        

        <h2><a name=""UsoDosRecursos"">11. Uso dos recursos</a> naturais </h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> O governo controla o uso dos recursos atrav�s de despropria��o, leis de zona, c�digos de constru��o, c�digos de postura, controle de aluguel, estatutos urbanos e rurais, leis florestais e ambientais, entre outras medidas legais. Tais regula��es e programas violam o direito de propriedade, discriminam minorias, criam falta de moradia e tendem a inflacionar os alugu�is. Todas as restri��es governamentais sobre o uso privado ou transfer�ncia volunt�ria de direitos de �gua ou controles desp�ticos similares podem apenas agravar a m� distribui��o de �gua. 

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> O uso dos recursos � responsabilidade e direito dos donos leg�timos da terra, �gua e outros recursos naturais.

        </p>

        

        <p>

        	<strong>Solu��es:</strong> Estabelecer um sistema privado eficiente e justo de direitos sobre �gua aplicado tanto para �gua na superf�cie quanto para �gua no subsolo, baseado no princ�pio do <em>homesteading</em> (primeiro que usar). Promover a completa separa��o entre o fornecimento de �gua e o Estado, de modo a previnir crises de falta de �gua no futuro. Privatiza��o de todos os projetos e empresas de �guas governamentais. Fim de todos os �rg�os e ag�ncias destinadas ao controle de recursos naturais. Revogar todas as leis que controlam e regulam o uso dos recursos naturais.

        </p>

        

        <h2><a name=""Agricultura"">12. Agricultura</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> O mercado livre da agricultura, sistema que alimenta grande parte do mundo, foi arado por interven��es do governo. Subs�dios, regula��es e taxas encorajaram a centraliza��o do agroneg�cio. As pol�ticas de exporta��o do governo fazem com que os fazendeiros sejam ref�ns dos caprichos das administra��es p�blicas.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> Tanto fazendeiros quanto consumidores devem ser livres das intromiss�es e medidas contra-produtivas dos governos em todos os n�veis. Os cidad�os devem ser livres para plantar, vender ou comprar o que quiserem, na quantidade que quiserem, quando quiserem.

        </p>

        

        <p>

        	<strong>Solu��es:</strong> Agricultores e outros fornecedores de produtos e servi�os no mercado livre da agricultura devem operar sem qualquer regula��o governamental, enquanto s�o policiadas pelas ag�ncias de prote��o ao consumidor do setor privado com rela��o � qualidade, e devem ser punidas pelo judici�rio em casos de fraude e engana��o. Eliminar todos os programas de governo para fazendas, incluindo suporte de pre�os, subs�dios diretos e toda e qualquer regula��o na produ��o agr�cola. Desregulamentar a ind�stria de transportes, barateando o escoamento de produtos agr�colas. Fim do envolvimento do governo no controle de pestes na agricultura, que passa a ser responsabilidade dos agricultores.</p>

        

        <h2><a name=""LeisEleitorais"">13. Leis Eleitorais</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> O sistema eleitoral brasileiro � completamente distorcido. A obrigatoriedade de voto faz do mesmo um dever e n�o um direito. H� superrepresenta��o de estados pouco populosos e subrepresenta��o de estados muito populosos. A legisla��o eleitoral veda a liberdade pol�tica com restri��o ao lan�amento de candidaturas e cria��o de partidos.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> O sufr�gio � um direito e n�o um dever. Esse direito � amplo e irrestrito, devendo o eleitor possuir a maior quantiadade poss�vel de op��es.

        </p>

        

        <p>

        	<strong>Solu��es:</strong> Proposi��o de um sistema eleitoral justo, que reflita a representatividade das correntes pol�ticas no �mbito federal, estadual e local. Fim do controle governamental dos partidos politicos, permitindo liberdade de cria��o, associa��o e express�o, com possibilidade de exist�ncia de partidos regionais e locais. Fim do subs�dio p�blico aos partidos pol�ticos, em especial o fundo partid�rio. Corre��o da representa��o dos Estados na C�mara dos Deputados.

        </p>

        

        <h2><a name=""Secessao"">14. Secess�o</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

        	<strong>A quest�o:</strong> As pessoas s�o for�adas a se subordinar aos governos e participar de seus programas, geralmente como provedores de financiamento, independentemente de sua vontade.

        </p>

        

        <p>

        	<strong>O princ�pio:</strong> Como toda associa��o pol�tica deve ser volunt�ria, reconhecemos o direito de secess�o pol�tica. Isso inclui o direito de secess�o por entidades pol�ticas, grupos privados ou indiv�duos. O exerc�cio desse direito, assim como o exerc�cio de todos os outros direitos, n�o anula obriga��es legais e morais de n�o violar o direito de outros.

        </p>

        

        <p>

        	<strong>Solu��es:</strong> Defendemos o direito de entidades pol�ticas, grupos privados e indiv�duos a renunciar sua filia��o com qualquer governo, e ser dispensado das obriga��es impostas por esses governos, aceitando, em contrapartida, n�o receber nenhum suporte do governo com o qual foi feita a secess�o.

        </p>
"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 10,
						Titulo = "Rela��es Exteriores",
						Link = "Exterior",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
	    <div id=""index"">

            <h1>�ndice</h1>



		    <ul>

        	    <li style=""border:none""><a href=""#PoliticaDiplomatica""><strong>A. Politica diplom�tica</strong></a>

            	    <ul>

            		    <li><a href=""#Negociacoes"">1. Negocia��es</a></li>

                        <li><a href=""#BrasileirosNoExteriorEDireitosHumanos"">2. Brasileiros no exterior e Direitos Humanos</a></li>

                    </ul>

                </li>

            

                <li style=""border:none""><a href=""#ForcasArmadas""><strong>B. For�as Armadas</strong></a>

            	    <ul>

            		    <li><a href=""#PoliticaMilitar"">1. Pol�tica Militar</a></li>

                    </ul>

                </li>

            

                <li style=""border:none""><a href=""#PolticaEconomica""><strong>C. Pol�tica econ�mica</strong></a>

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

			    <li><a href=""/Liber/Economia"">Com�rcio e Economia</a></li>

			    <li><a href=""/Liber/Domestico"">Assuntos Dom�sticos</a></li>

			    <li><a href=""/Liber/Exterior"">Rela��es Exteriores</a></li>

			    

		    </ul>

	    </div>



        <p>

            A pol�tica externa do Brasil deve ser pautada pela manuten��o da paz e pela defesa contra qualquer forma de ataque � vida, � propriedade ou � liberdade dos cidad�os brasileiros ou em territ�rio nacional. � imperativo � qualquer a��o de defesa respeitar os direitos individuais de todas as pessoas. As rela��es entre os Estados devem ser pautadas pelo princ�pio da n�o-interven��o. O governo brasileiro deve evitar a forma��o de alinhamentos autom�ticos e se abster de realizar ou de participar de qualquer a��o imperialista, reconhecendo o direito ao livre com�rcio, viagens e imigra��o.</p>

        

        <h2><a name=""PoliticaDiplomatica"">A. Pol�tica diplom�tica</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <h2><a name=""Negociacoes"">1. Negocia��es</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> A interven��o do governo brasileiro nos assuntos de outros Estados � uma tentativa de impor nossos valores a outras na��es atrav�s da for�a, mesmo quando em a��o conjunta com outros governos.</p>

        

        <p>

        <strong>O princ�pio:</strong> O mais importante princ�pio de pol�tica externa deve ser a elimina��o da interven��o do governo brasileiro nos assuntos de outros Estados. N�o precisamos participar de nenhuma esp�cie de governo mundial para mantermos rela��es diplom�ticas com outras na��es.</p>

        

        <p>

            <strong>Solu��es:</strong> Dr�stica redu��o no custo e no tamanho de nosso corpo diplom�tico. Apoiar a retirada do Brasil das Na��es Unidas e o fim do aux�lio financeiro a essa organiza��o. Oposi��o a qualquer pol�tica que designe as Na��es Unidas como for�a policial do mundo. Oposi��o ao comprometimento de tropas nacionais em guerras sob o comando da ONU. Oposi��o a assinatura de qualquer tratado que possibilite a viola��o dos direitos individuais.</p>

        

        <h2><a name=""BrasileirosNoExteriorEDireitosHumanos"">2. Brasileiros no exterior e direitos humanos</a></h2>



        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> Governos estrangeiros podem violar os direitos dos brasileiros que se encontram ou possuem propriedades no exterior, assim como esses governos violam os neg�cios de seus pr�prios cidad�os. Entretanto, qualquer esfor�o para estender a prote��o do governo do Brasil aos cidad�os brasileiros que se encontram ou possuem propriedades sob jurisdi��o de outros Estados envolve risco de interven��o militar, da mesma forma que a tentativa de estender esta prote��o aos estrangeiros em geral. Em particular, a prote��o de investimentos de cidad�os ou neg�cios brasileiros no estrangeiro � uma forma injusta de aux�lio, pois implica em custos que ser�o financiados por todos os cidad�os brasileiros.</p>

        

        <p>

            <strong>O princ�pio:</strong> Condenar oficialmente toda viola��o dos direitos de propriedade, tanto de cidad�os brasileiros como de estrangeiros. Ades�o ao princ�pio de que os cidad�os de nosso pa�s assumem por conta pr�pria os riscos de viajar, viver e possuir neg�cios no exterior, seguindo o princ�pio de n�o intervir nos assuntos internos de outros pa�ses.</p>

        

        <p>

        <strong>Solu��es:</strong> Eliminar de todo e qualquer passaporte, visto ou outros pap�is exigidos para atravessar fronteiras. Informar nossos cidad�os, atrav�s das embaixadas brasileiras, que est�o sujeitos a leis estrangeiras quando viajam ou investem em outro pa�s. O governo brasileiro n�o pode isolar nossos cidad�os das leis estrangeiras quando eles se encontram fora do pa�s; nossas embaixadas n�o podem assumir a responsabilidade de proteger cidad�os das conseq��ncias de suas pr�prias condutas enquanto eles se encontram em outros Estados, da mesma forma que n�o o podem fazer com estrangeiros em geral.</p>

        

        <h2><a name=""ForcasArmadas"">B. For�as Armadas</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <h2><a name=""PoliticaMilitar"">1. Pol�tica Militar</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>	

            <strong>A quest�o:</strong> O uso potencial de armas nucleares � a maior amea�a a todos os povos do mundo. Logo, devemos buscar reduzir ao m�nimo o risco de uma guerra nuclear.</p>

        

        <p>

            <strong>O princ�pio:</strong> Qualquer pol�tica militar brasileira deve ter como objetivo aumentar a seguran�a para as vidas, a liberdade e a propriedade de seus cidad�os, que vivem em territ�rio nacional, contra o risco de um ataque externo. Esse objetivo deve ser alcan�ado ao menor custo financeiro poss�vel e sem preju�zo �s liberdades que o mesmo busca proteger.</p>

        

        <p>

            <strong>Solu��es:</strong> As armas de destrui��o em massa n�o-nucleares das for�as brasileiras devem ser substitu�das por armamentos menores, feitos para atingir alvos militares e n�o para matar milh�es de civis. Interromper qualquer tentativa governamental de criar armamentos nucleares de destrui��o em massa. Retirar tropas brasileiras que se encontram no exterior, participando das miss�es de paz da ONU. N�o h� qualquer progn�stico que indique que o povo brasileiro corra risco de sofrer um ataque militar convencional, particularmente de longas dist�ncias. Retirar o Brasil de qualquer acordo que o comprometa a participar de guerras por causa de outros governos e tamb�m o abandono de doutrinas que pregam a lideran�a do Brasil sobre os outros pa�ses da Am�rica do Sul.</p>

        

        <h2><a name=""PoliticaEconomica"">C. Pol�tica econ�mica</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <h2><a name=""AjudaInternacional"">1. Ajuda internacional</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> O governo federal utiliza a ajuda internacional como um meio para influenciar a pol�tica de outras na��es soberanas ao prestar aux�lio �s pessoas necessitadas nesses pa�ses. Isso obriga os cidad�os brasileiros a subsidiar governos e pol�ticas com as quais eles podem n�o concordar.</p>

        

        <p>	

            <strong>O princ�pio:</strong> Os indiv�duos n�o devem ser obrigados, atrav�s do

            pagamento de impostos, a financiar uma na��o ou grupo estrangeiro.

        </p>	

            

        <p>		

            <strong>A��es transit�rias:</strong> Eliminar toda forma de aux�lio militar, econ�mico, t�cnico e cient�fico, sustentada atrav�s dos impostos, a governos ou organiza��es estrangeiras. Abolir o subs�dio do governo � venda de armas. Abolir todos os �rg�os federais que tornam o cidad�o brasileiro que paga impostos um fiador das opera��es de empr�stimo relacionadas � exporta��o. Encerrar a participa��o do governo brasileiro nos c�rculos internacionais de commodities que restringem a produ��o, limitam a inova��o tecnol�gica e aumentam os pre�os. Acabar com todas as proibi��es a indiv�duos ou empresas que desejam manter neg�cios com qualquer pa�s ou organiza��o estrangeira, a menos que o neg�cio se constitua em uma amea�a direta ao povo brasileiro.</p>

	

        <h2><a name=""MoedasEstrangeiras"">2. Moedas estrangeiras</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>		

            <strong>A quest�o:</strong> O envolvimento do governo federal no mercado internacional de c�mbio solapa estabilidade do Real, cuja cota��o � modificada artificialmente, o que prejudica a liberdade dos mercados.</p>

        

        <p>		

            <strong>O princ�pio:</strong> Os cidad�os, atrav�s da liberdade de com�rcio nos mercados,

            devem constituir o �nico fator determinante do valor de bens e servi�os.

        </p>

        

        <p>	

            <strong>Solu��es:</strong> O envolvimento do governo nos mercados de c�mbio internacionais, juntamente com as reservas financeiras do Banco Central deveriam ser extintos, e o com�rcio realizado pelos setores privados deve ser o �nico fator a influenciar a cota��o da moeda. O Brasil deve liquidar as reservas em moeda estrangeira, bem como outras formas de cr�dito que gerem infla��o. O pa�s deve se retirar do Banco Mundial e do Fundo Monet�rio Internacional. Retirar o Brasil do papel de fiador de governos estrangeiros.</p>

        

        <h2><a name=""RecursosSemDono"">3. Recursos sem Dono</a></h2>

        

        <p class=""top""><a href=""#Topo"">Ir para o topo</a></p>

        

        <p>

            <strong>A quest�o:</strong> Governos e grupos internacionais reivindicam o direito aos recursos sem dono, apesar de n�o possu�rem jurisdi��o sobre esses, impondo tais reivindica��es contra indiv�duos atrav�s da for�a.</p>

        

        <p>			

            <strong>O princ�pio:</strong> Indiv�duos t�m o direito de usufruir os recursos sem dono e tamb�m de territ�rios internacionais como o oceano, a Ant�rtida e o espa�o c�smico.</p>

        

        <p>			

            <strong>Solu��es:</strong> Fim do reconhecimento de qualquer reivindica��o de governos nacionais ou organiza��es internacionais sobre territ�rios internacionais. Ajudar a desenvolver um padr�o internacional para o reconhecimento de reivindica��es a propriedade feitas por particulares como no caso das pistas de transportes, faixas de transmiss�o, direito � explora��o de min�rios, � pesca e ao cultivo em oceanos. Todas as leis, tratados e acordos internacionais que restringem ou impedem o usufruto de recursos sem dono devem ser abolidos. Recusa em aceitar o proposto Tratado sobre Direito do Mar, pois ele exclui o princ�pio da propriedade privada.</p>

"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 11,
						Titulo = "Fa�a uma doa��o",
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

			<input type=""image"" src=""https://p.simg.uol.com.br/out/pagseguro/i/botoes/doacoes/205x30-doar-azul.gif"" name=""submit"" alt=""Pague com PagSeguro - � r�pido, gr�tis e seguro!"" />

		</form>

		<p></p>
"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
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

		<strong>C�digo HTML:</strong></p>

	<pre>&lt;a href=""http://www.libertarios.com.br/""&gt;&lt;img src=""http://www.libertarios.com.br/Content/images/bannerLIBERhor01.png"" style=""border:0px;""&gt;&lt;/a&gt;</pre>

	<h2>

		Banner vertical</h2>

	<p>

		<img src=""/Content/images/bannerLIBERvert01.png"" /></p>

	<p>

		<strong>C�digo HTML:</strong></p>

	<pre>&lt;a href=""http://www.libertarios.com.br/""&gt;&lt;img src=""http://www.libertarios.com.br/Content/images/bannerLIBERvert01.png"" style=""border:0px;""&gt;&lt;/a&gt;</pre>


"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 13,
						Titulo = "LIBER 500",
						Link = "Liber500",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
        <h2>Fichas de apoio ao registro - desafio LIBER 500</h2>



        <p>O <strong>LIBER</strong> est� coletando as 500 mil assinaturas necess�rias para

           registrar o partido junto ao TSE e disputar elei��es.

           Fa�a parte dessa conquista!</p>



        <p>A assinatura desta ficha n�o representa filia��o ao partido,

           � somente um manifesto de apoio ao registro do <strong>LIBER</strong>.</p>



        <p id=""ficha_btn"">

            <a href=""/Content/download/Apoio o Registro do Partido Libert�rios.pdf"" target=""_blank"">Baixe a ficha de apoio e o manual para coleta de assinaturas</a>

        </p>



        <h2>Dados obrigat�rios:</h2>



        <ul>

            <li>Nome completo (sem abreviaturas)</li>

            <li>Nome da m�e (sem abreviaturas)</li>

            <li>Data de nascimento</li>

            <li>Assinatura (como no t�tulo de eleitor)</li>

        </ul>



        <h2>As fichas devem ser enviadas para:</h2>

			

			<address>

				<b>Bernardo Santoro</b><br />

				Rua Henrique Raffard n� 337, Bingen<br />

				Petr�polis - RJ<br />

				CEP 25665-062<br />

			</address>

"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 14,
						Titulo = "Contato",
						Link = "Contato",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
        <p>

            Em caso de d�vida, envie um e-mail para <a href=""mailto:contato@pliber.org.br"">contato@pliber.org.br</a>.

            O Secret�rio Geral encaminhar� a mensagem para o respons�vel.

        </p>



        <ul class=""formatted_list"">

            <li class=""highlight""><strong>Presidente</strong>

                <a href=""mailto:presidente@pliber.org.br"">presidente@pliber.org.br</a>

            </li>

            <li><strong>Vice Presidente</strong>

                <a href=""mailto:vice@pliber.org.br"">vice@pliber.org.br</a>

            </li>

            <li><strong>Secret�rio Geral</strong>

                <a href=""mailto:contato@pliber.org.br"">contato@pliber.org.br</a>

            </li>

            <li><strong>Corregedor</strong>

                <a href=""mailto:corregedor@pliber.org.br"">corregedor@pliber.org.br</a>

            </li>

            <li><strong>Tesouraria</strong>

                <a href=""mailto:tesouraria@pliber.org.br"">tesouraria@pliber.org.br</a>

            </li>

            <li><strong>Capta��o de Recursos</strong>

                <a href=""mailto:recursos@pliber.org.br"">recursos@pliber.org.br</a>

            </li>

            <li><strong>Comunica��o</strong>

                <a href=""mailto:sejaliber@pliber.org.br"">sejaliber@pliber.org.br</a>

            </li>

            <li><strong>Marketing</strong>

                <a href=""mailto:mkt@pliber.org.br"">mkt@pliber.org.br</a>

            </li>

            <li><strong>Rela��es P�blicas</strong>

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

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 15,
						Titulo = "Diret�rios",
						Link = "Diretorios",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
        <div style=""float: left;"">

            <h2>Regi�o Sul</h2>



            <ul class=""formatted_list"">

                <li><strong>Rio Grande do Sul</strong><br />

                    Presidente: <em>Alexsander Rosa</em><br />

                    Email para contato: <a href=""mailto:alexsander.rosa@gmail.com"">alexsander.rosa@gmail.com</a>

                </li>

                <li><strong>Santa Catarina</strong><br />

                    Presidente: <em>Andr� Poffo</em><br />

                    Email para contato: <a href=""mailto:andrehpoffo@gmail.com"">andrehpoffo@gmail.com</a>

                </li>

                <li><strong>Paran�</strong><br />

                    Presidente: <em>Geraldo Boz Junior</em><br />

                    Email para contato: <a href=""mailto:gbozjr@gmail.com"">gbozjr@gmail.com</a>

                </li>

            </ul>

        </div>



        <div style=""float: right; width: 320px;"">

            <h2>Regi�o Centro-Oeste</h2>



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

                    Presidente: <em>Andr� Ramos</em><br />

                    Email para contato: <a href=""mailto:alscramos@gmail.com"">alscramos@gmail.com</a>

                </li>

            </ul>

        </div>



        <div style=""float: left"">

            <h2>Regi�o Sudeste</h2>



            <ul class=""formatted_list"">

                <li><strong>S�o Paulo</strong><br />

                    Presidente: <em>Andr� Rufino</em><br />

                    Vice-presidente: <em>Roberto Chiocca</em><br />

                    Email para contato: <a href=""mailto:andrerrufino@gmail.com"">andrerrufino@gmail.com</a>

                </li>



                <li><strong>Minas Gerais</strong><br />

                    Presidente: <em>Caio Jos� de Oliveira Ramos</em><br />

                    Email para contato: <a href=""mailto:caio@yahoo.com.br"">caio@yahoo.com.br</a>

                </li>



                <li><strong>Rio de Janeiro</strong><br />

                    Presidente: <em>Patrick Gappo</em><br />

                    Email para contato: <a href=""mailto:patrickccg@globo.com"">patrickccg@globo.com</a>

                </li>



                <li><strong>Esp�rito Santo</strong><br />

                    Presidente: <em>Sidnei Santana Carneiro</em><br />

                    Email para contato: <a href=""mailto:sidneisc@gmail.com"">sidneisc@gmail.com</a>

                </li>

            </ul>

        </div>



        <div style=""float: right; width: 320px;"">

            <h2>Regi�o Nordeste</h2>



            <ul class=""formatted_list"">

                <li><strong>Cear�</strong><br />

                    Presidente: <em>Bruno Aguiar</em><br />

                    Email para contato: <a href=""mailto:brunobca@gmail.com"">brunobca@gmail.com</a>

                </li>

            </ul>

        </div>



        <div style=""float: right; width: 320px;"">

            <h2>Regi�o Norte</h2>



            <ul class=""formatted_list"">

                <li><strong>Amazonas</strong><br />

                    Presidente: <em>Fabiano Castanhola</em><br />

                    Email para contato: <a href=""mailto:fcastanhola@gmail.com"">fcastanhola@gmail.com</a>

                </li>



                <li><strong>Rond�nia</strong><br />

                    Presidente: <em>Joel Castro de Oliveira</em><br />

                    Email para contato: <a href=""mailto:joelcstr@gmail.com"">joelcstr@gmail.com</a> ou<br />

                    <a href=""mailto:joelcstr@hotmail.com"">joelcstr@hotmail.com</a>

                </li>



                <li><strong>Par�</strong><br />

                    Presidente: <em>Marcos Neemias Negr�o Reis</em><br />

                    Email para contato: <a href=""mailto:mneemias@gmail.com"">mneemias@gmail.com</a>

                </li>

            </ul>

        </div>
"
						#endregion
					});

					context.Paginas.AddOrUpdate(new Pagina
					{
						PaginaID = 16,
						Titulo = "Perguntas Frequentes",
						Link = "FAQ",
						Publicado = true,
						CriadoEm = DateTime.Now,
						#region Conteudo = "..."
						Conteudo = @"
        <p>

            <strong>O que � um Libert�rio?</strong>

        </p>

        

        <p>

            Um Libert�rio acredita no princ�pio da Liberdade, que voc� deve ser

            livre para tomar decis�es sobre a sua pr�pria vida desde que n�o interfira

            com os direitos b�sicos dos outros - vida, liberdade e propriedade.

        </p>

        

        <p>

            <strong>Que enfoque ter�o os Libert�rios se forem eleitos?</strong>

        </p>

        

        <p>

            Se um governo Libert�rio for eleito, ele reduzir� os impostos a um n�vel m�nimo

            e reduzir� o tamanho do Estado a um m�nimo. Ele tamb�m retiraria restri��es

            �s liberdades econ�micas e individuais e buscaria reduzir a interfer�ncia do

            governo nas diversas �reas da vida, tanto quanto poss�vel.

        </p>

        

        <p>

            <strong>E se meu parlamentar for o �nico Libert�rio ou apenas um entre poucos?</strong>

        </p>

        

        <p>

            �timo. Se indiv�duos Libert�rios forem eleitos ao Congresso

            (ou mesmo a uma C�mara de Vereadores), eles votar�o contra leis que restringem

            as liberdades pessoais e econ�micas e a favor de leis que aumentam a liberdade.

            Eles teriam uma posi��o privilegiada para divulgar a mensagem Libert�ria no Brasil.

        </p>

        

        <p>

            <strong>Mas e os programas sociais para os necessitados?</strong>

        </p>

        

        <p>

            Governo � for�a. Libert�rios acreditam numa situa��o onde todos ganham:

            uma sociedade volunt�ria onde as pessoas cooperam atrav�s do com�rcio e da caridade.

            A quest�o moral aqui � que os Libert�rios acreditam que n�o � certo tomar

            de uma pessoa � for�a para suprir as necessidades de outra. Os Libert�rios

            acreditam em minimizar os impostos e financiar o governo por outros meios,

            se poss�vel. Programas sociais para os necessitados devem ser fornecidos

            atrav�s de meios volunt�rios. For�ar os outros a ""dar"" n�o � justo nem generoso.

            O governo n�o deve decidir quem precisa de ajuda, porque o

            assistencialismo � prejudicial para algumas pessoas: ele incentiva

            a depend�ncia, a falta de iniciativa e a falta de planejamento.

            Uma economia livre produzir� mais riqueza para todos. Impostos s�o uma maneira

            de privar as pessoas de suas riquezas e da capacidade de investir

            essa riqueza em novos neg�cios, que no final das contas

            beneficiariam os mais pobres.

        </p>

        

        <p>

            <strong>Pessoas s�o ego�stas. N�o podemos depender de outros para dar aos necessitados

            por conta pr�pria. Voc�s n�o est�o sendo otimistas demais

            em rela��o � natureza humana?</strong>

        </p>

        

        <p>

            N�o. Libert�rios tamb�m s�o c�ticos sobre a natureza humana e acreditam 

            que as pessoas no governo n�o devem ter poder demais sobre os outros.

            H� muitos brasileiros generosos que fazem doa��es � caridade, mesmo agora

            com impostos altos. Pense nas possibilidades de doa��o em uma sociedade

            com impostos extremamente baixos. As pessoas se preocupam em sustentar

            suas pr�prias fam�lias e em viver responsavelmente e elas precisam ser

            livres para tomar suas pr�prias decis�es quanto ao uso de seu dinheiro.

            A maior parte das pessoas com quem convivemos s�o boas a maior

            parte do tempo - caso contr�rio a Sociedade n�o funcionaria - n�s confiamos

            nas pessoas como iguais. No entanto, quanto mais poder dermos

            aos outros, mais distorcidas as coisas ficam.

            Como Lord Acton disse, ""o Poder corrompe"".

        </p>

        

        <p>

            <strong>Voc�s n�o s�o contra os pobres? E os

            programas de ajuda governamental �s empresas?</strong>

        </p>

        

        <p>

            N�o, uma sociedade mais livre remover� os obst�culos aos desavantajados

            e os ajudar� a crescer economicamente. Os Libert�rios mudar�o a natureza

            do governo. Um grande fator para o descontrole do governo � a influ�ncia

            das grandes empresas. Nenhum grupo econ�mico deve usar o governo para

            controlar os outros ou para beneficiar seu pr�prio neg�cio. O Livre Mercado

            deve operar sem interfer�ncia. Libert�rios abolir�o subs�dios

            e restri��es � livre concorr�ncia.

        </p>

        

        <p>

            <strong>E os necessitados? Os Libert�rios defendem o ego�smo e o interesse pr�prio?</strong>

        </p>

        

        <p>

            Libert�rios acreditam que os mais necessitados em nossa sociedade s�o os mais

            prejudicados pelo sistema vigente, no qual o governo beneficia a grupos de interesse �s

            custas dos pagadores de impostos. Dinheiro que os indiv�duos poderiam estar

            direcionando para crian�as autistas, idosos pobres ou um novo neg�cio est�o

            indo para o governo que o utiliza pra manter sua estrutura inchada

            e para subsidiar ind�strias existentes.

        </p>

        

        <p>

            O governo tamb�m estabelece cart�rios que restringem o acesso a

            v�rias profiss�es. As leis trabalhistas vigentes impedem o acesso dos

            menos qualificados aos degraus mais baixos da escada do sucesso.

            Em geral, nossa sociedade como um todo � muito mais pobre do que deveria

            e sofre com a falta de oportunidades causadas pelos nossos impostos

            exorbitantes, pelas nossas leis que causam desemprego e pelo excesso de

            centraliza��o que desestimula a iniciativa pessoal.

        </p>

        

        <p>

            Libert�rios acreditam em respeitar as escolhas dos outros. Libert�rios reconhecem

            que indiv�duos sempre v�o defender seus pr�prios interesses

            em qualquer sistema de governo - inclusive o sistema vigente. � bom que as

            pessoas sejam motivadas a resolver problemas e perseguir seus desejos e necessidades,

            pois isso leva a um n�vel de inova��o e produtividade que

            beneficia a todos. No entanto, � muito melhor que o indiv�duos

            defendam seus interesses num ambiente de livre mercado ao inv�s

            de usar o poder governamental para isso.

        </p>

        

        <p>

            A motiva��o para se fazer o bem ao pr�ximo vai al�m dos motivos materiais.

            No entanto, esses motivos podem ser caracterizados como interesse pr�prio

            uma vez que o benevolente pode, por exemplo, sentir-se melhor

            consigo mesmo atrav�s do ato de bondade.

        </p>

        

        <p>

            Libert�rios acreditam que � bom e necess�rio ajudar o pr�ximo

            atrav�s de caridade privada, mas acreditamos que n�o � justific�vel

            dar poderes ao governo - ocupado por pessoas buscando seus pr�prios

            interesses - de for�ar uma pessoa a entregar grande parte de sua riqueza

            ao governo com o suposto objetivo de ajudar os outros.

        </p>

        

        <p>

            Como Ludwig von Mises diz no seu livro A��o Humana:

            ""We may fully endorse the religious and ethical precepts that declare it

            to be man's duty to assist his unlucky brethren whom nature has doomed.

            But the recognition of this duty does not answer the question

            concerning what methods should be resorted to for its performance.""

        </p>

        

        <p>

            <strong>Os Libert�rios querem fazer o Brasil ficar parecido com os Estados Unidos?</strong>

        </p>

        

        <p>

            Na verdade, n�o. Os Estados Unidos tamb�m precisam de muitas destas mesmas reformas.

        </p>

        

        <p>

            <strong>Voc�s modificariam as Leis de Defesa do Consumidor? Que Leis permaneceriam?</strong>

        </p>

        

        <p>

            Sim. Os consumidores se informariam usando avalia��es de produtos

            e servi�os dispon�veis no Livre Mercado. Os Libert�rios acreditam que o

            governo deve proteger os cidad�os e sua propriedade de assassinato,

            roubo, fraude e danos pessoais ou ambientais. Os tribunais devem estar

            dispon�veis para consumidores que buscam indeniza��o de fabricantes que

            mentem sobre seus produtos. De resto, os cidad�os devem ser

            livres para assumir seus pr�prios riscos no que diz respeito a

            produtos, materiais, subst�ncias, alimentos e drogas.

        </p>

        

        <p>

            <strong>Como os Libert�rios reformariam o Sistema Judici�rio?

            E quanto aos menores infratores?</strong>

        </p>

        

        <p>

            Os que s�o condenados por crimes devem ser penalizados de forma

            proporcional ao seus crimes, independente de idade. A identidade de

            menores condenados n�o deve ser protegida. Em caso de crimes n�o-violentos,

            o foco deve ser mudado para fazer o criminoso indenizar a v�tima e

            faz�-lo pagar os custos da pol�cia, do julgamento e da pris�o. Em caso de

            crime violento, a indeniza��o da v�tima deve ser combinada com uma senten�a

            de pris�o que inclua um meio de trabalhar para pagar o que �

            devido. N�o devem haver crimes sem v�tima. Ningu�m deve estar

            na pris�o sem ter causado mal a outrem.

        </p>

        

        <p>

            <strong>Os Libert�rios n�o deveriam ficar fora da pol�tica?</strong>

        </p>

        

        <p>

            N�o, pois h� justificativas v�lidas para participar da pol�tica

            eleitoral. Votar no LIBER � um ato de auto-defesa. Encorajar as

            pessoas a votar no LIBER � possibilitar que elas votem a favor da

            Liberdade e contra os impostos, o intervencionismo

            e o gigantismo estatal.

        </p>

        

        <p>

            <strong>Eu n�o deveria apoiar um partido pol�tico maior que tenha

            mais chances de vencer uma elei��o?</strong>

        </p>

        

        <p>

            N�o, pois quando voc� vota nos partidos tradicionais voc�

            est� votando pelo gigantismo estatal. Voc� est� votando a favor do

            lobby das grandes empresas, que visa receber subs�dios e restringir

            a entrada de concorrentes no mercado. Nenhum dos grandes partidos vai

            implementar as pol�ticas libert�rias. Apoiar o LIBER � um voto a favor

            da Liberdade, porque os Libert�rios buscam transformar o Brasil

            em uma sociedade livre. Votar no LIBER pressiona os outros

            partidos a dar aten��o aos seus interesses.

        </p>

        

        <p>

            <strong>O que o LIBER pensa de restri��es � liberdade de express�o?</strong>

        </p>

        

        <p>

            O LIBER � contr�rio a restri��es � liberdade de express�o que

            impedem as pessoas de opinar sobre qualquer assunto. Leis contra

            amea�as a outros s�o v�lidas, assim como leis que punem a fraude.

        </p>

        

        <p>

            <strong>Como voc�s justificam impostos num governo libert�rio?

            Voc�s n�o acreditam que impostos s�o uma forma de roubo?</strong>

        </p>

        

        <p>

            Outros m�todos podem ser usados para financiar as fun��es leg�timas

            do governo (ex: pol�cia, cortes e ju�zes). Eliminar todos os impostos

            � o ideal, mas para muitos libert�rios n�o est� claro que isto seja poss�vel.

            H� outros m�todos que podem ser tentados. Criminosos podem ter

            que pagar os custos policiais e judici�rios. Taxas de utiliza��o

            de servi�os governamentais podem ser poss�veis.

        </p>

        

        <p>

            <strong>Os Libert�rios s�o ateus?</strong>

        </p>

        

        <p>

            N�o. H� muitos libert�rios religiosos, assim como h� muitos agn�sticos e

            ateus. Libertarianismo � uma filosofia

            que se preocupa com a pol�tica, apenas.

        </p>

        

        <p>

            <strong>Libert�rio quer dizer libertino? Os Libert�rios defendem

            promiscuidade, drogas e estilos de vida alternativos?</strong>

        </p>

        

        <p>

            O Libertarianismo acredita que devemos deixar as pessoas

            tomar suas pr�prias decis�es. O Libertarianismo se preocupa

            apenas com o papel que um governo deve ter.

        </p>

        

        <p>

            <strong>Os Libert�rios acreditam em direitos como habeas corpus e que

            os acusados devem ser considerados inocentes at� prova em contr�rio?</strong>

        </p>

        

        <p>

            Claro. Os Libert�rios orgulhosamente aderem �s tradi��es Liberais

            Cl�ssicas que compartilhamos com muitas outras pessoas.

        </p>

        

        <p>

            <strong>Se o LIBER assumir o governo, voc�s n�o seriam

            exatamente como os outros partidos?</strong>

        </p>

        

        <p>

            O partido Libert�rios se baseia em princ�pios e na redu��o do

            poder do governo sobre as vidas dos brasileiros. O objetivo do LIBER

            � reformar o estado de forma que o governo n�o tenha mais tanto poder,

            independente do partido que esteja no poder.

        </p>

        

        <p>

            <strong>O governo deve interferir nas rela��es entre patr�es e empregados?</strong>

        </p>

        

        <p>

            N�o.

        </p>
"
						#endregion
					});

					#endregion

					#region Menus - fazer depois

					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "Principal", Controller = "Home", Action = "Index" });

					//context.Menus.AddOrUpdate(new Menu { MenuID = 2, Titulo = "Nosso Partido" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 3, Titulo = "Hist�ria", Link = "Historia" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 4, Titulo = "Filosofia", Link = "Filosofia" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 5, Titulo = "Programa", Link = "Programa" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 6, Titulo = "Estatuto", Link = "Estatuto" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 7, Titulo = "Lideran�as Nacionais", Link = "Lideranca" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 8, Titulo = "Presta��o de Contas", Link = "Contas" });

					//context.Menus.AddOrUpdate(new Menu { MenuID = 9, Titulo = "Ideias", Link = "" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "", Link = "" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "", Link = "" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "", Link = "" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "", Link = "" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "", Link = "" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "", Link = "" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "", Link = "" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "", Link = "" });
					//context.Menus.AddOrUpdate(new Menu { MenuID = 1, Titulo = "", Link = "" });

					#endregion

					#region Autores

					context.Autores.AddOrUpdate(new Autor { AutorID = 1, Nome = "Andr� Luiz Santa Cruz Ramos" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 2, Nome = "Bernardo Santoro" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 3, Nome = "Bruno Paludo" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 4, Nome = "Filipe Rangel Celeti" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 5, Nome = "Geraldo Boz Junior" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 6, Nome = "Guilherme Inojosa" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 7, Nome = "Juliano Torres" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 8, Nome = "Matheus Assaf" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 9, Nome = "Secret�rio Geral" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 10, Nome = "Sidnei Santana Carneiro" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 11, Nome = "Pedro Carleial" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 12, Nome = "Pedro Henrique Gonzalez" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 13, Nome = "Raphael Moras de Vasconcellos" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 14, Nome = "Fernando Araujo" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 15, Nome = "Cristiano Chiocca" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 16, Nome = "Fernando Chiocca" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 17, Nome = "Pedro Duarte Jr" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 18, Nome = "Renato Drummond" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 19, Nome = "Thiago Pinheiro" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 20, Nome = "Beatriz C. Lopes" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 21, Nome = "Luciana Lopes" });
					context.Autores.AddOrUpdate(new Autor { AutorID = 22, Nome = "Tesoureiro" });

					#endregion

					#region Save

					context.SaveChanges();

					#endregion
        }
    }
}
