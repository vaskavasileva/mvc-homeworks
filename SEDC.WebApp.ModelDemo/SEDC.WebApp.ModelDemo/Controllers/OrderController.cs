using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.WebApp.ModelDemo.Models.Domain;
using SEDC.WebApp.ModelDemo.Models.ViewModels;

namespace SEDC.WebApp.ModelDemo.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public IActionResult ViewOrder(int id)
        {
            var currentOrder = StaticDb.Orders.SingleOrDefault(o => o.Id == id);
            var currentUser = StaticDb.Users.SingleOrDefault(x => x.Id == currentOrder.UserId);
            var currentPizzas = new List<PizzaVM>();
            foreach (var item in currentOrder.PizzaIds)
            {
                var pizza = StaticDb.Menu.SingleOrDefault(p => p.Id == item);
                var pizzaVM = new PizzaVM()
                {
                    Name = pizza.Name,
                    Ingredients = pizza.Ingredients,
                    Size = pizza.Size,
                    Price = pizza.Price
                };
                currentPizzas.Add(pizzaVM);
            }
            var userVM = new UserVM()
            {
                Name = $"{currentUser.FirstName} + {currentUser.LastName}",
                Phone = currentUser.Phone,
                Address = currentUser.Address,
                Username = currentUser.Username,
                Password = currentUser.Password
            };

            var orderVM = new OrderVM()
            {
                OrderNumber = currentOrder.Id,
                User = userVM,
                Pizzas = currentPizzas
            };

            return View();
        }
    }
}