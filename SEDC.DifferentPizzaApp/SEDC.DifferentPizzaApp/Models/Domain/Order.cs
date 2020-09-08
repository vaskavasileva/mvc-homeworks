using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.Models.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public List<int> PizzaIds { get; set; }
        public int UserId { get; set; }
        public bool IsDelivered { get; set; }
    }
}
