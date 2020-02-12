using System;
using System.Collections.Generic;
using System.Text;
using GeneralStore.LogicLayer;

namespace GeneralStore.Payment
{
    class CashPayment : Payment
    {
        private double getCash;
        private double change;
       
        public override void PaymentMethod()
        {
            Console.WriteLine("Please enter the amount of cash given below");
            getCash = double.Parse(Console.ReadLine());
            if(getCash == GetTotalPrice.CalculateFinalCost())
            {
                Console.WriteLine("Thanks for the payment.");
            }
            else if(getCash > GetTotalPrice.CalculateFinalCost())
            {
                change = GetTotalPrice.CalculateFinalCost() - getCash;
                Console.WriteLine("Your Change is: "+ change);
            }
            else if (getCash < GetTotalPrice.CalculateFinalCost())
            {
                Console.WriteLine("You need more cash!!!");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
