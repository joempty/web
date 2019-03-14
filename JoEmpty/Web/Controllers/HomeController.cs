using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class HomeController : AuthController
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
