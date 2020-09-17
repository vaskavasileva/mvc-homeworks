using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;

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
    }
}