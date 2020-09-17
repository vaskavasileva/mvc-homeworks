using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Services.ActualServices
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepo;
        public UserService(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }
        public bool CreateUser(UserVM user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(UserVM user)
        {
            throw new NotImplementedException();
        }

        public List<UserVM> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public UserVM GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserVM user)
        {
            throw new NotImplementedException();
        }
    }
}
