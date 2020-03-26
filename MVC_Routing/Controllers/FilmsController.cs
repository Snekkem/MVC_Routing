using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Routing.Controllers
{
    public class FilmsController : Controller
    {
        // GET: Films
        public ActionResult Index()
        {
            return View();
        }

        public FilePathResult Download(int id)
        {
            return new FilePathResult("", "");
        }

        [Route("films/{name}/info")]
        public ViewResult Info(string name)
        {
            return View("");
        }

        public ViewResult Reviews(string name)
        {
            return View("");
        }

        public FilePathResult Poster (string name, int width = 600, int height = 800)
        {
            return new FilePathResult("", "");
        }
    }
}