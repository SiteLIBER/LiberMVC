﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<div class="panel" id="video_box"> 
    <h1>Vídeo</h1> 
 
    <p>
        <object width="275" height="220">
			<param name="movie" value="http://www.youtube.com/v/B7DVlC3kXrM&amp;hl=pt_BR&amp;fs=1"></param>
            <param name="allowFullScreen" value="true"></param>
			<param name="allowscriptaccess" value="always"></param>
			<embed src="http://www.youtube.com/v/B7DVlC3kXrM&amp;hl=pt_BR&amp;fs=1" width="275"
			    height="220" type="application/x-shockwave-flash" allowscriptaccess="always" allowfullscreen="true"></embed>
		</object>
    </p>

</div>