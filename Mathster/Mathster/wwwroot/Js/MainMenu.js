function loadPage() {

    $('ul').css("display", "none");
    $('.easyA').text("LÄTT");
    $('.mediumA').text("MEDEL");
    $('.hardA').text("SVÅR");
    $('.mathster').text("MATHSTER");

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
        $('.fa-bug').css('display', 'none')
        $('#divList').css('display', 'block')
    },
        function () {
            $('.fa-bug').css('display', 'block')
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
    $('#instructionVideo').hover(function () {
        $('.fa-video').css('display', 'none')
        $('#videoList').css('display', 'block')
    },
        function () {
            $('.fa-video').css('display', 'block')
            $('#videoList').css('display', 'none')
        }
    );

    
    $('#instructionVideo').hover(function () {
        $('.fa-video').css('display', 'none')
        $('#videoList').css('display', 'block')
    },
        function () {
            $('.fa-video').css('display', 'block')
            $('#videoList').css('display', 'none')
        }
    );
    $("#mathster").In(500);



};
