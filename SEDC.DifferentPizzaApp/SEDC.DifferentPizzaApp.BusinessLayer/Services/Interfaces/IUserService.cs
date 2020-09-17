using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces
{
    public interface IUserService
    {
        List<UserVM> GetAllUsers();
        UserVM GetUserById(int id);
        bool UpdateUser(UserVM user);
        bool CreateUser(UserVM user);
        bool DeleteUser(UserVM user);
    }
}
