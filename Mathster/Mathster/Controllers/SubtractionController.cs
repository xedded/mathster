using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathster.Models;
using Mathster.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mathster.Controllers
{
    public class SubtractionController : Controller
    {
        private readonly Repository repository;
        public SubtractionController(Repository repository)
        {
            this.repository = repository;
        }

        [Route("/Subtraktion/{id}")]
         public IActionResult Index(int id)
        {
            var model = repository.SubtractionRandomizer(id);

            return View(model);
        }
    }
}
