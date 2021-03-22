using Microsoft.AspNetCore.Mvc;

namespace CustomerRegistration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           return View();
        }
    }
}
