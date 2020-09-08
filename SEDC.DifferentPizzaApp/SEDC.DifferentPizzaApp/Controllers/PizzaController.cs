using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.DifferentPizzaApp.Models.ViewModels;

namespace SEDC.DifferentPizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Menu()
        {
            var ourPizzas = new List<PizzaVM>();
            ourPizzas = StaticDb.OurPizzas.Select(pizza => new PizzaVM()
            {
                Name = pizza.Name,
                Size = pizza.Size,
                Ingredients = pizza.Ingredients.Select(i => new IngredientVM() { Name = i.Name, Type = i.Type, Weight = i.Weight }).ToList(),
                Price = pizza.Price
            }).ToList();
            return View(ourPizzas);
        }

        public IActionResult MakePizza()
        {
            return View();
        }

       
    }
}