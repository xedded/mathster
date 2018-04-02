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

                $("#feedback").css("display", "block");
                var myArray = ["Bra Jobbat!", "Snyggt!", "Niiiiice!"];
                var rand = myArray[Math.floor(Math.random() * myArray.length)];
                console.log(rand);
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
                    
                });
            }
            else if (clickedResult != result.previousCorrectAnswerIndex && clickedResult != null) {

                var backgColor = $(".answer").eq(clickedResult).css("background-color");
                $(".answer").eq(clickedResult).css("background-color", "red");
                var backgroundColor = $(".answer").eq(result.previousCorrectAnswerIndex).css("background-color");
                $(".answer").eq(result.previousCorrectAnswerIndex).css("background-color", "green");
                for (var i = 0; i < 4; i++) {
                    if (i != clickedResult && i != result.previousCorrectAnswerIndex) {
                        $(".answer").eq(i).fadeTo(500, 0);
                    }
                }
                sleep(1000).then(() => {
                    $(".answer").eq(clickedResult).css("background-color", backgColor);
                    $(".answer").eq(result.previousCorrectAnswerIndex).css("background-color", backgroundColor);
                    $(".answer").fadeTo(500, 1);
                });
            }

            //if (clickedResult && result.previousCorrectAnswerIndex != result.resultOptions[0] || clickedResult && result.previousCorrectAnswerIndex != result.resultOptions[1] || clickedResult && result.previousCorrectAnswerIndex != result.resultOptions[2] || clickedResult && result.previousCorrectAnswerIndex != result.resultOptions[3] ) {
            //    $(".answer").eq().css("background-color", "lime");
            //}

            if (result.questionIndex <= result.questionTotal) {

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
                    $("#resultDiv").text("Du hade " + result.correctAnswers + " rätt av " + result.questionTotal);

                $("#resultDiv").css("display", "block");

                });

            }
        }
    });
}






