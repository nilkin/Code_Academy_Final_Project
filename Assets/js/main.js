$(document).ready(function() {

    $(window).scroll(function() {
        if ($(this).scrollTop() > 100) {
            $('#head-nav-zon').addClass('sticky')
        } else {
            $('#head-nav-zon').removeClass('sticky')
        }
    });

    // dropdown
    $('.nav-item').mouseenter(function() {
        $(this).find('.dropdown-menu').addClass("show").addClass("animated fadeIn");
    });

    $('.nav-item').mouseleave(function() {
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
            settings: { dots: false, arrows: false }
        }, ],

    }).slickAnimation();

    function progressBar() {
        $(".slick-progress").find("span").removeAttr("style");
        $(".slick-progress").find("span").removeClass("active");
        setTimeout(function() {
            $(".slick-progress").find("span").css("transition-duration", $timer / 1000 + "s").addClass("active");
        }, 100);
    }

    progressBar();
    $('.home-carousel').on("beforeChange", function(e, slick) {
        progressBar();
    });
    // blog-section-slider
    // blog-section-slider
    $('.new-blog-carousel').slick({

        dots: false,
        arrows: true,
        infinite: false,
        slidesToShow: 3,
        slidesToScroll: 3,
        prevArrow: "<div class='arrows'><button type='button' class='prev slick-prev pull-left'><i class='fa fa-angle-left' aria-hidden='true'></i></button></div>",
        nextArrow: "<div class='arrows'><button type='button' class='next slick-next pull-right'><i class='fa fa-angle-right' aria-hidden='true'></i></button></div>",

        responsive: [{
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                    dots: true
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    });
    //product tab  
    $('.product-tab-slider').slick({
        dots: false,
        arrows: true,
        infinite: false,
        slidesToShow: 4,
        slidesToScroll: 4,
        prevArrow: "<div class='arrows'><button type='button' class='prev slick-prev pull-left'><i class='fa fa-angle-left' aria-hidden='true'></i></button></div>",
        nextArrow: "<div class='arrows'><button type='button' class='next slick-next pull-right'><i class='fa fa-angle-right' aria-hidden='true'></i></button></div>",

        responsive: [{
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    });
    $('a[data-toggle="tab"]').on('shown.bs.tab', function(e) {
            $('.product-tab-slider').slick('setPosition');
        })
        // feature-slider
    $('.feature-slider').slick({
        dots: false,
        arrows: true,
        infinite: false,
        slidesToShow: 4,
        slidesToScroll: 4,
        prevArrow: "<div class='arrows'><button type='button' class='prev slick-prev pull-left'><i class='fa fa-angle-left' aria-hidden='true'></i></button></div>",
        nextArrow: "<div class='arrows'><button type='button' class='next slick-next pull-right'><i class='fa fa-angle-right' aria-hidden='true'></i></button></div>",

        responsive: [{
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    });
    // new-products
    $('.new-products').slick({
        dots: false,
        arrows: true,
        infinite: false,
        slidesToShow: 5,
        slidesToScroll: 5,
        prevArrow: "<div class='arrows'><button type='button' class='prev slick-prev pull-left'><i class='fa fa-angle-left' aria-hidden='true'></i></button></div>",
        nextArrow: "<div class='arrows'><button type='button' class='next slick-next pull-right'><i class='fa fa-angle-right' aria-hidden='true'></i></button></div>",

        responsive: [{
                breakpoint: 1024,
                settings: {
                    slidesToShow: 3,
                    slidesToScroll: 3,
                    infinite: true,
                }
            },
            {
                breakpoint: 600,
                settings: {
                    slidesToShow: 2,
                    slidesToScroll: 2
                }
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1
                }
            }
        ]
    });
    //  testimonial-init
    const $testimonial = $(".testimonial-init");

    $testimonial.slick({
        autoplay: false,
        autoplaySpeed: 10000,
        dots: true,
        infinite: false,
        arrows: false,
        speed: 1000,
        slidesToShow: 1,
        slidesToScroll: 1,
        responsive: [{
                breakpoint: 1280,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    infinite: false,
                    dots: true,
                },
            },
            {
                breakpoint: 991,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                    autoplay: true,
                },
            },

            {
                breakpoint: 768,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                    autoplay: true,
                },
            },
            {
                breakpoint: 480,
                settings: {
                    slidesToShow: 1,
                    slidesToScroll: 1,
                    arrows: false,
                    autoplay: true,
                },
            },
            // You can unslick at a given breakpoint now by adding:
            // settings: "unslick"
            // instead of a settings object
        ],
    });

    // Searching overlay
    var searchToggle = $(".search-toggle"),
        closeA = $(".scale"),
        closeB = $(".searching button"),
        cBody = $("body"),
        closeScale = closeA.add(closeB);
    if (searchToggle.length > 0) {
        searchToggle.on("click", function() {
            cBody.toggleClass("open");
            return false;
        });
    }
    if (closeScale.length > 0) {
        closeScale.on("click", function() {
            cBody.removeClass("open");
            return false;
        });
    }

    $(".close").on("click", function() {
        $("body").removeClass("open");
    });
    // /////////////////////////////////////////////////////////////////////

    // /////////////wish/////////////////
    $(".wish-trigger").on("click", function() {
        $("body").addClass("nav-open");
    });

    $(".offcanvas-close").on("click", function() {
        $("body").removeClass("nav-open");
    });
    $(".overlays").on("click", function() {
        $("body").removeClass("nav-open");
    });
    ///////////////////card//////////////////////////////
    $(".card-trigger").on("click", function() {
        $("body").addClass("nav-open-second");
    });

    $(".offcanvas-close").on("click", function() {
        $("body").removeClass("nav-open-second");
    });
    $(".overlays").on("click", function() {
        $("body").removeClass("nav-open-second");
    });
    /////////////////setting////////////////////////////

    $(".setting-trigger").on("click", function() {
        $("body").addClass("nav-open-third");
    });

    $(".offcanvas-close").on("click", function() {
        $("body").removeClass("nav-open-third");
    });
    $(".overlays").on("click", function() {
        $("body").removeClass("nav-open-third");
    });
    /////////////////mobile////////////////////////////

    $(".mobile-trigger").on("click", function() {
        $("body").addClass("nav-open-fifth");
    });

    $(".offcanvas-close").on("click", function() {
        $("body").removeClass("nav-open-fifth");
    });
    $(".overlays").on("click", function() {
        $("body").removeClass("nav-open-fifth");
    });
    //////////////////////////////////////////////////////////////
    $(".product-sync-init").slick({
        slidesToShow: 1,
        slidesToScroll: 1,
        infinite: true,
        draggable: false,
        arrows: false,
        dots: false,
        fade: true,
        asNavFor: ".product-sync-nav",
    });
    $(".product-sync-nav").slick({
        dots: false,
        arrows: true,
        infinite: true,
        prevArrow: '<button class="next slick-prev"><i class="fas fa-chevron-left"></i></button>',
        nextArrow: '<button class="prev slick-next"><i class="fas fa-chevron-right"></i></button>',
        slidesToShow: 4,
        slidesToScroll: 1,
        asNavFor: ".product-sync-init",
        focusOnSelect: true,
        draggable: false,
    });
    //////////////////////////////////////////////////////////////////////
    const [tabs, tabsPanels] = [
        Array.from(document.querySelectorAll(".tabs li")),
        Array.from(document.querySelectorAll(".tabs-panel"))
    ];

    tabs.forEach((tab) => {
        tab.addEventListener("click", () => {
            const target = document.querySelector(`#${tab.dataset.target}`);
            removeActiveClass([tabs, tabsPanels]);
            tab.classList.add("active");
            target.classList.add("active");
        });
    });

    const removeActiveClass = (el) => {
        el.forEach((item) => {
            item.find((e) => e.classList.contains("active")).classList.remove("active");
        });
    };
    ////////////////////////////////////////////////////////////////////////////////////

    $(".collapser").on("click", function() {
        $(this).toggleClass("collapsed open");
        $(this).next().collapse("toggle");
        if ($(this).children().hasClass("fa-plus")) {
            $(this).children().removeClass("fa-plus").addClass("fa-minus");
        } else {
            $(this).children().addClass("fa-plus");
        }
    });

    // ///////////////////////////////////////////////////////////////////
    // priceprogress

    var lowerSlider = document.querySelector('#lower');
    var upperSlider = document.querySelector('#upper');

    document.querySelector('#two').value = upperSlider.value;
    document.querySelector('#one').value = lowerSlider.value;

    var lowerVal = parseInt(lowerSlider.value);
    var upperVal = parseInt(upperSlider.value);

    upperSlider.oninput = function() {
        lowerVal = parseInt(lowerSlider.value);
        upperVal = parseInt(upperSlider.value);

        if (upperVal < lowerVal + 4) {
            lowerSlider.value = upperVal - 4;
            if (lowerVal == lowerSlider.min) {
                upperSlider.value = 4;
            }
        }
        document.querySelector('#two').value = this.value
    };

    lowerSlider.oninput = function() {
        lowerVal = parseInt(lowerSlider.value);
        upperVal = parseInt(upperSlider.value);
        if (lowerVal > upperVal - 4) {
            upperSlider.value = lowerVal + 4;
            if (upperVal == upperSlider.max) {
                lowerSlider.value = parseInt(upperSlider.max) - 4;
            }
        }
        document.querySelector('#one').value = this.value
    };
    // ////////////////////////////////////////////////////////////////////////////////
    $(function() {
        $('[data-toggle="tooltip"]').tooltip()
    })


});