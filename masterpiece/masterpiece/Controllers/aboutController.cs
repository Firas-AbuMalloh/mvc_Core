using Microsoft.AspNetCore.Mvc;

namespace masterpiece.Controllers
{
    public class aboutController : Controller
    {
        public IActionResult about()
        {
            return View();
        }
    }
}
