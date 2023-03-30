using Microsoft.AspNetCore.Mvc;

namespace TFAngular23ASPMVC.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index() 
        {
            return View(); 
        }

        public IActionResult Read()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
