﻿using SEDC.DifferentPizzaApp.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.Models.Domain
{
    public class Pizza
    {
        public Pizza()
        {
            Price = this.CalculatePrice(this.Ingredients);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public PizzaSize Size { get; set; }
        public int Price { get; set; }

        private int CalculatePrice(List<Ingredient> ingredients)
        {
            var result = 0;
            foreach (var item in ingredients)
            {
                result += item.Price;

            }
            return result;
        }
    }
}
