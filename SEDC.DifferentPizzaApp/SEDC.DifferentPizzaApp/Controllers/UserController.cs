using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.DifferentPizzaApp.BusinessLayer.Helpers;
using SEDC.DifferentPizzaApp.BusinessLayer.Mappings;
using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;

namespace SEDC.DifferentPizzaApp.Controllers
{
    public class UserController : Controller
    {
        private IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult SignUp()
        {
            var user = new UserVM();
            return View(user);
        }

        [HttpPost]
        public IActionResult SignUp(UserVM user)
        {
            _userService.CreateUser(user);
            CurrentLogs.LoggedUser = UserMappers.FromUserVMToUser(user);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult LogIn()
        {
            var user = new UserVM();
            return View(user);
        }

        //[HttpPost]
        public IActionResult LogIn(UserVM user)
        {
            var loggedUser = _userService.LogInUser(user.Username, user.Password);
            if (loggedUser == null)
            {
                return RedirectToAction("LogIn");
            }
            CurrentLogs.LoggedUser = UserMappers.FromUserVMToUser(loggedUser);
            return RedirectToAction("Index", "Home");
        }

        
        public IActionResult LogOut()
        {
            CurrentLogs.LoggedUser = null;
            CurrentLogs.LoggedUser = new User();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult ViewUser()
        {
            var user = UserMappers.FromUserToUserVM(CurrentLogs.LoggedUser);
        

            return View(user);
        }

        
    }
}