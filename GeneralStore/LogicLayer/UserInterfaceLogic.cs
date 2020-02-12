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
        private UserType _usertype;

        public UserInterfaceLogic(UserType customer)
        {
            _usertype = customer;
        }
        public List<int> BuyItems()
        {
            List<int> numbers = new List<int>();
            do
            {
                Console.WriteLine("Enter the product code of the item you want to buy (Enter Done to complete your order.):");
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

            } while (!code.ToLower().Equals("done"));

            return numbers;

        }
}
    }
