<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.CadastroModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel" id="cadastro">
        <h1>Cadastro</h1>

        <p>Este cadastro <strong>não implica em filiação</strong></p>
        
        <p>
            Os Ítens em <strong style="color: red">vermelho</strong> são obrigatórios.
        </p>

	    <div id="display-form">
				<% Html.EnableClientValidation(); %>
				<% using (Html.BeginForm()) { %>
				<%= Html.ValidationSummary(true)%>
				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Nome)%>
					</span>
					<span class="display-field">
						<%= Html.EditorFor(model => model.Nome)%>
						<%= Html.ValidationMessageFor(model => model.Nome)%>
					</span>
				</div>

				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Email)%>
					</span>
					<span class="display-field">
						<%= Html.EditorFor(model => model.Email)%>
						<%= Html.ValidationMessageFor(model => model.Email)%>
					</span>
				</div>

				<div class="display-item">
					<span class="display-label obr">
						<%= Html.LabelFor(model => model.Senha)%>
					</span>
					<span class="display-field">
						<%= Html.EditorFor(model => model.Senha)%>
						<%= Html.ValidationMessageFor(model => model.Senha)%>
					</span>
				</div>

                <br class="clear" />

				<div class="display-item">
					<span class="display-label"></span>
					<span class="display-field">
						<%= Html.EditorFor(model => model.ReceberNewsletter)%>
						<%= Html.LabelFor(model => model.ReceberNewsletter)%>
					</span>
				</div>

				<div class="display-item">
					<span class="display-label"></span>
					<span class="display-field">
					<%= Html.EditorFor(model => model.DesejaFiliacao)%>
					<%= Html.LabelFor(model => model.DesejaFiliacao)%>
					</span>
				</div>

                <br class="clear" />

			    <div class="display-item">
					<span class="display-field">
					    <input type="submit" value="Cadastrar" class="button" />
					</span>
			    </div>

			<% } %>

                <br class="clear" />
			</div>

		</div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightCadastro"); %>
</asp:Content>
