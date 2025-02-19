using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Task3.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            ViewBag.NameProfile = HttpContext.Session.GetString("Name");
            ViewBag.Email = HttpContext.Session.GetString("Email");

            ViewBag.Password = HttpContext.Session.GetString("Password");

            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Signup()
        {
            return View();
        }
        public IActionResult Signout()
        {
            return RedirectToAction("Login");
        }

        [HttpPost]
        public IActionResult SaveUser(IFormCollection form)
        {

            HttpContext.Session.SetString("Name", form["Name"].ToString());
            HttpContext.Session.SetString("Email", form["Email"].ToString());
            HttpContext.Session.SetString("Password", form["Password"].ToString());
            HttpContext.Session.SetString("Re_Password", form["Re_Password"].ToString());


            return RedirectToAction("Login","User");
        }

        [HttpPost]
        public IActionResult LoginCheckUser()
        {
            if (HttpContext.Session.GetString("Email") == Request.Form["EmailLogin"]
                && HttpContext.Session.GetString("Password") == Request.Form["PasswordLogin"])

                return RedirectToAction("Index", "Home");

            else
                ViewBag.MSGERROR = "Your Password or Email is incorrect..";

            return RedirectToAction("Login","User");

        }

    }

}
