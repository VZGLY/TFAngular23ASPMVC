using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TFAngular23ASPMVC.Models;

namespace TFAngular23ASPMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.rantanplan = "PommeDePin";
            return View();
        }

        
        public IActionResult Privacy()
        {
            Console.WriteLine("Entré dans privacy");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            Console.WriteLine("Entré dans l'erreur");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}