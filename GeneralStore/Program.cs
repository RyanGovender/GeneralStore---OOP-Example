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
           

            //List<int> numbers = new List<int>();

            //string code = "";
            //int id;
            //int quantity;
            //do
            //{
            //    Console.WriteLine("Enter the product code of the item you want to buy:");
            //    code = Console.ReadLine();
            //    if(int.TryParse(code,out id))
            //    {
            //        Console.WriteLine("Enter the Quantity you would like to buy:");
            //        if(int.TryParse(Console.ReadLine(),out quantity))
            //        {
            //            for (int i = 0; i < quantity ; i++)
            //            {
            //                numbers.Add(id);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid Product Code.");
            //    }

            //} while (!code.Equals("Done"));

            //CalculationLogic cal = new CalculationLogic(numbers,customer1);
            //Console.WriteLine(cal.CalculateFinalCost());

            //StoreLogic.AddFood();
            Console.ReadKey();
        }
    }
}
