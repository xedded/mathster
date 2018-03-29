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
    public class GameController : Controller
    {

        //MultiplikationIndexVM multiplikationIndexVM = new MultiplikationIndexVM();
        private readonly QuestionService questionService;
        public GameController(QuestionService questionService)
        {
            this.questionService = questionService;
        }

        [Route("{gametype}/{level}")]
        public IActionResult Index(Level level, GameType gameType)
        {
            var model = questionService.GetMultiplicationIndexVM(level, gameType);

            return View(model);
        }
        [HttpPost]
        [Route("{gametype}/nextquestion/{level}/{clickedAnswer}")]
        public GameNewQuestionVM NewQuestion(Level level, int? clickedAnswer, GameType gameType)
        {
            return questionService.GetNewQuestion(level, clickedAnswer, HttpContext, gameType);
            
           


        }
    }
}
