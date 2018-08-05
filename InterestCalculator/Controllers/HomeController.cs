using Microsoft.AspNetCore.Mvc;

namespace InterestCalculator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}