using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Mappings
{
    public static class PizzaMappers
    {
        public static PizzaVM FromPizzaToPizzaVM(Pizza pizza)
        {
            return new PizzaVM()
            {
                Name = pizza.Name,
                Price = pizza.Price,
                Size = pizza.Size,
                Ingredients = IngredientMappers.FromIngredientsToIngredientVMs(pizza.Ingredients)
            };
        }

        public static List<PizzaVM> FromPizzasToPizzaVMs(List<Pizza> pizzas)
        {
            return pizzas.Select(x => FromPizzaToPizzaVM(x)).ToList();
        }

        public static Pizza FromPizzaVMToPizza(PizzaVM pizzaVM)
        {
            return new Pizza()
            {
                Name = pizzaVM.Name,
                Price = pizzaVM.Price,
                Size = pizzaVM.Size,
                Ingredients = IngredientMappers.FromIngredientVMsToIngredients(pizzaVM.Ingredients)
            };
        }

        public static List<Pizza> FromPizzaVMsToPizzas(List<PizzaVM> pizzaVMs)
        {
            return pizzaVMs.Select(x => FromPizzaVMToPizza(x)).ToList();
        }
    }
}
