using Microsoft.AspNetCore.Mvc;

namespace spering1.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
