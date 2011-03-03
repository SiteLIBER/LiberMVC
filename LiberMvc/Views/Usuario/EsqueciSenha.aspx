﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<LiberMvc.Models.EsqueciModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="panel" id="cadastro">
        <h1>Esqueci minha senha</h1>

				<p>
					Preencha seu email e aperte o botão para que sua senha seja enviada para seu e-mail.
				</p>
				<p>
					<span id="erro" class="obr"><%: Model.ErrorMessage %></span>
				</p>
			<div id="display-form">
				<% Html.EnableClientValidation(); %>
				<% using (Html.BeginForm()) { %>
				<%= Html.ValidationSummary(true)%>
				<div class="display-item">
					<span class="display-label obr">
						<%: Html.LabelFor(model => model.Email)%>
					</span><span class="display-field">
						<%: Html.EditorFor(model => model.Email)%>
						<%: Html.ValidationMessageFor(model => model.Email)%>
					</span>
				</div>
				<br class="clear" />
				<div class="display-item">
					<span class="display-field">
						<input type="submit" value="Enviar E-mail" class="button" />
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
