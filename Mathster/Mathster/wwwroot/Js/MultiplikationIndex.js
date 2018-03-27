function getQuestion(id) {
    $.ajax({
        url: "/multiplikation/nyUppgift/" + id,
        type: "GET",
        data: null,
        success: function (result) {
            var factor1 = result.multipliedFactors[0];
            var factor2 = result.multipliedFactors[1];

            $("#questionDiv").text(factor1 + " x " + factor2);

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





