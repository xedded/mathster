           
$(document).ready(function () {
    //var test = 0;
    //doSomething(test++);
    //function doSomething(test) {
    //    if (test < 3) {
            
            $(".answer").click(function () {

                var checkAnswer = $(this).text();

                var correctAnswer = $(".correctAnswer").text();

                if (checkAnswer == correctAnswer) {

                    alert("rätt svar");

                }
                else {
                    alert("fel svar");
                }
                
                location.reload();
                
            });

        //}
    //    else {
    //        alert("Spelet är slut");
    //    }
    //}
    
});



