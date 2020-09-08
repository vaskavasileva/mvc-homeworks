using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.Models.ViewModels
{
    public class OrderVM
    {
        public int OrderNumber { get; set; }
        public List<PizzaVM> Pizzas { get; set; }
        public UserVM User { get; set; }
        public bool IsDelivered { get; set; }
    }
}
