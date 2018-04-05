function loadPage() {

    $('ul').css("display", "none");

    $('.easyA').text("LÄTT");
    $('.mediumA').text("MEDEL");
    $('.hardA').text("SVÅR");
    $(".video").text("VIDEO");
    $('.slash').text("/").css("font-size", "10em");

    if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {

        $('#multiplication').click(function () {
            $('.fa-times').css('display', 'none')
            $('#multiList').css('display', 'block')
            $('#plusList').css('display', 'none')
            $('#divList').css('display', 'none')
            $('#minusList').css('display', 'none')
        });

        $('#division').click(function () {
            $('.fa-times').css('display', 'none')
            $('#multiList').css('display', 'none')
            $('#plusList').css('display', 'none')
            $('#divList').css('display', 'block')
            $('#minusList').css('display', 'none')
        });

        $('#addition').click(function () {
            $('.fa-times').css('display', 'none')
            $('#multiList').css('display', 'none')
            $('#plusList').css('display', 'block')
            $('#divList').css('display', 'none')
            $('#minusList').css('display', 'none')
        });
        $('#subtraction').click(function () {
            $('.fa-times').css('display', 'none')
            $('#multiList').css('display', 'none')
            $('#plusList').css('display', 'none')
            $('#divList').css('display', 'none')
            $('#minusList').css('display', 'block')
        });
    }

    $('#multiplication').hover(function () {
        $('.fa-times').css('display', 'none')
        $('#multiList').css('display', 'block')
    },
        function () {
            $('.fa-times').css('display', 'block')
            $('#multiList').css('display', 'none')
        }
    );
    $('#division').hover(function () {
        $('.slash').css('display', 'none')
        $('#divList').css('display', 'block')
    },
        function () {
            $('.slash').css('display', 'block')
            $('#divList').css('display', 'none')
        }
    );
    $('#addition').hover(function () {
        $('.fa-plus').css('display', 'none')
        $('#plusList').css('display', 'block')
    },
        function () {
            $('.fa-plus').css('display', 'block')
            $('#plusList').css('display', 'none')
        }
    );
    $('#subtraction').hover(function () {
        $('.fa-minus').css('display', 'none')
        $('#minusList').css('display', 'block')
    },
        function () {
            $('.fa-minus').css('display', 'block')
            $('#minusList').css('display', 'none')
        }
    );
};
