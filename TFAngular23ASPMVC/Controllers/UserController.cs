using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TFAngular23ASPMVC.Models;

namespace TFAngular23ASPMVC.Controllers
{
    public class UserController : Controller
    {

        
        List<User> users = new List<User>()
        {
            new User(1, "Bobette", "Bobette@bd.be", new List<string>{"Pulp Fiction", "Les 8 Salopards"}),
            new User(2, "Bob", "Bob@bd.be"),
            new User(3, "Boule", "Boule@bd.be"),
            new User(4, "Bill", "Bill@bd.be"),
        };

        public IActionResult Index() 
        {
            return View(users); 
        }

        public IActionResult Read(int id)
        {

            try
            {
                User selectedUser = users.First(u => u.ID == id);
                return View(selectedUser);
            }
            catch (Exception)
            {
                return RedirectToAction("Error");
            }

            
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
