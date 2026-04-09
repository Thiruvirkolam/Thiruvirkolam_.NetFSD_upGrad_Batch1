using Microsoft.AspNetCore.Mvc;
using Assignment3.Models;
using Assignment3.ViewModels;
using Microsoft.AspNetCore.Http;

namespace Assignment3.Controllers
{
    public class UserController : Controller
    {
        private static List<User> users = new List<User>();

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                users.Add(user);
                return RedirectToAction("Login");
            }
            return View(user);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (user != null)
            {
                HttpContext.Session.SetString("UserEmail", user.Email);
                return RedirectToAction("Profile");
            }

            ViewBag.Error = "Invalid login";
            return View();
        }

        public IActionResult Profile()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
                return RedirectToAction("Login");

            var user = users.FirstOrDefault(u => u.Email == email);

            if (user == null)
                return RedirectToAction("Login");

            var vm = new UserViewModel
            {
                Name = user.Name,
                Email = user.Email
            };

            return View(vm);
        }

        public IActionResult Edit()
        {
            var email = HttpContext.Session.GetString("UserEmail");

            if (email == null)
                return RedirectToAction("Login");

            var user = users.FirstOrDefault(u => u.Email == email);

            if (user == null)
                return RedirectToAction("Login");

            return View(user);
        }

        [HttpPost]
public IActionResult Edit(User updatedUser)
{
    var email = HttpContext.Session.GetString("UserEmail");

    if (email == null)
        return RedirectToAction("Login");

    var user = users.FirstOrDefault(u => u.Email == email);

    if (user == null)
        return RedirectToAction("Login");

    // 🔥 REMOVE validation issue
    ModelState.Remove("Password");
    ModelState.Remove("ConfirmPassword");

    if (ModelState.IsValid)
    {
        user.Name = updatedUser.Name;
        user.Email = updatedUser.Email;

        HttpContext.Session.SetString("UserEmail", user.Email);

        return RedirectToAction("Profile");
    }

    return View(updatedUser);
}

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}