using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathster.Models;
using Mathster.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
        public MultiplicationNewQuestionVM NewQuestion(int id, int clickedAnswer)
        {
            var answerBool = HttpContext.Session.GetInt32("AnswerBool");
            bool b;
            if (answerBool == clickedAnswer)
                b = true;
            else
                b = false;
            
            var model = repository.MultiplicationRandomizer(id);
            model.PreviousCorrectAnswer = b;


            //Är session samma sak som clickedAnswer
            //skapa en lista om clickedAnswer är null
            //Lägg till true/false i model proppen
            //lägg till räknare i andra proppen

            var factor1 = model.MultipliedFactors[0];
            var factor2 = model.MultipliedFactors[1];
            var resultOfFactors = factor1 * factor2;
            HttpContext.Session.SetInt32("AnswerBool", resultOfFactors);
            return model;


        }
    }
}
