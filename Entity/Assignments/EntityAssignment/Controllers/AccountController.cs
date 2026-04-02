using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EntityAssignment.Data;
using EntityAssignment.Models;

namespace EntityAssignment.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext context;

        public AccountController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            return View(context.Accounts.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Account acc)
        {
            context.Accounts.Add(acc);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(context.Accounts.Find(id));
        }

        [HttpPost]
        public IActionResult Edit(Account acc)
        {
            context.Accounts.Update(acc);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return View(context.Accounts.Find(id));
        }

        [HttpPost]
        public IActionResult Delete(Account acc)
        {
            context.Accounts.Remove(acc);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            return View(context.Accounts.Find(id));
        }
    }
}
