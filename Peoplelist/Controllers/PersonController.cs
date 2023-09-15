using Microsoft.AspNetCore.Mvc;
using Peoplelist.Models.Domain;

namespace Peoplelist.Controllers 
{
    public class PersonController : Controller
    {
        public IActionResult Index(){
            // ViewBag and ViewData can send data only from ControllerToView
            ViewBag.greetings = "Hello World";
            ViewData["greeting2"] = "I am using ViewData";

            // TempData can send data from 1 controller method to another controller method
            TempData["greeting3"] = "This is TempData";
            return View();
        }

        public IActionResult AddPerson(){
            return View();
        }

        [HttpPost] public IActionResult AddPerson(Person person){
            if(!ModelState.IsValid)
            {
                return View();
            }
            TempData["msg"] = "Added";
            return View()
        }
    }
}