using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mathster.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Mathster.Controllers
{
    public class VideoController : Controller
    {
        private readonly VideoRepository videoRepository;
        public VideoController( VideoRepository videoRepository)
        {
            this.videoRepository = videoRepository;
        }

        [Route("{gametype}/video")]
        public IActionResult Index(GameType gameType)
        {
            var model = videoRepository.GetVideo(gameType);

            return View(model);
        }
    }
}
