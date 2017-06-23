using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationTest.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "About Me:)";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Here you can see my contacts.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
