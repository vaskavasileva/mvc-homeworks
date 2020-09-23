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
    public class UserService : IUserService
    {
        private IRepository<User> _userRepo;
        public UserService(IRepository<User> userRepo)
        {
            _userRepo = userRepo;
        }
        public bool CreateUser(UserVM user)
        {
            return _userRepo.Create(UserMappers.FromUserVMToUser(user));
        }

        public bool DeleteUser(UserVM user)
        {
            return _userRepo.Delete(UserMappers.FromUserVMToUser(user).Id);
        }

        public List<UserVM> GetAllUsers()
        {
            return UserMappers.FromUsersToUserVMs(_userRepo.GetAll());
        }

        public UserVM GetUserById(int id)
        {
            return UserMappers.FromUserToUserVM(_userRepo.GetById(id));
        }

        public UserVM LogInUser(string username, string password)
        {
            return UserMappers.FromUserToUserVM(_userRepo.GetAll().SingleOrDefault(user => user.Username == username && user.Password == password));
            
        }

        public bool UpdateUser(UserVM user)
        {
            return _userRepo.Update(UserMappers.FromUserVMToUser(user));
        }
    }
}
