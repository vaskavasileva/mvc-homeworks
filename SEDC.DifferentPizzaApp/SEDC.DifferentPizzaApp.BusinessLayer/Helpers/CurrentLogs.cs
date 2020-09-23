using SEDC.DifferentPizzaApp.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.DifferentPizzaApp.BusinessLayer.Helpers
{
    public static class CurrentLogs
    {
        public static User LoggedUser { get; set; } = new User();
        public static Pizza CurrentPizza { get; set; } = new Pizza();
        public static Order CurrentOrder { get; set; } = new Order();
    }
}
