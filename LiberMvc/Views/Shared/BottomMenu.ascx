<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<div id="footer_general_informations">
    <p>
        O LIBER é  uma instituição de atuação política, sem fins lucrativos,
        que visa difundir os preceitos do Libertarianismo, doutrina filosófica
        baseada nos princípios da não agressão e da auto-propriedade.
    </p>
</div>
 
<!-- IMPORTANT LINKS BEGIN -->
<div id="important_links">
    <div>
        <h1>Nosso Partido</h1>
        <ul>
           <li><a href='<%= Url.Action("Historia", "Liber") %>'>História</a></li>
           <li><a href='<%= Url.Action("Filosofia", "Liber") %>'>Filosofia</a></li>
           <li><a href='<%= Url.Action("Programa", "Liber") %>'>Programa</a></li>
           <li><a href='<%= Url.Action("Estatuto", "Liber") %>'>Estatuto</a></li>
           <li><a href='<%= Url.Action("Lideranca", "Liber") %>'>Lideranças Nacionais</a></li>
           <%-- <li><a href='<%= Url.Action("Contas", "Liber") %>'>Prestação de Contas</a></li> --%>
        </ul>
    </div>
 
    <div> 
        <h1>Ideias</h1>
        <ul>
            <%--<li><a href='<%= Url.Action("Index", "Blog") %>'>Blog</a></li>--%>
            <li><a href='<%= Url.Action("Index", "Artigos") %>'>Artigos</a></li>
            <li><a href='<%= Url.Action("Direitos", "Liber") %>'>Direitos Individuais</a></li>
            <li><a href='<%= Url.Action("Economia", "Liber") %>'>Comércio e Economia</a></li>
            <li><a href='<%= Url.Action("Domestico", "Liber") %>'>Assuntos Domésticos</a></li>
            <li><a href='<%= Url.Action("Exterior", "Liber") %>'>Relações Exteriores</a></li>
            <li><a href='<%= Url.Action("FAQ", "Liber") %>'>Perguntas Frequentes</a></li>
        </ul>
    </div>
 
    <div>
        <h1>Participe</h1>
        <ul>
            <li><a href='<%= Url.Action("Cadastro", "Usuario") %>'>Cadastre-se</a></li>
            <li><a href='<%= Url.Action("Filiacao", "Usuario") %>'>Filie-se</a></li>
            <li><a href='<%= Url.Action("Doacao", "Liber") %>'>Faça uma doação</a></li>
            <li><a href='<%= Url.Action("Divulgacao", "Liber") %>'>Divulgue</a></li>
            <%--<li><a href='<%= Url.Action("Newsletter", "Liber") %>'>Newsletter</a></li>--%>
            <%--<li><a href='<%= Url.Action("Liber500", "Liber") %>'>Liber 500</a></li>--%>
            <%--<li><a href='<%= Url.Action("Index", "Forum") %>'>Fórum</a></li>--%>
            <li><a href='<%= Url.Action("Contato", "Liber") %>'>Contato</a></li>
        </ul>
    </div>
 
<%--    <div>
        <h1>Mídia</h1>
        <ul>
            <li><a href='<%= Url.Action("Imprensa", "Liber") %>'>Na Imprensa</a></li>
            <li><a href='<%= Url.Action("Jornalistas", "Liber") %>'>Para Jornalistas</a></li>
            <li><a href='<%= Url.Action("Eventos", "Liber") %>'>Eventos</a></li>
        </ul>
    </div>--%>
</div>
<!-- IMPORTANT LINKS END -->
 
<p id="general_links">
    <%--<a href="#">Mapa do Site</a> |--%>
    <%--<a href="#">Política de Privacidade</a> |--%>
    <%--<a href="#">Administração</a> |--%>
    <a href='<%= Url.Action("Contato", "Liber") %>'>Contato</a> 
</p>
 
<p id="copy"> 
    <img src="/Content/images/creative_commons.png" /><br />
    Esta obra é licenciada sob uma licença
    <a href="http://creativecommons.org/licenses/by/2.0/br/">Creative Commons Atribuio 2.0 Brasil.</a> 
</p>
