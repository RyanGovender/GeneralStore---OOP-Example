using GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.LogicLayer
{
  public class DrinkLogic
    {
        public static List<Drink> drinks = GetAllDrinks();
        private static double _alcoholTax =0.15;
        private static double _defaultReturnAmount = 0;

        public static List<Drink> GetAllDrinks()
        {
            drinks = new List<Drink>
            {
                new Drink(8,"Storm",50,500,true,60),
                new Drink(9,"Coke",10,200,false,50)
            };
            return drinks;
        }

        public static double AddAlcoholTax(int id)
        {
            foreach(var item in drinks)
            {
                if (id == item.id && item.AlcoholicOrNonAloholic)
                    return item.Price * _alcoholTax;
            }
            return _defaultReturnAmount;
        }

    }
}
