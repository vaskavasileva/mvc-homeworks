using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.DataAccess.Core.Models
{
    public class Order : BaseEntity
    {
        public List<Pizza> Pizzas { get; set; }
        public User User { get; set; }
        public bool IsDelivered { get; set; }
    }
}
