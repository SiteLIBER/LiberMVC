<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>
<table width="100%" border="0" cellspacing="0" cellpadding="0">
	<tr>
		<td width="7" rowspan="2" valign="top">
			<img src="<%= Url.Content("~/Content/images/left_border.gif") %>" width="7" height="150">
		</td>
		<td height="50" colspan="2" background="<%= Url.Content("~/Content/images/top_border.gif") %>">
			<strong><font size="2" face="Verdana, Arial, Helvetica, sans-serif">ENQUETE</font></strong>
		</td>
		<td width="8" rowspan="2" valign="top">
			<img src="<%= Url.Content("~/Content/images/right_border.gif") %>" width="8" height="150">
		</td>
	</tr>
	<tr>
		<td colspan="2">
			<p align="center">
				<font size="2" face="Verdana, Arial, Helvetica, sans-serif"><strong>Qual &eacute; o imposto que deveria ser cortado primeiro?</strong></font></p>
			<form name="form2" method="post" action="">
			<font size="2">
				<label>
					<font face="Verdana, Arial, Helvetica, sans-serif">
						<input type="radio" name="enquete" value="radio">
						IR</font></label>
				<font face="Verdana, Arial, Helvetica, sans-serif">
					<br>
					<label>
						<input type="radio" name="enquete" value="radio">
						IPVA</label>
					<br>
					<label>
						<input type="radio" name="enquete" value="radio">
						IPTU</label>
					<br>
					<label>
						<input type="radio" name="enquete" value="radio">
						ICMS</label>
				</font></font>
			<p align="center">
				<font size="2"><font face="Verdana, Arial, Helvetica, sans-serif">
					<input name="enquete2" type="submit" id="enquete2" value="enviar">
				</font></font>
			</p>
			</form>
		</td>
	</tr>
</table>
