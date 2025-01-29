using System.Diagnostics;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        public string Welcome(string name, int numtime = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, Number of times is :{numtime}");
        }
    }
}
