<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

 <div class="panel" id="diretorios">
	    <h1>Diretórios</h1>

        <div style="float: left;">
            <h2>Região Sul</h2>

            <ul class="formatted_list">
                <li><strong>Rio Grande do Sul</strong><br />
                    Presidente: <em>Alexsander Rosa</em><br />
                    Email para contato: <a href="mailto:alexsander.rosa@gmail.com">alexsander.rosa@gmail.com</a>
                </li>
                <li><strong>Santa Catarina</strong><br />
                    Presidente: <em>André Poffo</em><br />
                    Email para contato: <a href="mailto:andrehpoffo@gmail.com">andrehpoffo@gmail.com</a>
                </li>
                <li><strong>Paraná</strong><br />
                    Presidente: <em>Geraldo Boz Junior</em><br />
                    Email para contato: <a href="mailto:gbozjr@gmail.com">gbozjr@gmail.com</a>
                </li>
            </ul>
        </div>

        <div style="float: right; width: 320px;">
            <h2>Região Centro-Oeste</h2>

            <ul class="formatted_list">
                <li><strong>Mato Grosso do Sul</strong><br />
                    Presidente: <em>Elberto Teles Ribeiro</em><br />
                    Email para contato: <a href="mailto:professor.elberto@hotmail.com">professor.elberto@hotmail.com</a>
                </li>

                <li><strong>Mato Grosso</strong><br />
                    Presidente: <em>Rodrigo Martins Mussnich</em><br />
                    Email para contato: <a href="mailto:rodrigo.liber@gmail.com">rodrigo.liber@gmail.com</a>
                </li>

                <li><strong>Distrito Federal</strong><br />
                    Presidente: <em>André Ramos</em><br />
                    Email para contato: <a href="mailto:alscramos@gmail.com">alscramos@gmail.com</a>
                </li>
            </ul>
        </div>

        <div style="float: left">
            <h2>Região Sudeste</h2>

            <ul class="formatted_list">
                <li><strong>São Paulo</strong><br />
                    Presidente: <em>André Rufino</em><br />
                    Vice-presidente: <em>Roberto Chiocca</em><br />
                    Email para contato: <a href="mailto:andrerrufino@gmail.com">andrerrufino@gmail.com</a>
                </li>

                <li><strong>Minas Gerais</strong><br />
                    Presidente: <em>Caio José de Oliveira Ramos</em><br />
                    Email para contato: <a href="mailto:emailcaio@yahoo.com.br">emailcaio@yahoo.com.br</a>
                </li>

                <li><strong>Rio de Janeiro</strong><br />
                    Presidente: <em>Patrick Gappo</em><br />
                    Email para contato: <a href="mailto:patrickccg@globo.com">patrickccg@globo.com</a>
                </li>

                <li><strong>Espírito Santo</strong><br />
                    Presidente: <em>Sidnei Santana Carneiro</em><br />
                    Email para contato: <a href="mailto:sidneisc@gmail.com">sidneisc@gmail.com</a>
                </li>
            </ul>
        </div>

        <div style="float: right; width: 320px;">
            <h2>Região Nordeste</h2>

            <ul class="formatted_list">
                <li><strong>Ceará</strong><br />
                    Presidente: <em>Bruno Aguiar</em><br />
                    Email para contato: <a href="mailto:brunobca@gmail.com">brunobca@gmail.com</a>
                </li>
            </ul>
        </div>

        <div style="float: right; width: 320px;">
            <h2>Região Norte</h2>

            <ul class="formatted_list">
                <li><strong>Amazonas</strong><br />
                    Presidente: <em>Fabiano Castanhola</em><br />
                    Email para contato: <a href="mailto:fcastanhola@gmail.com">fcastanhola@gmail.com</a>
                </li>

                <li><strong>Rondônia</strong><br />
                    Presidente: <em>Joel Castro de Oliveira</em><br />
                    Email para contato: <a href="mailto:joelcstr@gmail.com">joelcstr@gmail.com</a> ou<br />
                    <a href="mailto:joelcstr@hotmail.com">joelcstr@hotmail.com</a>
                </li>

                <li><strong>Pará</strong><br />
                    Presidente: <em>Marcos Neemias Negrão Reis</em><br />
                    Email para contato: <a href="mailto:mneemias@gmail.com">mneemias@gmail.com</a>
                </li>
            </ul>
        </div>

        <br class="clear" />
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>

