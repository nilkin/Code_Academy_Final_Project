$(document).ready(function () {
    // dropdown
    $('.nav-item').mouseenter(function(){
        $(this).find('.dropdown-menu').addClass("show").addClass("animated fadeIn");
      });

      $('.nav-item').mouseleave(function(){
        $(this).find('.dropdown-menu').removeClass(" animated fadeIn").removeClass("show");
      });
    // main-slider
    var $timer = 6000;
    $('.home-carousel').slick({
        autoplay: true,
        speed: 800,
        slidesToShow: 1,
        slidesToScroll: 1,
        autoplaySpeed: $timer,
        dots: true,
        fade: true,
        cssEase: 'linear',
        arrows: false,
        responsive: [{
            breakpoint: 767,
            settings: {
                dots: false,
                arrows: false
            }
        }]

    }).slickAnimation();

    function progressBar() {
        $(".slick-progress").find("span").removeAttr("style");
        $(".slick-progress").find("span").removeClass("active");
        setTimeout(function () {
            $(".slick-progress").find("span").css("transition-duration", $timer / 1000 + "s").addClass("active");
        }, 100);
    }

    progressBar();
    $('.home-carousel').on("beforeChange", function (e, slick) {
        progressBar();
    });


});