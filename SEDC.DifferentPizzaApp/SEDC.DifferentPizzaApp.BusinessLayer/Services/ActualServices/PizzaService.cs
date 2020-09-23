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
    public class PizzaService : IPizzaService
    {
        private IRepository<Pizza> _pizzaRepo;
        public PizzaService(IRepository<Pizza> pizzaRepo)
        {
            _pizzaRepo = pizzaRepo;
        }
        public bool CreatePizza(PizzaVM pizza)
        {
            return _pizzaRepo.Update(PizzaMappers.FromPizzaVMToPizza(pizza));
        }

        public bool DeletePizza(int id)
        {
            return _pizzaRepo.Delete(id);
        }

        public List<PizzaVM> GetAllPizzas()
        {
            return PizzaMappers.FromPizzasToPizzaVMs(_pizzaRepo.GetAll());
        }

        public PizzaVM GetPizzaById(int id)
        {
            return PizzaMappers.FromPizzaToPizzaVM(_pizzaRepo.GetById(id));
        }

        public List<PizzaVM> GetPizzasBySize(PizzaSize size)
        {
            return PizzaMappers.FromPizzasToPizzaVMs(_pizzaRepo.GetAll().Where(x => x.Size == size).ToList());
        }

        public bool UpdatePizza(PizzaVM pizza)
        {
            return _pizzaRepo.Update(PizzaMappers.FromPizzaVMToPizza(pizza));
        }
    }
}
