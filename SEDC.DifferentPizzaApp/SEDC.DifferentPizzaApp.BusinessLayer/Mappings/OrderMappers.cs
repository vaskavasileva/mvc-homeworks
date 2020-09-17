using SEDC.DifferentPizzaApp.BusinessLayer.Services.ActualServices;
using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Mappings
{
    public static class OrderMappers
    {
        public static OrderVM FromOrderToOrderVM(Order order)
        {
            return new OrderVM()
            {
                IsDelivered = order.IsDelivered,
                OrderNumber = order.Id,
                OrderUser = UserMappers.FromUserToUserVM(order.User),
                Pizzas = PizzaMappers.FromPizzasToPizzaVMs(order.Pizzas)
            };
        }

        public static List<OrderVM> FromOrdersToOrderVMs(List<Order> orders)
        {
            return orders.Select(x => FromOrderToOrderVM(x)).ToList();
        }

        public static Order FromOrderVMToOrder(OrderVM orderVM)
        {
            return new Order()
            {
                Id = orderVM.OrderNumber,
                IsDelivered = orderVM.IsDelivered,
                User = UserMappers.FromUserVMToUser(orderVM.OrderUser),
                Pizzas = PizzaMappers.FromPizzaVMsToPizzas(orderVM.Pizzas)
            };
        }

        public static List<Order> FromOrderVMsToOrders(List<OrderVM> orderVMs)
        {
            return orderVMs.Select(x => FromOrderVMToOrder(x)).ToList();
        }
    }
}
