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
        private readonly QuestionService questionService;
        public MultiplikationController(QuestionService questionService)
        {
            this.questionService = questionService;
        }

        [Route("Multiplikation/{id}")]
        public IActionResult Index(int id)
        {
            var model = questionService.GetMultiplicationIndexVM(id);

            return View(model);
        }
        [HttpPost]
        [Route("Multiplikation/nyUppgift/{id}/{clickedAnswer}")]
        public MultiplicationNewQuestionVM NewQuestion(int id, int? clickedAnswer)
        {
            return questionService.GetNewQuestion(id, clickedAnswer, HttpContext);
            
           


        }
    }
}
