var liber_banner;
var liber_latest_news;

$(function () {
    liber_banner = $('#banner > ul.slides').bxSlider({
        controls: false, auto: true,
        onBeforeSlide: function (curr_sld, qty_sld, curr_obj) {
            $('#banner > .pagination span').removeClass('active');
            $($('#banner > .pagination span')[curr_sld]).addClass('active');
        }
    });
});

$(function () {
    $('#banner > .pagination span').click(function () {
        liber_banner.goToSlide($(this).index());
    });
})



$(function () {
    liber_latest_news = $('#latest_news_highlights > ul.slides').bxSlider({
        controls: false, auto: true,
        onBeforeSlide: function (curr_sld, qty_sld, curr_obj) {
            $('#latest_news_highlights > .pagination span').removeClass('active');
            $($('#latest_news_highlights > .pagination span')[curr_sld]).addClass('active');
        }
    });
});

$(function () {
    $('#latest_news_highlights > .pagination span').click(function () {
        liber_latest_news.goToSlide($(this).index());
    });
})

