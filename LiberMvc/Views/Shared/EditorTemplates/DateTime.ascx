<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<System.DateTime?>" %>
<%=Html.TextBox("", (Model.HasValue ? Model.Value.ToShortDateString() : ""), new { @class = "datePicker" })%>