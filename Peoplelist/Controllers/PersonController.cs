using Microsoft.AspNetCore.Mvc;

namespace Peoplelist.Controllers 
{
    public class PersonController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}