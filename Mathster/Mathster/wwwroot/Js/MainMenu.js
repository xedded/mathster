﻿function loadPage() {

    $('ul').css("display", "none");

    $('.easyA').text("LÄTT");
    $('.mediumA').text("MEDEL");
    $('.hardA').text("SVÅR");
    $(".video").text("VIDEO");
    $('.slash').text("/").css("font-size", "10em");

  
        



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
    $('#instructionVideo').hover(function () {
        $('.fa-play').css('display', 'none')
        $('#videoList').css('display', 'block')
    },
        function () {
            $('.fa-play').css('display', 'block')
            $('#videoList').css('display', 'none')
        }
    );
    $('#settings').hover(function () {
        $('.fa-cog').css('display', 'none')
        $('#questions').css('display', 'block')
    },
        function () {
            $('.fa-cog').css('display', 'block')
            $('#questions').css('display', 'none')
        }
    );





};
