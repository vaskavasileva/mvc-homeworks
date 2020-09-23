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
    public class IngredientController : Controller
    {
        private IIngredientService _ingredientService;
        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SelectDough()
        {
            var myList = _ingredientService.GetIngredientsByType(IngredientType.Dough);
            return View(myList);
        }

        [HttpPost]
        public IActionResult SelectDough(IngredientVM ingredient)
        {
            CurrentLogs.CurrentPizza.Ingredients.Add(IngredientMappers.FromIngredientVMToIngredient(ingredient));
            return RedirectToAction("SelectIngredients");
        }

        public IActionResult SelectIngredients()
        {
            var cheeseIngredients = _ingredientService.GetIngredientsByType(IngredientType.Cheese);
            return View(cheeseIngredients);
        }

        [HttpPost]
        public IActionResult SelectIngredients(List<IngredientVM> ingredients)
        {
            CurrentLogs.CurrentPizza.Ingredients.AddRange(IngredientMappers.FromIngredientVMsToIngredients(ingredients));
            return RedirectToAction("SelectIngredients2");
        }

        public IActionResult SelectIngredients2()
        {
            var meatIngredients = _ingredientService.GetIngredientsByType(IngredientType.Meat);
            return View(meatIngredients);
        }

        [HttpPost]
        public IActionResult SelectIngredients2(List<IngredientVM> ingredients)
        {
            CurrentLogs.CurrentPizza.Ingredients.AddRange(IngredientMappers.FromIngredientVMsToIngredients(ingredients));
            return RedirectToAction("MyOrder", "Order");
        }
    }
}