using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Models;
using SEDC.WebApp.ModelDemo.Models.Domain;
using SEDC.WebApp.ModelDemo.Models.ViewModels;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    
    public class HomeController : Controller
    {
        public static UserVM LoggedUser;
        public IActionResult Index()
        {
            ViewData["Heading"] = "Pizzas menu";
            ViewBag.Title = "Welcome to our pizza app!";
            var allPizzas = StaticDb.Menu;
            return View(allPizzas);
        }

        public IActionResult PizzaDetails(int id)
        {
            var pizza = StaticDb.Menu.SingleOrDefault(p => p.Id == id);
            PizzaVM pizzaModel = new PizzaVM()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Size = pizza.Size,
                Price = pizza.Price,
                Ingredients = pizza.Ingredients
            };
            return View(pizzaModel);
        }
        [HttpGet]
        public IActionResult Order(int id)
        {
            var pizza = StaticDb.Menu.SingleOrDefault(p => p.Id == id);
            PizzaVM pizzaModel = new PizzaVM()
            {
                Id = pizza.Id,
                Name = pizza.Name,
                Size = pizza.Size,
                Price = pizza.Price,
                Ingredients = pizza.Ingredients
            };
            if (LoggedUser == null)
            {
                return RedirectToAction("LogginUser");
            }
            LoggedUser.CurrentOrder.Pizzas.Add(pizzaModel);
            return RedirectToAction("Index");
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
            LoggedUser = loggedVM;
            return View("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

    }
}
