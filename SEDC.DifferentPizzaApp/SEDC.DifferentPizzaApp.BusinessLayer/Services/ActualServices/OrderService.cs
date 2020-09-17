using SEDC.DifferentPizzaApp.BusinessLayer.Mappings;
using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Services.ActualServices
{
    public class OrderService : IOrderService
    {
        private IRepository<Order> _orderRepo;
        public OrderService(IRepository<Order> orderRepo)
        {
            _orderRepo = orderRepo;
        }
        public bool CreateOrder(OrderVM order)
        { 
           return _orderRepo.Create(OrderMappers.FromOrderVMToOrder(order));
        }

        public bool DeleteOrder(int id)
        {
            return _orderRepo.Delete(id);
        }

        public List<OrderVM> GetAllOrders()
        {
            return OrderMappers.FromOrdersToOrderVMs(_orderRepo.GetAll());
        }

        public OrderVM GetOrderById(int id)
        {
            return OrderMappers.FromOrderToOrderVM(_orderRepo.GetById(id));
        }

        public List<OrderVM> GetOrdersForUser(UserVM user)
        {
            return OrderMappers.FromOrdersToOrderVMs(_orderRepo.GetAll().Where(x => x.User == UserMappers.FromUserVMToUser(user)).ToList());
        }

        public bool UpdateOrder(OrderVM order)
        {
            return _orderRepo.Update(OrderMappers.FromOrderVMToOrder(order));
        }
    }
}
