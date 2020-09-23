using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.DifferentPizzaApp.BusinessLayer.Helpers;
using SEDC.DifferentPizzaApp.BusinessLayer.Mappings;
using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess;
using SEDC.DifferentPizzaApp.DataAccess.Core.Enums;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;

namespace SEDC.DifferentPizzaApp.Controllers
{
    public class PizzaController : Controller
    {
        private IPizzaService _pizzaService;
        public PizzaController(IPizzaService pizzaService)
        {
            _pizzaService = pizzaService;
        }
        public IActionResult Menu()
        {
            List<PizzaVM> ourPizzas = _pizzaService.GetAllPizzas();
        
            return View(ourPizzas);
        }

        public IActionResult MakePizza()
        {
            var pizzaSizes = new List<PizzaSize>();
            return View(pizzaSizes);
        }

        [HttpPost]
        public IActionResult MakePizza(PizzaSize size)
        {
            CurrentLogs.CurrentPizza.Size = size;
            return RedirectToAction("SelectDough", "Ingredient");
        }

        

       
    }
}