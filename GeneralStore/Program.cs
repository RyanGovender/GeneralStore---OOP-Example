using GeneralStore.LogicLayer;
using GeneralStore.Models;
using System;
using System.Collections.Generic;

namespace GeneralStore
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkLogic.DisplayDrinks();
            FoodLogic.DisplayFoods();
            var customer1 = new UserType("Ben", 2);
            var UserI = new UserInterfaceLogic(customer1);
            var items=UserI.BuyItems();
            CalculationLogic cal = new CalculationLogic(items, customer1);
            Console.WriteLine("Your total cost is :"+cal.CalculateFinalCost());

          
            Console.ReadKey();
        }
    }
}
