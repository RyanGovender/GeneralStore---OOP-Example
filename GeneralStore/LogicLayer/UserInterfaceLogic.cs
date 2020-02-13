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
        private List<int> numbers = new List<int>();

        public UserInterfaceLogic(UserType customer)
        {
            _usertype = customer;
        }
        public List<int> BuyItems()
        {
            do
            {
                Console.WriteLine("Enter the product code of the item you want to buy (Enter Done to complete your order.):");
                code = Console.ReadLine();
                if (int.TryParse(code, out id))
                {
                    Console.WriteLine("Enter the Quantity you would like to buy:");
                    if (int.TryParse(Console.ReadLine(), out quantity))
                    {
                        if(!StoreLogic.CheckQuantity(quantity))
                        {
                            for (int i = 0; i < quantity; i++)
                            {
                                numbers.Add(id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Stock of this item.");
                        }
                       
                    }
                }
                else if(!code.ToLower().Equals("done"))
                {
                    Console.WriteLine("Invalid Product Code.");
                }

            } while (!code.ToLower().Equals("done"));

            return numbers;
        }
    }
}
