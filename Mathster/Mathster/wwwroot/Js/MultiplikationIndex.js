var canClick = true;

function loadPage(level, gameType) {

    getQuestion(level, gameType);

    $(".answer").click(function () {
        if (canClick) {
            canClick = false;
            clickedResult = $(".answer").index(this);
            getQuestion(level, gameType, clickedResult);
        }
    });
};

function getQuestion(level, gameType, clickedResult) {

    function sleep(time) {
        return new Promise((resolve) => setTimeout(resolve, time));
    }
    function wait(ms) {
        var start = new Date().getTime();
        var end = start;
        while (end < start + ms) {
            end = new Date().getTime();
        }
    }

    $.ajax({
        url: "/" + gameType + "/nextquestion/ " + level + " / " + clickedResult,
        type: "POST",
        data: null,
        success: function (result) {

            if (clickedResult == result.previousCorrectAnswerIndex && clickedResult != null) {

                var bgColor = $(".answer").eq(clickedResult).css("background-color");
                $(".answer").eq(clickedResult).css("background-color", "green");

                $.playSound('https://www.soundjay.com/button/sounds/button-1.mp3')

                var myArray = ["Bra jobbat!", "Snyggt!", "Naaajs!", "Fantastico!", "Mycket bra!", " ", " ", " "];
                var rand = myArray[Math.floor(Math.random() * myArray.length)];
                $("#feedback").css("display", "block");
                $("#feedback").text(rand);

                for (var i = 0; i < 4; i++) {
                    if (i != clickedResult) {
                        $(".answer").eq(i).fadeTo(500, 0);
                    }
                }
                $(".answer").eq(clickedResult);

                sleep(1000).then(() => {
                    $(".answer").eq(clickedResult).css("background-color", bgColor);
                    $(".answer").fadeTo(500, 1);
                    $("#feedback").css("display", "none");
                    $(".mobile").css("display", "block");
                    $.stopSound();

                });
            }
            else if (clickedResult != result.previousCorrectAnswerIndex && clickedResult != null) {

                var backgColor = $(".answer").eq(clickedResult).css("background-color");
                $(".answer").eq(clickedResult).css("background-color", "red");
                var backgroundColor = $(".answer").eq(result.previousCorrectAnswerIndex).css("background-color");
                $(".answer").eq(result.previousCorrectAnswerIndex).css("background-color", "green");
                $.playSound('https://www.soundjay.com/button/sounds/beep-03.mp3')

                for (var i = 0; i < 4; i++) {
                    if (i != clickedResult && i != result.previousCorrectAnswerIndex) {
                        $(".answer").eq(i).fadeTo(500, 0);
                    }
                }
                sleep(1000).then(() => {
                    $(".answer").eq(clickedResult).css("background-color", backgColor);
                    $(".answer").eq(result.previousCorrectAnswerIndex).css("background-color", backgroundColor);
                    $(".answer").fadeTo(500, 1);
                    $.stopSound();
                });
            }

            if (result.questionIndex <= result.questionTotal) { // Kom ihåg att ändra till <= !!!

                sleep(1000).then(() => {
                    $("#questionIndex").text(result.questionIndex + "/" + result.questionTotal);
                    clickedResult == result.previousCorrectAnswerIndex
                    $("#factor1").text(result.factors[0]);
                    $("#factor2").text(result.factors[1]);
                    if (gameType == "Multiplication") ($("#x").text(" x "));
                    if (gameType == "Division") ($("#x").text(" / "));
                    if (gameType == "Addition") ($("#x").text(" + "));
                    if (gameType == "Subtraction") ($("#x").text(" - "));

                    for (var i = 1; i < 5; i++) {
                        $("#answerDiv" + i).text(result.resultOptions[i - 1]);
                    }

                    $("#containerDiv").css("visibility", "visible");
                    $("#test").css("display", "none");
                    canClick = true;
                });
            }
            else {
                sleep(1000).then(() => {
                    $("#containerDiv").css("display", "none");
                    $(".starSpan").append("<i class='fas fa-star star0'></i>");
                    $(".starSpan").append("<i class='fas fa-star star1'></i>");
                    $(".starSpan").append("<i class='fas fa-star star2'></i>");
                    $(".starSpan").append("<i class='fas fa-star star3'></i>");
                    $(".starSpan").append("<i class='fas fa-star star4'></i>");

                    $(".scoreDiv").text("Du hade " + result.correctAnswers + " rätt av " + result.questionTotal);
                    $(".closeA").text("Stäng");
                    $("#resultDiv").css("display", "block");

                    sleep(1000).then(() => {

                        if (result.correctAnswers == result.questionTotal) {
                            var i = 0;

                            function myLoop() {
                                setTimeout(function () {
                                    $(".star" + [i]).css("color", "gold");
                                    $.playSound('https://www.soundjay.com/button/sounds/button-09.mp3')
                                    i++;
                                    if (i < 5) {
                                        myLoop();
                                    }
                                }, 500)
                            }
                            myLoop();

                        }
                        else if (result.correctAnswers < result.questionTotal && result.correctAnswers >= (result.questionTotal * 0.8)) {
                            var i = 0;

                            function myLoop() {
                                setTimeout(function () {
                                    $(".star" + [i]).css("color", "gold");
                                    $.playSound('https://www.soundjay.com/button/sounds/button-09.mp3')
                                    i++;
                                    if (i < 4) {
                                        myLoop();
                                    }
                                }, 500)
                            }
                            myLoop();
                        }
                        else if (result.correctAnswers < result.questionTotal && result.correctAnswers >= (result.questionTotal * 0.6)) {
                            var i = 0;

                            function myLoop() {
                                setTimeout(function () {
                                    $(".star" + [i]).css("color", "gold");
                                    $.playSound('https://www.soundjay.com/button/sounds/button-09.mp3')
                                    i++;
                                    if (i < 3) {
                                        myLoop();
                                    }
                                }, 500)
                            }
                            myLoop();
                        }
                        else if (result.correctAnswers < result.questionTotal && result.correctAnswers >= (result.questionTotal * 0.4)) {
                            var i = 0;

                            function myLoop() {
                                setTimeout(function () {
                                    $(".star" + [i]).css("color", "gold");
                                    $.playSound('https://www.soundjay.com/button/sounds/button-09.mp3')
                                    i++;
                                    if (i < 2) {
                                        myLoop();
                                    }
                                }, 500)
                            }
                            myLoop();
                        }
                        else if (result.correctAnswers < result.questionTotal && result.correctAnswers >= (result.questionTotal * 0.2)) {
                            var i = 0;

                            function myLoop() {
                                setTimeout(function () {
                                    $(".star" + [i]).css("color", "gold");
                                    $.playSound('https://www.soundjay.com/button/sounds/button-09.mp3')
                                    i++;
                                    if (i < 1) {
                                        myLoop();
                                    }
                                }, 500)
                            }
                            myLoop();
                        }
                        else if (result.correctAnswers < result.questionTotal && result.correctAnswers >= (result.questionTotal * 0.0)) {
                            var i = 0;

                            function myLoop() {
                                setTimeout(function () {
                                    $(".star" + [i]).css("color", "gold");
                                    $.playSound('https://www.soundjay.com/button/sounds/button-09.mp3')
                                    i++;
                                    if (i < 0) {
                                        myLoop();
                                    }
                                }, 500)
                            }
                            myLoop();
                        }
                    });
                });
            }
        }
    });
}






