
using SEDC.DifferentPizzaApp.DataAccess.Core.Enums;
using SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SEDC.DifferentPizzaApp.DataAccess
{
    public class StaticDb : IStaticDb
    {

        public User LoggedUser { get; set; } = new User();
        public Pizza CurrentPizza { get; set; } = new Pizza();

        public List<Ingredient> GetIngredients()
        {
            return new List<Ingredient>()
            {

                new Ingredient()
                {
                    Id = 1,
                    Name = "Dough",
                    Price = 10,
                    Type = IngredientType.Dough,
                    Weight = 10
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Cheese",
                    Price = 20,
                    Type = IngredientType.Cheese,
                    Weight = 20
                },
                new Ingredient()
                {
                    Id = 3,
                    Name = "Meat",
                    Price = 30,
                    Type = IngredientType.Meat,
                    Weight = 30
                },
                new Ingredient()
                {
                    Id = 4,
                    Name = "Other",
                    Price = 40,
                    Type = IngredientType.Other,
                    Weight = 40
                }
            };

        }




        public List<Order> GetOrders()
        {
            return new List<Order>()
            {
                new Order()
                {
                    Pizzas = new List<Pizza>(),
                    User = new User(),
                    IsDelivered = false
                },

                new Order()
                {
                    Pizzas = new List<Pizza>(),
                    User = new User(),
                    IsDelivered = true
                }
            };


        }


        public List<Pizza> GetPizzas()
        {
            return new List<Pizza>()
            {
                new Pizza()
                {
                Id = 1,
                Price = 10,
                Name = "PizzaNameSmall",
                Size = PizzaSize.Small,
                Ingredients = new List<Ingredient>(){new Ingredient()
                {
                    Id = 1,
                    Name = "Dough",
                    Price = 10,
                    Type = IngredientType.Dough,
                    Weight = 10
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Cheese",
                    Price = 20,
                    Type = IngredientType.Cheese,
                    Weight = 20
                }}
                },
                new Pizza()
                {
                Id = 2,
                Price = 20,
                Name = "PizzaNameMedium",
                Size = PizzaSize.Medium,
                Ingredients = new List<Ingredient>(){new Ingredient()
                {
                    Id = 1,
                    Name = "Dough",
                    Price = 10,
                    Type = IngredientType.Dough,
                    Weight = 10
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Cheese",
                    Price = 20,
                    Type = IngredientType.Cheese,
                    Weight = 20
                }
                }
                },
                new Pizza()
                {
                Id = 3,
                Price = 30,
                Name = "PizzaNameFamily",
                Size = PizzaSize.Family,
                Ingredients = new List<Ingredient>(){new Ingredient()
                {
                    Id = 1,
                    Name = "Dough",
                    Price = 10,
                    Type = IngredientType.Dough,
                    Weight = 10
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Cheese",
                    Price = 20,
                    Type = IngredientType.Cheese,
                    Weight = 20
                }}
                },
                new Pizza()
                {
                Id = 4,
                Price = 40,
                Name = "PizzaNameLarge",
                Size = PizzaSize.Large,
                Ingredients = new List<Ingredient>(){new Ingredient()
                {
                    Id = 1,
                    Name = "Dough",
                    Price = 10,
                    Type = IngredientType.Dough,
                    Weight = 10
                },
                new Ingredient()
                {
                    Id = 2,
                    Name = "Cheese",
                    Price = 20,
                    Type = IngredientType.Cheese,
                    Weight = 20
                }}
                }
            };
        }



        public List<User> GetUsers()
        {
            return new List<User>()
            {
                new User()
                {
                    FirstName = "Bob",
                    LastName = "Bobsky",
                    Address = "Street 1",
                    Phone = 445365,
                    Orders = new List<Order>(){new Order()
                {
                    Pizzas = new List<Pizza>(),
                    User = new User(),
                    IsDelivered = false
                }
                },
                    Username = "Bob123",
                    Password ="123"
                },

                new User()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Address = "Street2",
                    Phone = 6687645,
                    Username = "Jane456",
                    Password = "456",
                    Orders = new List<Order>(){new Order()
                {
                    Pizzas = new List<Pizza>() ,
                    User = new User(),
                    IsDelivered = true
                }}
                }

            };
        }

    }
}

