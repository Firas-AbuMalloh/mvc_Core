using _23_02_2025.Models;
using Microsoft.AspNetCore.Mvc;

namespace _23_02_2025.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly MyDbContext _dbContext;

        public DepartmentController(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {

            var Dps = _dbContext.Departments.ToList();
            return View(Dps);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Department Dps)
        {
            _dbContext.Departments.Add(Dps);
            _dbContext.SaveChanges();
            return RedirectToAction("Create");
        }

        public IActionResult Details(int id)
        {
            var department = _dbContext.Departments.Find(id);

            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }



        public IActionResult Edit(int id)
        {
            var department = _dbContext.Departments.Find(id);
            return View(department);
        }

        [HttpPost]
        public IActionResult Edit(Department department)
        {
            

                _dbContext.Departments.Update(department);
                _dbContext.SaveChanges();

                return View("Index");
            
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            
            var D = _dbContext.Departments.Find(id);
                        

            _dbContext.Departments.Remove(D);
            _dbContext.SaveChanges();

            return RedirectToAction("Index","Department");
        }


    }
}
