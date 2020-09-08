using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.Models.ViewModels
{
    public class UserVM
    {
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Address { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<OrderVM> Orders { get; set; } = new List<OrderVM>();
    }
}
