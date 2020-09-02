using SEDC.WebApp.ModelDemo.Models.Domain;
using SEDC.WebApp.ModelDemo.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.WebApp.ModelDemo
{
    public static class StaticDb 
    {
        public static List<Order> Orders;
        public static List<Pizza> Menu;
        public static List<User> Users;
        static StaticDb()
        {
            Users = new List<User>()
            {
                new User()
                {
                    Id = 1,
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Bob Street",
                    Phone = 080012312345
                }
            };
            Menu = new List<Pizza>()
            {
                new Pizza()
                {
                    Id = 1,
                    Name = "Kapri",
                    Price = 7,
                    Size = PizzaSize.Small,
                    Ingredients = { "Cheese","Mushrooms","Ham", }
                },
                new Pizza()
                {
                    Id = 2,
                    Name = "Kapri",
                    Price = 8,
                    Size = PizzaSize.Medium,
                    Ingredients = { "Cheese","Mushrooms","Ham", }
                },
                new Pizza()
                {
                    Id = 3,
                    Name = "Kapri",
                    Price = 9,
                    Size = PizzaSize.Family,
                    Ingredients = { "Cheese","Mushrooms","Ham", }
                }
            };
            Orders = new List<Order>()
            {
                new Order()
                {
                    Id = 1,
                    UserId = 1,
                    PizzaIds = { 1,2},
                    Delivered = false
                }
            };
        }
    }
}
