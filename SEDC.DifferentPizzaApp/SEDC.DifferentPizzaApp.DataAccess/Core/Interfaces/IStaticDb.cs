using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces
{
    public interface IStaticDb
    {
        List<Ingredient> GetIngredients();
        List<Pizza> GetPizzas();
        List<User> GetUsers();
        List<Order> GetOrders();
    }
}
