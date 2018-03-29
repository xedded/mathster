using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathster.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mathster.Controllers
{
    public class DivisionController : Controller
    {
        private readonly QuestionService repository;
        public DivisionController(QuestionService repository)
        {
            this.repository = repository;
        }

        //[Route("/division/{id}")]
        //public IActionResult Index(int id)
        //{
        //    var model = repository.DivisionRandomizer(id);

        //    return View(model);
        //}
    }
}
