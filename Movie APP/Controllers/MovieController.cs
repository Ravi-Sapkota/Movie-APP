using Microsoft.AspNetCore.Mvc;

namespace Movie_APP.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
