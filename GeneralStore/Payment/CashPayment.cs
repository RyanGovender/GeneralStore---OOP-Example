using System;
using System.Collections.Generic;
using System.Text;

namespace GeneralStore.Payment
{
    class CashPayment : Payment
    {
        private double getCash;
        private double change;

        public override void PaymentMethod(double GetTotalCost)
        {
            Console.WriteLine("Please enter the amount of cash given below");
            getCash = double.Parse(Console.ReadLine());
            if (getCash == GetTotalCost)
            {
                Console.WriteLine("Thanks for the payment.");
            }
            else if (getCash > GetTotalCost)
            {
                change = getCash - GetTotalCost;
                Console.WriteLine("Your Change is: " + change);
            }
            else if (getCash < GetTotalCost)
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
