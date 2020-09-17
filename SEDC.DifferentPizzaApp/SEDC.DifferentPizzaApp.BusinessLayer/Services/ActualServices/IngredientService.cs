using SEDC.DifferentPizzaApp.BusinessLayer.Mappings;
using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Enums;
using SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Services.ActualServices
{
    public class IngredientService : IIngredientService
    {
        private IRepository<Ingredient> _ingredientRepo;
        public IngredientService(IRepository<Ingredient> ingredientRepo)
        {
            _ingredientRepo = ingredientRepo;
        }
        public List<IngredientVM> GetAllIngredients()
        {
            return IngredientMappers.FromIngredientsToIngredientVMs(_ingredientRepo.GetAll());
        }

        public IngredientVM GetIngredientById(int id)
        {
            return IngredientMappers.FromIngredientToIngredientVM(_ingredientRepo.GetAll().SingleOrDefault(x => x.Id == id));
        }

        public List<IngredientVM> GetIngredientsByType(IngredientType type)
        {
            return IngredientMappers.FromIngredientsToIngredientVMs(_ingredientRepo.GetAll().Where(x => x.Type == type).ToList());
        }
    }
}
