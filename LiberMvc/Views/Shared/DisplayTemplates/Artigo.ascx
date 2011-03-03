<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<LiberMvc.Models.Artigo>" %>

<h1><%: Model.Titulo %></h1>

<p class="general_informations">
	<span class="date"><%: Model.PublicadoEm.ToShortDateString() %></span> 
	<span class="author"><%: Model.Autor %></span>

	<span style="display: block; margin-top: 5px;">
		<span class="addthis_toolbox addthis_default_style" style="float: left;">
			<script src="http://connect.facebook.net/en_US/all.js#xfbml=1"></script><fb:like layout="button_count" show_faces="false" width="200"></fb:like>
		</span>

		<!-- AddThis Button BEGIN -->
		<span class="addthis_toolbox addthis_default_style" style="float: right;" addthis:title="<%= Url.Encode(Model.Titulo) %>">
			<a href="http://www.addthis.com/bookmark.php?v=250&amp;pubid=xa-4d6c7b090593ecfb" class="addthis_button_compact">Compartilhar</a>
			<span class="addthis_separator">|</span>
			<a class="addthis_button_preferred_1"></a>
			<a class="addthis_button_preferred_3"></a>
			<a class="addthis_button_preferred_4"></a>
		</span>
		<script type="text/javascript" src="http://s7.addthis.com/js/250/addthis_widget.js#pubid=xa-4d6c7b090593ecfb"></script>
		<!-- AddThis Button END -->

	</span>
	<br class="clear" />
</p>

<div class="article_body">
	<%= Model.Conteudo %>
</div>

