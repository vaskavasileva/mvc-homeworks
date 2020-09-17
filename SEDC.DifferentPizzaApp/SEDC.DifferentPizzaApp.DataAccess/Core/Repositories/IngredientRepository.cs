using SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.DifferentPizzaApp.DataAccess.Core.Repositories
{
    public class IngredientRepository : IRepository<Ingredient>
    {
        private IStaticDb _db;
        public IngredientRepository(IStaticDb db)
        {
            _db = db;
        }
        public bool Create(Ingredient entity)
        {
            var ingredient = _db.GetIngredients().SingleOrDefault(x => x.Id == entity.Id);
            if (ingredient != null)
            {
                return false;
            }
            _db.GetIngredients().Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var ingredient = _db.GetIngredients().SingleOrDefault(x => x.Id == id);
            if (ingredient == null)
            {
                return false;
            }
            _db.GetIngredients().Remove(ingredient);
            return true;

        }

        public List<Ingredient> GetAll()
        {
            return _db.GetIngredients();
        }

        public Ingredient GetById(int id)
        {
            return _db.GetIngredients().SingleOrDefault(x => x.Id == id);
        }

        public bool Update(Ingredient entity)
        {
            var ingredient = _db.GetIngredients().SingleOrDefault(x => x.Id == entity.Id);
            if (ingredient == null)
            {
                return false;
            }
            _db.GetIngredients().Remove(ingredient);
            _db.GetIngredients().Add(entity);
            return true;
        }
    }
}
