using SEDC.DifferentPizzaApp.DataAccess;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Mappings
{
    public static class UserMappers
    {
        public static UserVM FromUserToUserVM(User user)
        {
            return new UserVM()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Address = user.Address,
                Phone = user.Phone,
                Username = user.Username,
                Password = user.Password,
                Orders = OrderMappers.FromOrdersToOrderVMs(user.Orders)
            };
        }

        public static List<UserVM> FromUsersToUserVMs(List<User> users)
        {
            return users.Select(x => FromUserToUserVM(x)).ToList();
        }

        public static User FromUserVMToUser(UserVM userVM)
        {
            return new User()
            {
                FirstName = userVM.FirstName,
                LastName = userVM.LastName,
                Address = userVM.Address,
                Phone = userVM.Phone,
                Username = userVM.Username,
                Password = userVM.Password,
                Orders = OrderMappers.FromOrderVMsToOrders(userVM.Orders)
            };
        }

        public static List<User> FromUserVMsToUsers(List<UserVM> userVMs)
        {
            return userVMs.Select(x => FromUserVMToUser(x)).ToList();
        }
    }
}
