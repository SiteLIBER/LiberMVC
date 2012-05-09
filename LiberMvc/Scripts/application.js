var liber_banner;

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

