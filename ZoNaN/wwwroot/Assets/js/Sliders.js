$(document).ready(function () {
    // ////////////////////////////tooltip////////////////////////////////////////////////////
    $('[data-toggle="tooltip"]').tooltip();
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
        },],

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
                dots: false
            }
        },
        {
            breakpoint: 600,
            settings: {
                slidesToShow: 2,
                slidesToScroll: 2,
                dots: false
            }
        },
        {
            breakpoint: 480,
            settings: {
                slidesToShow: 1,
                slidesToScroll: 1,
                dots: false
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
    $('a[data-toggle="tab"]').on('shown.bs.tab', function (e) {
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
    /////////////////////////single Product/////////////////////////////////////
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

});