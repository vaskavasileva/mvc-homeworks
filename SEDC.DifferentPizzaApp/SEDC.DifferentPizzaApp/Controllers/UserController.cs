using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;

namespace SEDC.DifferentPizzaApp.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        //public IActionResult SignUp()
        //{
        //    var user = new User();
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult SignUp(User user)
        //{
        //    StaticDb.Users.Add(user);
        //    StaticDb.LoggedUser = user;
        //    return RedirectToAction("Index", "Home");
        //}

        //public IActionResult LogIn()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult LogIn(User user)
        //{
        //    var loggedUser = StaticDb.Users.SingleOrDefault(x => x.Username == user.Username && x.Password == user.Password);
        //    if (loggedUser == null)
        //    {
        //        return RedirectToAction("LogIn");
        //    }
        //    StaticDb.LoggedUser = loggedUser;
        //    return RedirectToAction("Index", "Home");
        //}

        
        //public IActionResult LogOut()
        //{
        //    StaticDb.LoggedUser = null;
        //    StaticDb.LoggedUser = new User();
        //    return RedirectToAction("Index", "Home");
        //}

        //public IActionResult ViewUser()
        //{
        //    var user = StaticDb.LoggedUser;
        //    var userVM = new UserVM()
        //    {
        //        Username = user.Username,
        //        Password = user.Password,
        //        Name = user.FirstName + " " + user.LastName,
        //        Address = user.Address,
        //        Phone = user.Phone
        //    };

        //    return View(userVM);
        //}

        
    }
}