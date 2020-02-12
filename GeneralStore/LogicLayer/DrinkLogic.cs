using GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.LogicLayer
{
  public class DrinkLogic
    {
        public static List<Drink> drinks = GetAllDrinks();
        private static double _defaultReturnAmount = 0;

        private static List<Drink> GetAllDrinks()
        {
            drinks = new List<Drink>
            {
                new Drink(8,"Storm",50,500,true,60),
                new Drink(9,"Coke",10,200,false,50)
            };
            return drinks;
        }

        public static double AddAlcoholTax(int id, double _alcoholTax)
        {
            foreach(var item in drinks)
            {
                if (id == item.id && item.AlcoholicOrNonAloholic)
                    return item.Price * _alcoholTax;
            }
            return _defaultReturnAmount;
        }

        public static double GetDrinkPrice(int id)
        {
            foreach (var item in drinks)
            {
                if (item.id == id)
                {
                    UpdateDrinkQuantity(id);
                    return item.Price;
                }
            }
            return _defaultReturnAmount;
        }

        private static void UpdateDrinkQuantity(int id)
        {
            foreach(var item in drinks)
            {
                if(item.id == id)
                {
                    item.Quantity--;
                    break;
                }
            }
        }

    }
}
