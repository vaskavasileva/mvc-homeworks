using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.Models.ViewModels
{
    public class UserVM
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Display(Name = "Ordered by")]
        public string Name { get; set; }
        [Display(Name = "Phone number")]
        public long Phone { get; set; }
        public string Address { get; set; }
        public OrderVM CurrentOrder { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
