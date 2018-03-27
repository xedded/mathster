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
        private readonly Repository repository;
        public DivisionController(Repository repository)
        {
            this.repository = repository;
        }

        [Route("/division/{id}")]
        public IActionResult Index(int id)
        {
            var model = repository.DivisionRandomizer(id);

            return View(model);
        }
    }
}
