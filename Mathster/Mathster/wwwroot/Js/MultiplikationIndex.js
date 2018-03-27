$(document).ready(function() {
    $(".answer").click(function () {
        var checkAnswer = $(this).attr(".answer").val();
        




        console.log(checkAnswer);


        //$.ajax({
        //    url: "/home/FoodWithBeer/",
        //    type: "GET",
        //    data: { "id": beerId },
        //    success: function (result) {
        //        console.log(result);

        //        $("#showBeer").html(result);
        //    }
        //});
    });
});