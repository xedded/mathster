function loadPage(level, gameType) {



    var clickedResult = null;
    function sleep(time) {
        return new Promise((resolve) => setTimeout(resolve, time));
    }

    getQuestion(level, gameType, clickedResult);


    $(".answer").click(function () {
        clickedResult = $(this).text();

        var bgColor = $(this).css("background-color")
        if ($(this).text() != ($(".factor1").text() / $(".factor2").text())) {
            $($(this)).css("background-color", "red");
        }

        if ($(".answer1").text() == ($(".factor1").text() / $(".factor2").text())) {
            $(".answer1").css("background-color", "green");
            sleep(1000).then(() => {
                $(".answer1").css("background-color", "#47826d");
                $($(this)).css("background-color", bgColor);

                getQuestion(level, gameType, clickedResult);
            });
        }
        if ($(".answer2").text() == ($(".factor1").text() / $(".factor2").text())) {
            $(".answer2").css("background-color", "green");
            sleep(1000).then(() => {
                $(".answer2").css("background-color", "#87b52d");
                $($(this)).css("background-color", bgColor);

                getQuestion(level, gameType, clickedResult);
            });
        }
        if ($(".answer3").text() == ($(".factor1").text() / $(".factor2").text())) {
            $(".answer3").css("background-color", "green");
            sleep(1000).then(() => {
                $(".answer3").css("background-color", "#60b394");
                $($(this)).css("background-color", bgColor);

                getQuestion(level, gameType, clickedResult);
            });
        }
        if ($(".answer4").text() == ($(".factor1").text() / $(".factor2").text())) {
            $(".answer4").css("background-color", "green");
            sleep(1000).then(() => {
                $(".answer4").css("background-color", "#a6d13d");
                $($(this)).css("background-color", bgColor);

                getQuestion(level, gameType, clickedResult);
            });
        }
    });
};


function getQuestion(level, gameType, clickedResult) {
    $.ajax({
        url: "/" + gameType + "/nextquestion/ " + level + " / " + clickedResult,
        type: "POST",
        data: null,
        success: function (result) {


            if (result.questionIndex < 5) {

                var factor1 = result.factors[0];
                var factor2 = result.factors[1];
                $("#boolDiv").text(result.questionIndex + "/" + result.questionTotal);


                $("#factor1").text(factor1);
                if (gameType == "Multiplication") {
                    $("#x").text(" x ");
                }
                if (gameType == "Division") {
                    $("#x").text(" / ");
                }
                if (gameType == "Addition") {
                    $("#x").text(" + ");
                }
                if (gameType == "Subtraction") {
                    $("#x").text(" - ");
                }
                $("#factor2").text(factor2);



                var option1 = result.resultOptions[0];
                var option2 = result.resultOptions[1];
                var option3 = result.resultOptions[2];
                var option4 = result.resultOptions[3];

                $("#answerDiv1").text(option1);
                $("#answerDiv2").text(option2);
                $("#answerDiv3").text(option3);
                $("#answerDiv4").text(option4);

                $("#containerDiv").css("visibility", "visible");
            }
            else {
                $("#containerDiv").css("display", "none");

                $("#resultDiv").css("display", "block");
                var numOfTrue = 0;
                var svar = result.list;
                console.log(svar);
                if (svar != null) {
                    for (var i = 1; i < 5; i++) {
                        if (svar[i] == "Rätt") {
                            numOfTrue++;
                        }
                    }
                    console.log(numOfTrue);
                    $("#resultDiv").css("height", "200px");
                    $("#resultDiv").css("width", "100px");
                    $("#resultDiv").css("background-color", "#60b394");
                    $("#resultDiv").css("border", "solid");
                    $("#resultDiv").css("border-color", "white");
                    $("#resultDiv").css("border-radius", "20%");
                    $("#resultDiv").css("border-width", "10px");



                    if (numOfTrue > 1) {
                        $("#feedback").text("Bra jobbat!")
                    }
                    $("#result").text("Du fick" + numOfTrue + "rätt av" + result.questionTotal)


                }

            }
        }
    });
}





