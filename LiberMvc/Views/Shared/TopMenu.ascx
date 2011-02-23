﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<ul id="nav">
	<li class="rows_5"><a href="<%= Url.Action("Index", "Home") %>"><span>Principal</span></a></li>
	<li class="rows_5"><a href="#"><span>Nosso Partido</span></a>
		<div class="drop-holder">
			<div class="drop-content">
				<ul>
					<li><a href="<%= Url.Action("Historia", "Liber") %>">História</a></li>
					<li><a href="<%= Url.Action("Filosofia", "Liber") %>">Filosofia</a></li>
					<li><a href="<%= Url.Action("Programa", "Liber") %>">Programa</a></li>
					<li><a href="<%= Url.Action("Estatuto", "Liber") %>">Estatuto</a></li>
					<li><a href="<%= Url.Action("Lideranca", "Liber") %>">Lideranças Nacionais</a></li>
					<li><a href="<%= Url.Action("Contas", "Liber") %>">Prestação de Contas</a></li>
				</ul>
			</div>
		</div>
	</li>
	<li class="rows_4"><a href="#"><span>Ideias</span></a>
		<div class="drop-holder">
			<div class="drop-content">
				<ul>
					<li><a href="<%= Url.Action("Index", "Blog") %>">Blog</a></li>
					<li><a href="<%= Url.Action("Index", "Artigos") %>">Artigos</a></li>
					<li><a href="<%= Url.Action("Direitos", "Liber") %>">Direitos Individuais</a></li>
					<li><a href="<%= Url.Action("Economia", "Liber") %>">Comércio e Economia</a></li>
					<li><a href="<%= Url.Action("Domestico", "Liber") %>">Assuntos Domésticos</a></li>
					<li><a href="<%= Url.Action("Exterior", "Liber") %>">Relações Exteriores</a></li>
					<%--<li><a href="<%= Url.Action("FAQ", "Liber") %>">Perguntas Frequentes</a></li>--%>
				</ul>
			</div>
		</div>
	</li>
	<li class="rows_5"><a href="#"><span>Participe</span></a>
		<div class="drop-holder">
			<div class="drop-content">
				<ul>
					<li><a href="<%= Url.Action("Cadastro", "Usuario") %>">Cadastre-se</a></li>
					<li><a href="<%= Url.Action("Filiacao", "Usuario") %>">Filie-se</a></li>
					<li><a href="<%= Url.Action("Doacao", "Liber") %>">Faça uma doação</a></li>
					<li><a href="<%= Url.Action("Divulgacao", "Liber") %>">Divulgue</a></li>
					<%--<li><a href="<%= Url.Action("Newsletter", "Liber") %>">Newsletter</a></li>--%>
					<%--<li><a href="<%= Url.Action("Liber500", "Liber") %>">Liber 500</a></li>--%>
					<%--<li><a href="<%= Url.Action("Index", "Forum") %>">Fórum</a></li>--%>
					<li><a href="<%= Url.Action("Contato", "Liber") %>">Contato</a></li>
				</ul>
			</div>
		</div>
	</li>
	<%--<li class="rows_3"><a href="#"><span>Mídia</span></a>
			<div class="drop-holder">
				<div class="drop-content">
						<ul>
							<li><a href="<%= Url.Action("Imprensa", "Liber") %>">Na Imprensa</a></li>
							<li><a href="<%= Url.Action("Jornalistas", "Liber") %>">Para Jornalistas</a></li>
							<li><a href="<%= Url.Action("Eventos", "Liber") %>">Eventos</a></li>
						</ul>
				</div>
			</div>
		</li>--%>
	<%--<li class="rows_0"><a href="<%= Url.Action("Diretorios", "Liber") %>"><span>Diretórios</span></a></li> --%>
	<%--<li class="rows_0"><a href="<%= Url.Action("Index", "Loja") %>"><span>Loja</span></a></li>--%>
	<li class="rows_0"><a href="<%= Url.Action("FAQ", "Liber") %>"><span>FAQ</span></a></li>
</ul>
