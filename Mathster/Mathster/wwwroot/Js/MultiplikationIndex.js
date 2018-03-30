var canClick = true;

function loadPage(level, gameType) {

    getQuestion(level, gameType);
    // skapa en variabel canclick, sätt den till false och sedan till true efter ajax

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
    $.ajax({
        url: "/" + gameType + "/nextquestion/ " + level + " / " + clickedResult,
        type: "POST",
        data: null,
        success: function (result) {

            if (clickedResult == result.previousCorrectAnswerIndex && clickedResult != null) {

                var bgColor = $(".answer").eq(clickedResult).css("background-color");
                $(".answer").eq(clickedResult).css("background-color", "green");
                sleep(1000).then(() => {
                    $(".answer").eq(clickedResult).css("background-color", bgColor);
                });
            }
            else if (clickedResult != result.previousCorrectAnswerIndex && clickedResult != null) {

                var backgColor = $(".answer").eq(clickedResult).css("background-color");
                $(".answer").eq(clickedResult).css("background-color", "red");
                var backgroundColor = $(".answer").eq(result.previousCorrectAnswerIndex).css("background-color");
                $(".answer").eq(result.previousCorrectAnswerIndex).css("background-color", "green");
                sleep(1000).then(() => {
                    $(".answer").eq(clickedResult).css("background-color", backgColor);
                    $(".answer").eq(result.previousCorrectAnswerIndex).css("background-color", backgroundColor);
                });
            }

            if (result.questionIndex < result.questionTotal) {

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
                    canClick = true;
                });
            }
            else {
                $("#containerDiv").css("display", "none");

                $("#resultDiv").css("display", "block");

            }
        }
    });
}






