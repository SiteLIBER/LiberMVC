<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<LiberMvc.Models.Blog>" %>
<div class="editor-label">
	<%= Html.LabelFor(model => model.Titulo) %>
</div>
<div class="editor-field">
	<%= Html.EditorFor(model => model.Titulo)%>
	<%= Html.ValidationMessageFor(model => model.Titulo) %>
</div>
<div class="editor-label">
	<%= Html.LabelFor(model => model.Conteudo) %>
</div>
<div class="editor-field">
	<%= Html.EditorFor(model => model.Conteudo)%>
	<%= Html.ValidationMessageFor(model => model.Conteudo) %>
</div>
<div class="editor-label">
	<%= Html.LabelFor(model => model.Publicado) %>
</div>
<div class="editor-field">
	<%= Html.EditorFor(model => model.Publicado)%>
	<%= Html.ValidationMessageFor(model => model.Publicado) %>
</div>
<div class="editor-label">
	<%= Html.LabelFor(model => model.PublicadoEm) %>
</div>
<div class="editor-field">
	<%= Html.EditorFor(model => model.PublicadoEm)%>
	<%= Html.ValidationMessageFor(model => model.PublicadoEm) %>
</div>