<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<bool>" %>
<%= (Model) ? Html.Label("Sim") : Html.Label("Não") %>
