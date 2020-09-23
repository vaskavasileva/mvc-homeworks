using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SEDC.DifferentPizzaApp.BusinessLayer.Helpers;
using SEDC.DifferentPizzaApp.BusinessLayer.Mappings;
using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;

namespace SEDC.DifferentPizzaApp.Controllers
{
    public class OrderController : Controller
    {
        private IOrderService _orderService;
        private IPizzaService _pizzaService;
        private IUserService _userService;
        public OrderController(IOrderService orderService, IPizzaService pizzaService, IUserService userService)
        {
            _orderService = orderService;
            _pizzaService = pizzaService;
            _userService = userService;
        }

        public IActionResult MyOrder()
        {
            var myPizza = _pizzaService.GetPizzaById(CurrentLogs.CurrentPizza.Id);
            var user = _userService.GetUserById(CurrentLogs.LoggedUser.Id);
            var myOrder = new OrderVM() { IsDelivered = false, OrderUser = user, Pizzas = new List<PizzaVM>() { myPizza } };
            var order = _orderService.CreateOrder(myOrder);
            CurrentLogs.CurrentOrder = OrderMappers.FromOrderVMToOrder(myOrder);
            return View(myOrder);
        }
    }
}