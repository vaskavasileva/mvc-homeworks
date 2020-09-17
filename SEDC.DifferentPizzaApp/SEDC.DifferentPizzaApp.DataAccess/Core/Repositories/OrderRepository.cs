using System.Collections.Generic;
using System.Linq;
using SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;


namespace SEDC.DifferentPizzaApp.DataAccess.Core.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private IStaticDb _db;
        public OrderRepository(IStaticDb db)
        {
            _db = db;
        }
        public bool Create(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(x => x.Id == entity.Id);
            if (order != null)
            {
                return false;
            }
            _db.GetOrders().Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var order = _db.GetOrders().SingleOrDefault(x => x.Id == id);
            if (order == null)
            {
                return false;
            }
            _db.GetOrders().Remove(order);
            return true;
        }

        public List<Order> GetAll()
        {
            return _db.GetOrders();
        }

        public Order GetById(int id)
        {
            return _db.GetOrders().SingleOrDefault(x => x.Id == id);
        }

        public bool Update(Order entity)
        {
            var order = _db.GetOrders().SingleOrDefault(x => x.Id == entity.Id);
            if (order == null)
            {
                return false;
            }
            _db.GetOrders().Remove(order);
            _db.GetOrders().Add(entity);
            return true;
        }
    }
}
