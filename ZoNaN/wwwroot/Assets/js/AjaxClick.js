$(document).ready(function () {
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "newestOnTop": false,
        "progressBar": false,
        "positionClass": "toast-top-center",
        "preventDuplicates": false,
        "onclick": null,
        "showDuration": "300",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    }
    //-------------------Cart Add with Ajax--------------------------------------
    $(function () {
        $(document).on('click', 'a.addToCart', function (e) {
            e.preventDefault();
            let id = $(this).data("id");
            toastr.success(`just added to your cart`)
            $.get('/shop/add/' + id, {}, function (data) {
                $("a.card-trigger").html(data);

            });
        });
    });
    $(function () {
        $(document).on('click', 'a.addToNavCart', function (e) {
            e.preventDefault();
            let id = $(this).data("id");
            $.get('/shop/AddToSideNavCart/' + id, {}, function (data) {
                $("nav.nav-container-second").html(data);
            });

        });
    });

    //-------------------WishList Add with Ajax--------------------------------------
    $(function () {
        $(document).on('click', 'a.addToWish', function (e) {
            e.preventDefault();
            let id = $(this).data("id");
            toastr.success(`just added to your wishlist`)
            $.get('/shop/AddToWish/' + id, {}, function (data) {
                $("a.wish-trigger").html(data);

            });
        });
    });
    $(function () {
        $(document).on('click', 'a.addToNavWish', function (e) {
            e.preventDefault();
            let id = $(this).data("id");
            $.get('/shop/AddToWishNavWish/' + id, {}, function (data) {
                $("nav.nav-container").html(data);
            });
        });
    });
    //-------------------Compare Add with Ajax--------------------------------------
    $(function () {
        $(document).on('click', 'a.addCompare', function (e) {
            e.preventDefault();
            let id = $(this).data("id");
            toastr.success(`just added to  Compare`)
            $.get('/Product/AddToCompare/' + id, {}, function (data) {
                $("a.compare-items").html(data);

            });
        });
    });
    //-------------------Compare Add with Ajax--------------------------------------
    $(function () {
        $(document).on('click', 'a.remove', function (e) {
            e.preventDefault();
            
            let id = $(this).data("id");  
            $.get('/shop/remove/' + id, {}, function (data) {
                
                $("nav.nav-container-second").html(data);
         
            });
            $.post('/shop/RemoveIconBadgeCount/' + id, {}, function (data) {

                $("a.card-trigger").html(data);

            });
        }); 
    });

    //-------------------WishNav remove with Ajax--------------------------------------

    $(function () {
        $(document).on('click', 'a.remove-wish', function (e) {
            e.preventDefault();

            let id = $(this).data("id");

            console.log(id);
            $.get('/shop/RemoveFromWish/' + id, {}, function (data) {

                $("nav.nav-container").html(data);

            });
            $.post('/shop/RemoveFromWishIconBadgeCount/' + id, {}, function (data) {

                $("a.wish-trigger").html(data);

            });
        });
    });
    //-------------------Compare page remove with Ajax--------------------------------------
    $(function () {
        $(document).on('click', 'a.remove-compare', function (e) {
            e.preventDefault();

            let id = $(this).data("id");

            console.log(id);
            //$.get('/shop/RemoveFromCompare/' + id, {}, function (data) {

            //    $("nav.nav-container").html(data);

            //});
            //$.post('/shop/RemoveFromWishIconBadgeCount/' + id, {}, function (data) {

            //    $("a.wish-trigger").html(data);

            //});
        });
    });
});

