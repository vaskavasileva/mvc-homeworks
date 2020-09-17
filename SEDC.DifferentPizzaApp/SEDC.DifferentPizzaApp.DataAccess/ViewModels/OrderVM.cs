using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.DataAccess.ViewModels
{
    public class OrderVM
    {
        public int OrderNumber { get; set; }
        public List<PizzaVM> Pizzas { get; set; }
        public UserVM OrderUser { get; set; }
        public bool IsDelivered { get; set; }
    }
}
