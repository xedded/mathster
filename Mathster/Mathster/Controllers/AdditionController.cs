using Mathster.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mathster.Controllers
{
    public class AdditionController:Controller
    {
        private readonly QuestionService repository;
        public AdditionController(QuestionService repository)
        {
            this.repository = repository;
        }

        //[Route("/Addition/{id}")]
        //public IActionResult Index(int id)
        //{
        //    var model = repository.AdditionRandomizer(id);

        //    return View(model);
        //}
    }
}
