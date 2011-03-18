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
				<li><a href='<%= Url.Action("Contas", "Liber") %>'>Prestação de Contas</a></li>
			</ul>
		</div>

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
			dentro da própria "máquina estatal".
		</p>

	</div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>
