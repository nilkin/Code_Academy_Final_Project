$(document).ready(function () {
    //----------------Newsletter Subscribers input---------------

    $(".subscr-form").submit(function (e) {
        e.preventDefault();
        let formData = {
            email: $(this).find("input[name='Email']").val()
        };

        $.ajax({
            url: "/home/index",
            type: "post",
            data: formData,
            dataType: "json",
            beforeSend: function () {
            },
            success: function (res) {

                swal(`${res.message}`, "Thank you for subscription", "success");
            },
            error: function (err) {
                if (err.status === 404) {
                    swal("Notice!", err.responseJSON.message);
                }
                else if (err.status === 400) {
                    swal("Notice!", err.responseJSON.message);
                }
            },
            complete: function () {
                $("input[name='Email']").val("");
            }
        });
    });



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
    //-------------------Cart remove with Ajax--------------------------------------
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
            $.post('/product/RemoveAjax/' + id, {}, function (data) {

                $("body").html(data);

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
            swal({
                title: "Are you sure?",
                text: "Once deleted, you will not be able to recover this imaginary file!",
                icon: "warning",
                buttons: true,
                dangerMode: true,
            })
                .then((g) => {
                    if (g) {
                        swal("Poof! Your imaginary file has been deleted!", {
                            icon: "success",
                        });
            $.get('/product/RemoveFromCompare/' + id, {}, function (data) {

                $("a.compare-items").html(data);

            });
            $.post('/product/RemoveFromCompareAjax/' + id, {}, function (data) {

                $("body").html(data);

            });
                    } else {
                        swal("Your file is safe!");
                    }
                });


        });
    });
    //-------------------Compare page add to Cart with Ajax--------------------------------------
    $(function () {
        $(document).on('click', 'a.add-from-compare-to-cart', function (e) {
            e.preventDefault();

            let id = $(this).data("id");

            $.post('/product/AddFromCompareToCart/' + id, {}, function (data) {

                $("a.compare-items").html(data);

            });
            $.post('/product/AddFromCompareToCartAjax/' + id, {}, function (data) {

                $("body").html(data);

            });
        });
    });
    //-------------------Remove Cart item with Ajax--------------------------------------
    $(function () {
        $(document).on('click', 'a.cart-trash', function (e) {
            e.preventDefault();

            let id = $(this).data("id");
            swal({
                title: "Are you sure?",
                text: "Once deleted, you will not be able to recover this imaginary file!",
                icon: "warning",
                buttons: true,
                dangerMode: true,
            })
                .then((g) => {
                    if (g) {
                        swal("Poof! Your imaginary file has been deleted!", {
                            icon: "success",
                        });
            $.post('/shop/RemoveBadgeAjax/' + id, {}, function (data) {

                $("a.cart-trigger").html(data);


            });
            $.post('/shop/RemoveAjax/' + id, {}, function (data) {

                $("body").html(data);

            });
                    } else {
                        swal("Your file is safe!");
                    }
                });

        });
    });

    //-------------------Wish page add to Cart with Ajax--------------------------------------
    $(function () {
        $(document).on('click', 'a.add-from-wish-to-cart', function (e) {
            e.preventDefault();

            let id = $(this).data("id");

            $.post('/shop/AddFromWishToCart/' + id, {}, function (data) {

                $("a.wish-trigger").html(data);

            });
            $.post('/shop/AddFromWishToCartAjax/' + id, {}, function (data) {

                $("body").html(data);

            });
        });
    });

    //-------------------Wish Cart item delete with Ajax--------------------------------------
    $(function () {
        $(document).on('click', 'a.wish-trash', function (e) {
            e.preventDefault();

            let id = $(this).data("id");
            swal({
                title: "Are you sure?",
                text: "Once deleted, you will not be able to recover this imaginary file!",
                icon: "warning",
                buttons: true,
                dangerMode: true,
            })
                .then((g) => {
                    if (g) {
                        swal("Poof! Your imaginary file has been deleted!", {
                            icon: "success",
                        });
                        $.post('/shop/RemoveFromWishIconBadgeCount/' + id, {}, function (data) {

                            $("a.compare-items").html(data);

                        });
                        $.post('/shop/RemoveFromWishAjax/' + id, {}, function (data) {

                            $("body").html(data);

                        });
                    } else {
                        swal("Your file is safe!");
                    }
                });
        });
    });

    //------------------- Cart item increase with Ajax--------------------------------------
    //$(function () {
    //    $(document).on('click', 'a.increment', function (e) {
    //        e.preventDefault();
         
    //        let id = $(this).data("id");
    //        $.post('/shop/Increase/' + id, {}, function (data) {
    //            console.log(data);
    //            //$("body").html(data);

    //        });
    //    });
    //});
});

$(document).ready(function () {

    $(".quick-open").click(function () {
        let id = $(this).data("id");
     
        $.ajax({
            url: "/search/quickview/" + id,
            type: "get",
            dataType: "html",
            beforeSend: function () {
            },
            success: function (response) {
                $('#quick-view').find(".modal-content").html(response);
            },
            error: function (error) {
                console.log(error);
            },
            complete: function () {
                $("#quick-view").modal('show')
            }
        });

    });
})