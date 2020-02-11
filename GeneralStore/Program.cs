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
            Console.WriteLine("Hello World!");
   
            var customer1 = new Customer(UserType.CasualCustomer,"Name");

            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            CalculationLogic cal = new CalculationLogic(numbers,customer1);
            Console.WriteLine(cal.CalculateFinalCost());

            StoreLogic.AddFood();
            Console.ReadKey();
        }
    }
}
