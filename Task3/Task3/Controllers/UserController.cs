using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace Task3.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            ViewBag.NameProfile = HttpContext.Session.GetString("Name");
            ViewBag.EmailProfile = HttpContext.Session.GetString("Email");
            ViewBag.PasswordProfile = HttpContext.Session.GetString("Password");




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
            foreach (var item in HttpContext.Session.Keys)
            HttpContext.Session.Remove(item);

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult SaveUser(string Name, string Email, string Password, string Re_Password)
        {

            HttpContext.Session.SetString("Name", Name);
            HttpContext.Session.SetString("Email", Email);
            HttpContext.Session.SetString("Password", Password);
            HttpContext.Session.SetString("Re_Password", Re_Password);


            return RedirectToAction("Login", "User");
        }

        [HttpPost]
        public IActionResult LoginCheckUser()
        {
            string isChecked = Request.Form["RememberMe"].ToString();

            if (isChecked == "true")
            {
                CookieOptions options = new CookieOptions();
                options.Expires = DateTime.Now.AddDays(7);
                HttpContext.Response.Cookies.Append("Email", Request.Form["EmailLogin"],options);

                HttpContext.Response.Cookies.Append("Password", Request.Form["PasswordLogin"], options);

            }

            if (HttpContext.Session.GetString("Email") == Request.Form["EmailLogin"] &&
                HttpContext.Session.GetString("Email") != null &&
                HttpContext.Session.GetString("Password") == Request.Form["PasswordLogin"] &&
                HttpContext.Session.GetString("Password") != null)
            {
                HttpContext.Session.SetString("signData", "Signed");

                return RedirectToAction("Index", "Home");
            }
            else if (Request.Form["EmailLogin"] == "Admin@gmail.com" && Request.Form["PasswordLogin"] == "123321")
            {
                return RedirectToAction("Index", "Admin");
            }
            else
                ViewBag.MSGERROR = "Your Password or Email is incorrect..";

            return RedirectToAction("Login", "User");

        }

    }

}
