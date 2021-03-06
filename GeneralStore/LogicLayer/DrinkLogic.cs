﻿using GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralStore.LogicLayer
{
  public class DrinkLogic
    {
        public static List<Drink> drinks = GetAllDrinks();
        private static double _defaultReturnAmount = 0;

        public DrinkLogic(double defaultAmount)
        {
            _defaultReturnAmount = defaultAmount;
        }

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
          return StoreLogic.GetItemPrice(drinks.Cast<Product>().ToList(), id);
        }

        public static void DisplayDrinks()
        {
            foreach(var item in drinks)
            {
                Console.WriteLine($"Item Product Code : {item.id}" +
                    $"\n Product Name : {item.Name}" +
                    $"\n Product Cost :{item.Price}" +
                    $"\n Available Stock :{item.Quantity}" +
                    $"\n Alcohol : {item.AlcoholicOrNonAloholic}" +
                    $"\n-----------------------------------------------");
            }
        }

    }
}
