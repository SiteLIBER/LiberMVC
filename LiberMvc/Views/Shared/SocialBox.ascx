<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<div class="panel" id="redes_sociais"> 
    <h1>Redes sociais</h1> 
 
    <p>
        <a href="http://www.formspring.me/Libertarios"><img src="<%= Url.Content("~/Content/images/formspring.png") %>" /></a>
        <a href="http://www.youtube.com/user/CANALPLIBER"><img src="<%= Url.Content("~/Content/images/youtube.png") %>" /></a>
        <a href="http://www.facebook.com/pages/Libertarios/131689188332"><img src="<%= Url.Content("~/Content/images/facebook.png") %>" /></a>
        <a href="http://twitter.com/sejaliber"><img src="<%= Url.Content("~/Content/images/twitter.png") %>" /></a>
        <a href="http://www.flickr.com/photos/sejaliber/"><img src="<%= Url.Content("~/Content/images/flickr.png") %>" /></a>
        <a href="http://www.orkut.com.br/Main#Community?cmm=107501389"><img src="<%= Url.Content("~/Content/images/orkut.png") %>" /></a>
    </p>

</div>