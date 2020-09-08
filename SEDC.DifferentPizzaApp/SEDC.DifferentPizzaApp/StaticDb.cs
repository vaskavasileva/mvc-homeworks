using SEDC.DifferentPizzaApp.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp
{
    public static class StaticDb
    {
        public static List<Ingredient> AllIngredients =new List<Ingredient>();
        public static List<Pizza> OurPizzas = new List<Pizza>();
        public static List<User> Users = new List<User>();
        public static User LoggedUser { get; set; } = new User();
        public static Pizza CurrentPizza { get; set; } = new Pizza();
    }
}
