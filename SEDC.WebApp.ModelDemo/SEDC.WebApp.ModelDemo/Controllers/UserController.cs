using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Models.Domain;
using SEDC.WebApp.ModelDemo.Models.ViewModels;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult LogginUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LogginUser(User user)
        {
            var loggedUser = StaticDb.Users.SingleOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            UserVM loggedVM = new UserVM()
            {
                Name = $"{loggedUser.FirstName} + {loggedUser.LastName}",
                Phone = loggedUser.Phone,
                Address = loggedUser.Address,
                Username = loggedUser.Username,
                Password = loggedUser.Password
            };
            StaticDb.LoggedUser = loggedVM;
            return View("Index");
        }

        [HttpGet]
        public IActionResult RegisterUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegisterUser(User user)
        {
            var newUser = new User();
            newUser.FirstName = user.FirstName;
            newUser.LastName = user.LastName;
            newUser.Phone = user.Phone;
            newUser.Address = user.Address;
            newUser.Username = user.Username;
            newUser.Password = user.Password;
            return RedirectToAction("Index", "Home");
        }
    }
}