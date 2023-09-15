using Microsoft.AspNetCore.Mvc;

namespace Peoplelist.Controllers 
{
    public class PersonController : Controller{
        public IActionResult Index(){
            // ViewBag and ViewData can send data only from ControllerToView
            ViewBag.greetings = "Hello World";
            ViewData["greeting2"] = "I am using ViewData";

            // TempData can send data from 1 controller method to another controller method
            TempData["greeting3"] = "This is TempData";
            return View();
        }
    }
}