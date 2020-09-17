using SEDC.DifferentPizzaApp.DataAccess.Core.Enums;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces
{
    public interface IIngredientService
    {
        List<IngredientVM> GetAllIngredients();
        List<IngredientVM> GetIngredientsByType(IngredientType type);
        IngredientVM GetIngredientById(int id);
    }
}
