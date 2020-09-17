using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Mappings
{
    public static class IngredientMappers
    {
        public static IngredientVM FromIngredientToIngredientVM(Ingredient ing)
        {
            return new IngredientVM()
            {
                Name = ing.Name,
                Price = ing.Price,
                Type = ing.Type,
                Weight = ing.Weight
            };
        }

        public static List<IngredientVM> FromIngredientsToIngredientVMs(List<Ingredient> ings)
        {
            return ings.Select(x => FromIngredientToIngredientVM(x)).ToList();
        }

        public static Ingredient FromIngredientVMToIngredient(IngredientVM ingVM)
        {
            return new Ingredient()
            {
                Name = ingVM.Name,
                Price = ingVM.Price,
                Type = ingVM.Type,
                Weight = ingVM.Weight
            };
        }

        public static List<Ingredient> FromIngredientVMsToIngredients(List<IngredientVM> ingVMs)
        {
            return ingVMs.Select(x => FromIngredientVMToIngredient(x)).ToList();
        }
    }
}
