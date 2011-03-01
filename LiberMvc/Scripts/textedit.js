tinyMCE.init({
	language : "pt",
	mode : "textareas",
	mode: "exact",
    elements: "Conteudo",
	editor_deselector : "no_editor",

	plugins : "table,media,preview,contextmenu,style",

	theme : "advanced",
	theme_advanced_toolbar_location : "top",
	theme_advanced_toolbar_align : "left",
	theme_advanced_buttons1 : "undo,redo,|,bold,italic,underline,strikethrough,|,sub,sup,|,link,unlink,|,blockquote,|,formatselect,styleselect",
	theme_advanced_buttons2: "tablecontrols,|,bullist,numlist,|,hr,|,image,media,|,code,removeformat,|,preview",
	theme_advanced_buttons3 : "",
	theme_advanced_statusbar_location: "bottom",
	theme_advanced_resizing : true,
	theme_advanced_resize_horizontal : false
});


