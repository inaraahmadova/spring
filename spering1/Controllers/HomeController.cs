using Microsoft.AspNetCore.Mvc;
namespace spering1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
