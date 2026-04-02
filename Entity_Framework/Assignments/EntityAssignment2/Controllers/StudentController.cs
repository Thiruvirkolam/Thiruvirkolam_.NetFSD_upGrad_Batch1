using Microsoft.AspNetCore.Mvc;
using EntityAssignment2.Repositories;
using EntityAssignment2.Models;

namespace EntityAssignment2.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository repo;

        public StudentController(IStudentRepository repo)
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
        public IActionResult Create(Student s)
        {
            if (ModelState.IsValid)
            {
                repo.Add(s);
                return RedirectToAction("Index");
            }
            return View(s);
        }

        public IActionResult Edit(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Student s)
        {
            if (ModelState.IsValid)
            {
                repo.Update(s);
                return RedirectToAction("Index");
            }
            return View(s);
        }

        public IActionResult Delete(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public IActionResult Delete(Student s)
        {
            repo.Delete(s.Id);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(repo.GetById(id));
        }
    }
}