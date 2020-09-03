using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.Models.ViewModels
{
    public class OrderVM
    {
       [ScaffoldColumn(false)]
        public int OrderNumber { get; set; }
        public UserVM User { get; set; }
        public List<PizzaVM> Pizzas { get; set; } = new List<PizzaVM>();
    }
}
