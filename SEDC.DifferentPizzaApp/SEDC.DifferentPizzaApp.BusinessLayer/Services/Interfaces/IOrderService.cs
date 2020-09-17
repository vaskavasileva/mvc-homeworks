using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces
{
    public interface IOrderService
    {
        List<OrderVM> GetOrdersForUser(UserVM user);
        List<OrderVM> GetAllOrders();
        OrderVM GetOrderById(int id);
        bool CreateOrder(OrderVM order);
        bool UpdateOrder(OrderVM order);
        bool DeleteOrder(int id);
    }
}
