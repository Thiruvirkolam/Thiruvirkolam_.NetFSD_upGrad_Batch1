using Microsoft.AspNetCore.Mvc;
using EntityAssignment2.Repositories;
using EntityAssignment2.Models;

namespace EntityAssignment2.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository repo;

        public CourseController(ICourseRepository repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(repo.GetAll());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Course c)
        {
            if (ModelState.IsValid)
            {
                repo.Add(c);
                return RedirectToAction("Index");
            }
            return View(c);
        }

        public IActionResult Edit(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Course c)
        {
            if (ModelState.IsValid)
            {
                repo.Update(c);
                return RedirectToAction("Index");
            }
            return View(c);
        }

        public IActionResult Delete(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public IActionResult Delete(Course c)
        {
            repo.Delete(c.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(repo.GetById(id));
        }
    }
}