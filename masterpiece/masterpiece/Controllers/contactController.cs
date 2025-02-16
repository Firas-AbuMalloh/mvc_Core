using Microsoft.AspNetCore.Mvc;

namespace masterpiece.Controllers
{
    public class contactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
