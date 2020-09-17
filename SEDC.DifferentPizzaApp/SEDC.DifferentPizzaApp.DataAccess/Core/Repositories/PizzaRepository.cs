using SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.DifferentPizzaApp.DataAccess.Core.Repositories
{
    public class PizzaRepository : IRepository<Pizza>
    {
        private IStaticDb _db;
        public PizzaRepository(IStaticDb db)
        {
            _db = db;
        }
        public bool Create(Pizza entity)
        {
            var pizza = _db.GetPizzas().SingleOrDefault(x => x.Id == entity.Id);
            if (pizza != null)
            {
                return false;
            }
            _db.GetPizzas().Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var pizza = _db.GetPizzas().SingleOrDefault(x => x.Id == id);
            if (pizza == null)
            {
                return false;
            }
            _db.GetPizzas().Remove(pizza);
            return true;
        }

        public List<Pizza> GetAll()
        {
            return _db.GetPizzas();
        }

        public Pizza GetById(int id)
        {
            return _db.GetPizzas().SingleOrDefault(x => x.Id == id);
        }

        public bool Update(Pizza entity)
        {
            var pizza = _db.GetPizzas().SingleOrDefault(x => x.Id == entity.Id);
            if (pizza == null)
            {
                return false;
            }
            _db.GetPizzas().Remove(pizza);
            _db.GetPizzas().Add(entity);
            return true;
        }
    }
}
