using Microsoft.AspNetCore.Mvc;

namespace GameShop.Areas.Home.Controllers
{
    [Area("Anon")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
