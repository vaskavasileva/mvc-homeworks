using SEDC.DifferentPizzaApp.DataAccess.Core.Enums;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces
{
    public interface IPizzaService
    {
        List<PizzaVM> GetAllPizzas();
        PizzaVM GetPizzaById(int id);
        bool CreatePizza(PizzaVM pizza);
        bool DeletePizza(int id);
        bool UpdatePizza(PizzaVM pizza);
        List<PizzaVM> GetPizzasBySize(PizzaSize size);
    }
}
