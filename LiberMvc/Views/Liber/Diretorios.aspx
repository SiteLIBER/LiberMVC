<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel" id="diretorios">
	    <h1>Diretórios</h1>

        <div style="float: left;">
            <h2>Região Sul</h2>

            <ul class="formatted_list">
                <li><strong>Santa Catarina</strong><br />
                    Presidente: <em>Milton Rolim Carneiro Filho</em><br />
                    Vice-presidente: <em>Pedro Luiz Navarro Giaquinto</em><br />
                    Secretário: <em>Hélio Horvath</em><br />
                    Email para contato: <a href="maioto:miltonrolim@ibest.com.br">miltonrolim@ibest.com.br</a>
                </li>

                <li><strong>Paraná</strong><br />
                    Presidente: <em>Marcelo Rissatto</em><br />
                    Email para contato: <a href="maioto:liberpr@hotmail.com">liberpr@hotmail.com</a>
                </li>
            </ul>
        </div>

        <div style="float: right; width: 320px;">
            <h2>Região Centro-Oeste</h2>

            <ul class="formatted_list">
                <li><strong>Mato Grosso do Sul</strong><br />
                    Presidente: <em>Professor Elberto Teles Ribeiro</em><br />
                    Vice-presidente: <em>Priscila Gonçalves da Silva Araújo</em><br />
                    2º vice de Formação Política: <em>Roberto César Cunha</em><br />
                    Secretário: <em>Edna Lúcia Lopes</em><br />
                    Tesoureiro: <em>Getulio Teles de Menezes</em><br />
                    Email para contato: <a href="maioto:professor.elberto@hotmail.com">professor.elberto@hotmail.com</a>
                </li>

                <li><strong>Mato Grosso</strong><br />
                    Presidente: <em>Rodrigo Martins</em><br />
                    Email para contato: <a href="maioto:rodrigo.liber@gmail.com">rodrigo.liber@gmail.com</a>
                </li>

                <li><strong>Distrito Federal</strong><br />
                    Presidente: <em>Antonio Mariz</em><br />
                </li>
            </ul>
        </div>

        <div style="float: left">
            <h2>Região Sudeste</h2>

            <ul class="formatted_list">
                <li><strong>São Paulo</strong><br />
                    Presidente: <em>Carlo Rocha</em><br />
                    Email para contato: <a href="maioto:carlo.rocha@terra.com.br">carlo.rocha@terra.com.br</a>
                </li>

                <li><strong>Minas Gerais</strong><br />
                    Presidente: <em>Caio José</em><br />
                    Vice-presidente: <em>Vitor Reis</em><br />
                    Secretário Interno: <em>Caio Magno</em><br />
                    Secretário Externo: <em>Felipe Brito</em><br />
                    Tesoureiro: <em>Bernardo Gaetani</em><br />
                    Email para contato: <a href="maioto:mg@libertarios.com.br">mg@libertarios.com.br</a>
                </li>

                <li><strong>Rio de Janeiro</strong><br />
                    Presidente: <em>Roberto Fiori Chiocca</em><br />
                    Vice-presidente: <em>Marco Antonio Costa</em><br />
                    1° Secretário: <em>Felipe Svaluto Paul</em><br />
                    2° Secretário: <em>Nathalie Bottino</em><br />
                    Email para contato: <a href="maioto:marco.antonio.costo@gmail.com">marco.antonio.costo@gmail.com</a>
                </li>

                <li><strong>Espírito Santo</strong><br />
                    Presidente: <em>Sidnei Santana Carneiro</em><br />
                    Email para contato: <a href="maioto:sidnei_es@hotmail.com">sidnei_es@hotmail.com</a>
                </li>
            </ul>
        </div>

        <div style="float: right; width: 320px;">
            <h2>Região Nordeste</h2>

            <ul class="formatted_list">
                <li><strong>Sergipe</strong><br />
                    Presidente: <em>Cristiano Batista</em><br />
                    Email para contato: <a href="maioto:jornalistacristiano@gmail.com">jornalistacristiano@gmail.com</a>
                </li>

                <li><strong>Pernambuco</strong><br />
                    Presidente: <em>Leonardo Brayner</em><br />
                    Email para contato: <a href="maioto:brayner.l@gmail.com">brayner.l@gmail.com</a>
                </li>

                <li><strong>Piauí</strong><br />
                    Presidente: <em>Thiago Carvalho de Sousa</em><br />
                    Email para contato: <a href="maioto:thiagocsousa@gmail.com">thiagocsousa@gmail.com</a>
                </li>

                <li><strong>Ceará</strong><br />
                    Presidente: <em>Raduán Melo</em><br />
                    Email para contato: <a href="maioto:raduanmelo@hotmail.com">raduanmelo@hotmail.com</a>
                </li>
            </ul>
        </div>

        <div style="float: right; width: 320px;">
            <h2>Região Norte</h2>

            <ul class="formatted_list">
                <li><strong>Rondônia</strong><br />
                    Presidente: <em>Joel Castro de Oliveira</em><br />
                    Email para contato: <a href="maioto:joelcstr@gmail.com">joelcstr@gmail.com</a> ou<br />
                    <a href="maioto:joelcstr@hotmail.com">joelcstr@hotmail.com</a>
                </li>

                <li><strong>Pará</strong><br />
                    Presidente: <em>Marcos Neemias Negrão Reis</em><br />
                    Email para contato: <a href="maioto:mneemias@gmail.com">mneemias@gmail.com</a>
                </li>
            </ul>
        </div>

        <br class="clear" />
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>

