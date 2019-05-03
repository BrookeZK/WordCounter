using Microsoft.AspNetCore.Mvc;
using GameCenter.Controllers;
using GameCenter.Models;

namespace GameCenter.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
