
using SEDC.DifferentPizzaApp.DataAccess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.DataAccess.Core.Models
{
    public class Ingredient : BaseEntity
    {
        public string Name { get; set; }
        public IngredientType Type { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
}
