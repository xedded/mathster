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
        private readonly Repository repository;
        public AdditionController(Repository repository)
        {
            this.repository = repository;
        }

        [Route("Addition")]
        public IActionResult Index()
        {
            var model = repository.AdditionRandomizer();

            return View(model);
        }
    }
}
