using Microsoft.AspNetCore.Mvc;

namespace MyFirstMVC.Controllers
{
    public class RaceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
