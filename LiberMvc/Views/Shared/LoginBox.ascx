<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<LiberMvc.Models.LoginModel>" %>

  <h1>Login</h1>

	<div class="editor-item" id="loginerror"></div>
	
	<% Html.EnableClientValidation(); %>

	<% using (Ajax.BeginForm(new AjaxOptions
		{
			UpdateTargetId = "loginerror",
			Url = (string.IsNullOrEmpty(Request.QueryString["returnUrl"]))
			? Url.Action("Login", "Auth")
			: Url.Action("Login", "Auth") + "?ReturnUrl=" + Request.QueryString["returnUrl"]		
		}))
		{ %>
	
	<div class="editor-item"><%=Html.ValidationSummary(true) %></div>

	<div class="editor-item">
		<span class="editor-label" style="width: 100px"><%= Html.LabelFor(m => m.Email)%>:</span> 
		<span class="editor-field">
			<%= Html.TextBoxFor(m => m.Email)%>
			<span class="editor-error"><%= Html.ValidationMessageFor(m => m.Email)%></span>
		</span>
	</div>

	<div class="editor-item">
		<span class="editor-label" style="width: 100px"><%= Html.LabelFor(m => m.Senha)%>:</span>
		<span class="editor-field">
			<%= Html.PasswordFor(m => m.Senha)%>
			<span class="editor-error"><%= Html.ValidationMessageFor(m => m.Senha)%></span>
		</span>
	</div>

	<div class="editor-item">
		<span class="editor-label" style="width: 100px"></span>
		<span class="editor-field">
			<%= Html.CheckBoxFor(m => m.Lembrar)%>
			<%= Html.LabelFor(m => m.Lembrar)%>
		</span>
	</div>

    <br class="clear" />

    <p class="actions">
	    <input type="submit" value="Entrar" class="button" />
	    <%= Html.ActionLink("Cadastre-se", "Cadastro", new { controller = "Usuario" }, new { @class = "button", @style = "float: left" })%>
        
        <br class="clear" />
    </p>

	<% } %>

	

	
