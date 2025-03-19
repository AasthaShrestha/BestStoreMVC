using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
