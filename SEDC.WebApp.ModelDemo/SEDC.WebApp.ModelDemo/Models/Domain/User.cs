using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo.Models.Domain
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Phone { get; set; }
        public string Address { get; set; }
        public Order CurrentOrder { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
