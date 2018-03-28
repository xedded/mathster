function loadPage(id) {
    var clickedResult = null;
    function sleep(time) {
        return new Promise((resolve) => setTimeout(resolve, time));
    }

    getQuestion(id, clickedResult);

    $(".answer").click(function () {
        if ($(this).text() != ($(".factor1").text() * $(".factor2").text())) {
            var bgColor = $(this).css("background-color")
            $($(this)).css("background-color", "red");
            sleep(2000).then(() => {
                $($(this)).css("background-color", bgColor);
                clickedResult = $(this).text();
                getQuestion(id, clickedResult);
            });
        }
        if ($(".answer1").text() == ($(".factor1").text() * $(".factor2").text())) {
            $(".answer1").css("background-color", "green");
            sleep(2000).then(() => {
                $(".answer1").css("background-color", "#47826d");
                clickedResult = $(this).text();
                getQuestion(id, clickedResult);
            });
        }
        if ($(".answer2").text() == ($(".factor1").text() * $(".factor2").text())) {
            $(".answer2").css("background-color", "green");
            sleep(2000).then(() => {
                $(".answer2").css("background-color", "#87b52d");
                clickedResult = $(this).text();
                getQuestion(id, clickedResult);
            });
        }
        if ($(".answer3").text() == ($(".factor1").text() * $(".factor2").text())) {
            $(".answer3").css("background-color", "green");
            sleep(2000).then(() => {
                $(".answer3").css("background-color", "#60b394");
                clickedResult = $(this).text();
                getQuestion(id, clickedResult);
            });
        }
        if ($(".answer4").text() == ($(".factor1").text() * $(".factor2").text())) {
            $(".answer4").css("background-color", "green");
            sleep(2000).then(() => {
                $(".answer4").css("background-color", "#a6d13d");
                clickedResult = $(this).text();
                getQuestion(id, clickedResult);
            });
        }
    });
};


function getQuestion(id, clickedResult) {
    $.ajax({
        url: "/multiplikation/nyUppgift/" + id + "/" + clickedResult,
        type: "POST",
        data: null,
        success: function (result) {

            var factor1 = result.multipliedFactors[0];
            var factor2 = result.multipliedFactors[1];
            $("#boolDiv").text(result.questionIndex + "/" + result.questionTotal);
            $("#factor1").text(factor1);
            $("#x").text(" x ");
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
    });
}





