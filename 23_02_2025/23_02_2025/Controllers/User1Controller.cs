using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using _23_02_2025.Models;

namespace _23_02_2025.Controllers
{
    public class User1Controller : Controller
    {
        private readonly MyDbContext _context;

        public User1Controller(MyDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }



        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }



            return View(user);
        }

    }
}


    

   