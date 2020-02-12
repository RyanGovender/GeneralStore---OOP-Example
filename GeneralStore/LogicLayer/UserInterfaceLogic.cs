using GeneralStore.Models;
using Mono.Cecil.Cil;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.LogicLayer
{
    public class UserInterfaceLogic
    {
        private string code="";
        private int id;
        private int quantity;

        public UserInterfaceLogic()
        {

        }
        public  void Simulate(UserType customer)
        {
            List<int> numbers = new List<int>();
            do
            {
                Console.WriteLine("Enter the product code of the item you want to buy:");
                code = Console.ReadLine();
                if (int.TryParse(code, out id))
                {
                    Console.WriteLine("Enter the Quantity you would like to buy:");
                    if (int.TryParse(Console.ReadLine(), out quantity))
                    {
                        for (int i = 0; i < quantity; i++)
                        {
                            numbers.Add(id);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Product Code.");
                }

            } while (!code.Equals("Done"));

            CalculationLogic cal = new CalculationLogic(numbers, customer);
            Console.WriteLine(cal.CalculateFinalCost());
        }
}
    }
