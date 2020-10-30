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
    // blog-section-slider
    $('.new-blog-carousel').slick({
        
        dots: false,
        arrows: true,
        infinite: false,
        slidesToShow: 3,
        slidesToScroll: 3,
        prevArrow: $('.prev'),
        nextArrow: $('.next'),
        responsive: [
          {
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
var closestsElementClass = function (elem, className) {
  var node = elem;
  while (node) {

    if (node.classList.contains(className)) {
      return node;
    }

    node = node.parentElement;
  }

  return null;
}
var catalog = document.querySelector('.portfolio-container');
var catalogNav = document.querySelector('.filter__tabs');
var catalogItems = document.querySelectorAll('.portfolio__item');
function removeChildren(item) {
  while (item.firstChild) {
    item.removeChild(item.firstChild)
  }
}
function updateChildren(item, children) {
  removeChildren(item);
  for (var i = 0; i < children.length; i++) {
    item.appendChild(children[i]);
  }
}
catalogNav.addEventListener('click', function (e) {
  var target = e.target;
  var item = closestsElementClass(target, 'filter__btn');
  if (item === null || item.classList.contains('is-active')) {
    return;
  }
  e.preventDefault();
  var filterValue = item.getAttribute('data-filter');
  var previousActiveBtn = document.querySelector('.filter__btn.is-active');
  previousActiveBtn.classList.remove('is-active');
  item.classList.add('is-active');

  if (filterValue === 'all') {
    updateChildren(catalog, catalogItems);
    return;
  }
  var filteredItems = [];
  for (var i = 0; i < catalogItems.length; i++) {
    var currentItem = catalogItems[i];
    if (currentItem.getAttribute('data-category') === filterValue) {
      filteredItems.push(currentItem);
    }
  }
  updateChildren(catalog, filteredItems);
});

  });