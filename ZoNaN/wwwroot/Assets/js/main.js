$(document).ready(function () {

    // /////////////// back to top
    var btn = $('#button');

    $(window).scroll(function () {
        if ($(window).scrollTop() > 300) {
            btn.addClass('show');
        } else {
            btn.removeClass('show');
        }
    });

    btn.on('click', function (e) {
        e.preventDefault();
        $('html, body').animate({ scrollTop: 0 }, '300');
    });


    // sticy menu
    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('#head-nav-zon').addClass('sticky')
        } else {
            $('#head-nav-zon').removeClass('sticky')
        }
    });

    // dropdown
    $('.nav-item').mouseenter(function () {
        $(this).find('.dropdown-menu').addClass("show").addClass("animated fadeIn");
    });

    $('.nav-item').mouseleave(function () {
        $(this).find('.dropdown-menu').removeClass(" animated fadeIn").removeClass("show");
    });

    // Searching overlay
    var searchToggle = $(".search-toggle"),
        closeA = $(".scale"),
        closeB = $(".searching button"),
        cBody = $("body"),
        closeScale = closeA.add(closeB);
    if (searchToggle.length > 0) {
        searchToggle.on("click", function () {
            cBody.toggleClass("open");
            return false;
        });
    }
    if (closeScale.length > 0) {
        closeScale.on("click", function () {
            cBody.removeClass("open");
            return false;
        });
    }

    $(".close").on("click", function () {
        $("body").removeClass("open");
    });
    // /////////////////////////////////////////////////////////////////////

    // /////////////wish/////////////////
    $(document).on('click','.wish-trigger', function (e) {
        e.preventDefault();
        $("body").addClass("nav-open");
    });

    $(document).on('click', '.offcanvas-close', function (e) {
        e.preventDefault();
        $("body").removeClass("nav-open");
    });
    $(".overlays").on("click", function () {
        $("body").removeClass("nav-open");
    });
    ///////////////////card//////////////////////////////
    $(document).on('click', '.card-trigger', function (e) {
        e.preventDefault();
        $("body").addClass("nav-open-second");
    });

    $(document).on('click', '.offcanvas-close', function (e) {
        e.preventDefault();
        $("body").removeClass("nav-open-second");
    });
    $(".overlays").on("click", function () {
        $("body").removeClass("nav-open-second");
    });
    /////////////////setting////////////////////////////
    $(document).on('click', '.setting-trigger', function (e) {
        e.preventDefault();
        $("body").addClass("nav-open-third");
    });

    $(document).on('click', '.offcanvas-close', function (e) {
        e.preventDefault();
        $("body").removeClass("nav-open-third");
    });
    $(".overlays").on("click", function () {
        $("body").removeClass("nav-open-third");
    });
    /////////////////mobile////////////////////////////

    $(document).on('click', '.mobile-trigger', function (e) {
        e.preventDefault();
        $("body").addClass("nav-open-fifth");
    });

    $(document).on('click', '.offcanvas-close', function (e) {
        e.preventDefault();
        $("body").removeClass("nav-open-fifth");
    });
    $(".overlays").on("click", function () {
        $("body").removeClass("nav-open-fifth");
    });

    /////////////////////categories-grid///////////////////////////////////////////////////////////////

    $(".collapser").on("click", function () {
        $(this).toggleClass("collapsed open");
        $(this).next().collapse("toggle");
        if ($(this).children().hasClass("fa-plus")) {
            $(this).children().removeClass("fa-plus").addClass("fa-minus");
        } else {
            $(this).children().addClass("fa-plus");
        }
    });


    // priceprogress

    // var lowerSlider = document.querySelector('#lower');
    // var upperSlider = document.querySelector('#upper');

    // document.querySelector('#two').value = upperSlider.value;
    // document.querySelector('#one').value = lowerSlider.value;

    // var lowerVal = parseInt(lowerSlider.value);
    // var upperVal = parseInt(upperSlider.value);

    // upperSlider.oninput = function() {
    //     lowerVal = parseInt(lowerSlider.value);
    //     upperVal = parseInt(upperSlider.value);

    //     if (upperVal < lowerVal + 4) {
    //         lowerSlider.value = upperVal - 4;
    //         if (lowerVal == lowerSlider.min) {
    //             upperSlider.value = 4;
    //         }
    //     }
    //     document.querySelector('#two').value = this.value
    // };

    // lowerSlider.oninput = function() {
    //     lowerVal = parseInt(lowerSlider.value);
    //     upperVal = parseInt(upperSlider.value);
    //     if (lowerVal > upperVal - 4) {
    //         upperSlider.value = lowerVal + 4;
    //         if (upperVal == upperSlider.max) {
    //             lowerSlider.value = parseInt(upperSlider.max) - 4;
    //         }
    //     }
    //     document.querySelector('#one').value = this.value
    // };
    // ////////////////////////////tooltip////////////////////////////////////////////////////
    $('[data-toggle="tooltip"]').tooltip();
    /////error page
    var parallax = function (e) {
        var windowWidth = $(window).width();
        if (windowWidth < 768) return;
        var halfFieldWidth = $(".parallax").width() / 2,
            halfFieldHeight = $(".parallax").height() / 2,
            fieldPos = $(".parallax").offset(),
            x = e.pageX,
            y = e.pageY - fieldPos.top,
            newX = (x - halfFieldWidth) / 30,
            newY = (y - halfFieldHeight) / 30;
        $('.parallax [class*="wave"]').each(function (index) {
            $(this).css({
                transition: "",
                transform: "translate3d(" + index * newX + "px," + index * newY + "px,0px)"
            });
        });
    },
        stopParallax = function () {
            $('.parallax [class*="wave"]').css({
                transform: "translate(0px,0px)",
                transition: "all .7s"
            });

        };
    $(document).ready(function () {
        $(".not-found").on("mousemove", parallax);
        $(".not-found").on("mouseleave", stopParallax);
    });

});


