using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathster.Models;
using Mathster.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mathster.Controllers
{
    public class MultiplikationController : Controller
    {

        //MultiplikationIndexVM multiplikationIndexVM = new MultiplikationIndexVM();
        private readonly Repository repository;
        public MultiplikationController(Repository repository)
        {
            this.repository = repository;
        }

        [Route("Multiplikation/{id}")]
        public IActionResult Index(int id)
        {
            var model = repository.GetMultiplicationIndexVM(id);

            return View(model);
        }
        [HttpPost]
        [Route("Multiplikation/nyUppgift/{id}/{clickedAnswer}")]
        public MultiplicationNewQuestionVM NewQuestion(int id, int? clickedAnswer)
        {

            if (clickedAnswer == null)
            {
                List<string> userAnswers = new List<string>();

                var str = JsonConvert.SerializeObject(userAnswers);
                HttpContext.Session.SetString("ListOfAnswers", str);
            }
          
             

            var answerBool = HttpContext.Session.GetInt32("AnswerBool");
            
            bool b;
            var key = HttpContext.Session.GetString("ListOfAnswers");
            var listOfAnswers = JsonConvert.DeserializeObject<List<string>>(key);
            if (answerBool == clickedAnswer)
            {

                b = true;
                listOfAnswers.Add("Rätt");
                var str = JsonConvert.SerializeObject(listOfAnswers);
                HttpContext.Session.SetString("ListOfAnswers", str);

            }
            
            else
            {
                b = false;
                listOfAnswers.Add("Fel");
                var str = JsonConvert.SerializeObject(listOfAnswers);
                HttpContext.Session.SetString("ListOfAnswers", str);
            }
            
          
            var model = repository.MultiplicationRandomizer(id);
            
            
          
            model.PreviousCorrectAnswer = b;
            
            

             model.QuestionIndex = listOfAnswers.Count;
            if (model.QuestionIndex > 3)
            {
                
            }
            

            var factor1 = model.MultipliedFactors[0];
            var factor2 = model.MultipliedFactors[1];
            var resultOfFactors = factor1 * factor2;


            HttpContext.Session.SetInt32("AnswerBool", resultOfFactors);
            return model;


        }
    }
}
