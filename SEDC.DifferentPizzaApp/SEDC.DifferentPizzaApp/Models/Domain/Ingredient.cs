using SEDC.DifferentPizzaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.Models.Domain
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IngredientType Type { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
}
