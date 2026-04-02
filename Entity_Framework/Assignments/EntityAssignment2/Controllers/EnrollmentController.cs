using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EntityAssignment2.Data;
using EntityAssignment2.Models;

namespace EntityAssignment2.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly ApplicationDbContext context;

        public EnrollmentController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var data = context.Enrollments
                .Include(e => e.Student)
                .Include(e => e.Course)
                .ToList();

            return View(data);
        }

        public IActionResult Create()
        {
            ViewBag.Students = new SelectList(context.Students, "Id", "Name");
            ViewBag.Courses = new SelectList(context.Courses, "Id", "Title");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Enrollment e)
        {
            if (ModelState.IsValid)
            {
                context.Enrollments.Add(e);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(e);
        }

        public IActionResult Delete(int id)
        {
            var e = context.Enrollments
                .Include(x => x.Student)
                .Include(x => x.Course)
                .FirstOrDefault(x => x.Id == id);

            return View(e);
        }

        [HttpPost]
        public IActionResult Delete(Enrollment e)
        {
            context.Enrollments.Remove(e);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
{
    var e = context.Enrollments.Find(id);
    if (e == null)
    {
        return NotFound();
    }

    ViewBag.Students = new SelectList(context.Students, "Id", "Name", e.StudentId);
    ViewBag.Courses = new SelectList(context.Courses, "Id", "Title", e.CourseId);

    return View(e);
}

[HttpPost]
public IActionResult Edit(Enrollment e)
{
    if (ModelState.IsValid)
    {
        context.Enrollments.Update(e);
        context.SaveChanges();
        return RedirectToAction("Index");
    }

    ViewBag.Students = new SelectList(context.Students, "Id", "Name", e.StudentId);
    ViewBag.Courses = new SelectList(context.Courses, "Id", "Title", e.CourseId);

    return View(e);
}
    }
}