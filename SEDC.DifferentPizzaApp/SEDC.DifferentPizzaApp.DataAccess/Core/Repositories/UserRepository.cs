using SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.DifferentPizzaApp.DataAccess.Core.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private IStaticDb _db;
        public UserRepository(IStaticDb db)
        {
            _db = db;
        }
        public bool Create(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(x => x.Id == entity.Id);
            if (user != null)
            {
                return false;
            }
            _db.GetUsers().Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var user = _db.GetUsers().SingleOrDefault(x => x.Id == id);
            if (user == null)
            {
                return false;
            }
            _db.GetUsers().Remove(user);
            return true;
        }

        public List<User> GetAll()
        {
            return _db.GetUsers();
        }

        public User GetById(int id)
        {
            return _db.GetUsers().SingleOrDefault(x => x.Id == id);
        }

        public bool Update(User entity)
        {
            var user = _db.GetUsers().SingleOrDefault(x => x.Id == entity.Id);
            if (user == null)
            {
                return false;
            }
            _db.GetUsers().Remove(user);
            _db.GetUsers().Add(entity);
            return true;
        }
    }
}
