using SEDC.DifferentPizzaApp.BusinessLayer.Services.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Enums;
using SEDC.DifferentPizzaApp.DataAccess.Core.Interfaces;
using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using SEDC.DifferentPizzaApp.DataAccess.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Services.ActualServices
{
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepo;
        public PizzaService(IRepository<Pizza> pizzaRepo)
        {
            _pizzaRepo = pizzaRepo;
        }
        public bool CreatePizza(PizzaVM pizza)
        {
            throw new NotImplementedException();
        }

        public bool DeletePizza(int id)
        {
            throw new NotImplementedException();
        }

        public List<PizzaVM> GetAllPizzas()
        {
            throw new NotImplementedException();
        }

        public PizzaVM GetPizzaById(int id)
        {
            throw new NotImplementedException();
        }

        public List<PizzaVM> GetPizzasBySize(PizzaSize size)
        {
            throw new NotImplementedException();
        }

        public bool UpdatePizza(PizzaVM pizza)
        {
            throw new NotImplementedException();
        }
    }
}
