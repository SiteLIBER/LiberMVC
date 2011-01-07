<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
	<table width="100%" border="0" cellspacing="0" cellpadding="0">
		<tr>
			<td width="5" rowspan="2" valign="top">
				<img src="/Content/images/left_border.gif" width="5" height="150">
			</td>
			<td height="50" background="/Content/images/top_border.gif">
				<p>
					<font size="2" face="Verdana, Arial, Helvetica, sans-serif"><strong>PRESTA&Ccedil;&Atilde;O
						DE CONTAS</strong></font></p>
			</td>
			<td width="5" rowspan="2" valign="top">
				<img src="/Content/images/right_border.gif" width="5" height="150">
			</td>
		</tr>
		<tr>
			<td>
				<p align="justify">
					<font color="#FF0000">Visivel somente para os FILIADOS.</font></p>
				<p align="justify">
					Forma adequada de demonstrar os balancetes devem ser discutidas com o tesoureiro
					Bruno Paulo.</p>
				<p align="justify">
					<font color="#FF0000">a construir...</font>
				</p>
			</td>
		</tr>
	</table>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="RightContent" runat="server">
	<% Html.RenderPartial("RightMenu"); %>
</asp:Content>