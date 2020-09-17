
using SEDC.DifferentPizzaApp.DataAccess.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.DataAccess.ViewModels
{
    public class PizzaVM
    {
        public string Name { get; set; }
        public List<IngredientVM> Ingredients { get; set; }
        public PizzaSize Size { get; set; }
        public int Price { get; set; }
    }
}
