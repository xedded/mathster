using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathster.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mathster.Controllers
{
    public class InfoController : Controller
    {
        private readonly InfoRepository infoRepository;
        public InfoController(InfoRepository infoRepository)
        {
            this.infoRepository = infoRepository;
        }

        [Route("{gametype}/info")]
        public IActionResult Index(GameType gameType)
        {
            var model = infoRepository.GetInfo(gameType);

            return View(model);
        }
    }
}
