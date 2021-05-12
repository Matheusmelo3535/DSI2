using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace ShowdeBola.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //GET: /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes=1)
        {
            ViewData["Message"] = "Olá " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
        }
    }
}

